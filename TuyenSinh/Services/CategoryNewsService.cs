using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuyenSinh.Areas.Admin.Models.CategoryNews;
using TuyenSinh.Model;
using TuyenSinh.Models;

namespace TuyenSinh.Services
{
    public interface ICategoryNewsService
    {

        Task<List<CategoryNewsViewModel>> GetAll();
        Task<List<CategoryNewsViewModel>> GetEdit(int id);

        Task<int> Create(CategoryNewsRequest request);

        Task<CategoryNewsViewModel> Detail(int id);

        Task<CategoryNewsRequest> Edit(int id);

        Task<int> Update(CategoryNewsRequest request);

        Task<int> Delete(int id);
    }
    public class CategoryNewsService : ICategoryNewsService
    {
        private readonly tuyensinhContext _context;

        public CategoryNewsService(tuyensinhContext context)
        {
            _context = context;
        }

        public async Task<int> Create(CategoryNewsRequest request)
        {
            try
            {
                Category categoriesNew = new Category()
                {
                    Name = request.Name,
                    Description = request.Description,
                    ShowHome = request.ShowHome,
                    Url = request.Url,
                    DisplayOrder = request.DisplayOrder,
                    Status = request.Status,
                    CreateDate = DateTime.Now
                };
                _context.Categories.Add(categoriesNew);
                int res = await _context.SaveChangesAsync();
                return res;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public async Task<int> Delete(int id)
        {
            try
            {
                Category newsCategory = await _context.Categories.FindAsync(id);
                if (newsCategory == null) return -1;
                _context.Categories.Remove(newsCategory);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public async Task<CategoryNewsViewModel> Detail(int id)
        {
            try
            {
                Category category = await _context.Categories.FindAsync(id);
                CategoryNewsViewModel detailCategoryNewsViewModel = new CategoryNewsViewModel()
                {
                    Id = category.Id,
                    Name = category.Name,
                    ShowHome = category.ShowHome,
                    Description = category.Description,
                    Url = category.Url,
                    DisplayOrder = category.DisplayOrder,
                    Status = category.Status
                };
                return detailCategoryNewsViewModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<CategoryNewsRequest> Edit(int id)
        {
            try
            {
                Category category = await _context.Categories.FindAsync(id);
                if (category == null) return null;
                CategoryNewsRequest updateCategorysViewModel = new CategoryNewsRequest()
                {
                    Id = category.Id,
                    Name = category.Name,
                    ShowHome = category.ShowHome,
                    Description = category.Description,
                    Url = category.Url,
                    DisplayOrder = category.DisplayOrder,
                    Status = category.Status
                };

                return updateCategorysViewModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<CategoryNewsViewModel>> GetAll()
        {

            return await _context.Categories.Select(p => new CategoryNewsViewModel()
            {

                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                ShowHome = p.ShowHome,
                Url = p.Url,
                DisplayOrder = p.DisplayOrder,
                Status = p.Status,
                CreateDate = p.CreateDate
            }).ToListAsync();
        }

        public async Task<List<CategoryNewsViewModel>> GetEdit(int id)
        {

            return await _context.Categories.Where(x => x.Id != id).Select(p => new CategoryNewsViewModel()
            {

                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                ShowHome = p.ShowHome,
                Url = p.Url,
                DisplayOrder = p.DisplayOrder,
                Status = p.Status,
                CreateDate = p.CreateDate
            }).ToListAsync();
        }



        public async Task<int> Update(CategoryNewsRequest request)
        {
            try
            {
                Category category = await _context.Categories.FindAsync(request.Id);
                if (category == null) return -1;
                category.Name = request.Name;
                category.Description = request.Description;
                category.Url = request.Url;
                category.DisplayOrder = request.DisplayOrder;
                category.Status = request.Status;
                category.ShowHome = request.ShowHome;
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
