using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using NorthwindUI.Models;

namespace NorthwindUI.ViewComponants
{
    public class CategoryListViewComponent:ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll().Data
            };
            return View(model);
        }
    }
}
