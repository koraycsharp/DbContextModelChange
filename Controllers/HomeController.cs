using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbContextModelReplace.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbContextModelReplace.Controllers
{
    public class HomeController : Controller
    {
        private readonly ModelChangeContext1 _dataContext;

        public HomeController(ModelChangeContext1 dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<List<int>> Index1()
        {
            return await _dataContext.Table1.Select(x => x.Id).ToListAsync();
        }

        [HttpGet]
        public async Task<List<int>> Index2()
        {
            _dataContext.Schema = "Schema2";
            return await _dataContext.Table1.Select(x => x.Id).ToListAsync();
        }

        [HttpGet]
        public async Task<List<int>> Index3()
        {
            await _dataContext.Table1.Select(x => x.Id).ToListAsync();
            _dataContext.Schema = "Schema2";
            return await _dataContext.Table1.Select(x => x.Id).ToListAsync();
        }
    }
}
