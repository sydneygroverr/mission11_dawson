using Microsoft.AspNetCore.Mvc;
using mission11_dawson.Models;
using mission11_dawson.Models.ViewModels;
using System.Diagnostics;

namespace mission11_dawson.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;
        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
                int pageSize = 10;

            var blah = new BooksListViewModel
            {
                Books = _repo.Books
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    currentPage = pageNum,
                    itemsPerPage = pageSize,
                    totalItems = _repo.Books.Count()

                }
            };
                
            return View(blah);
        }

    }
}
