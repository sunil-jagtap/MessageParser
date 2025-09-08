using FileParser.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileParser.Services
{
    public interface IBinParserService
    {
        Task<List<ParsedMessage>> ParseBinFileAsync(IFormFile file);
    }
}