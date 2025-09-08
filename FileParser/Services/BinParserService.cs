using FileParser.Models;
using FileParser.Repositories;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileParser.Services
{
    public class BinParserService : IBinParserService
    {
        private readonly IBinParserRepository _repository;

        public BinParserService(IBinParserRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ParsedMessage>> ParseBinFileAsync(IFormFile file)
        {
            return await _repository.ParseBinFileAsync(file);
        }
    }
}