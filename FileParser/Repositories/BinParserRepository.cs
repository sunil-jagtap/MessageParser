using FileParser.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileParser.Repositories
{
    public class BinParserRepository : IBinParserRepository
    {
        public async Task<List<ParsedMessage>> ParseBinFileAsync(IFormFile file)
        {
            List<ParsedMessage> messages = new();

            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                stream.Position = 0;

                using var reader = new BinaryReader(stream, Encoding.UTF8, leaveOpen: true);

                while (stream.Position < stream.Length)
                {
                    if (stream.Length - stream.Position < 8)
                        break;

                    int payloadHeader = reader.ReadInt32();
                    int sequenceNumber = reader.ReadInt32();

                    if (stream.Length - stream.Position < payloadHeader)
                        break;

                    byte[] messageBytes = reader.ReadBytes(payloadHeader);
                    string message = Encoding.UTF8.GetString(messageBytes);

                    messages.Add(new ParsedMessage
                    {
                        SequenceNumber = sequenceNumber,
                        Message = message
                    });
                }
            }

            return messages;
        }
    }
}