using FileParser.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileParser.Repositories
{
    public interface IBinParserRepository
    {
        Task<List<ParsedMessage>> ParseBinFileAsync(IFormFile file);
    }
}