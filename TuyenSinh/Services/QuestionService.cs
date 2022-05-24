using TuyenSinh.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TuyenSinh.Areas.Admin.Models.Question;
using TuyenSinh.Models;

namespace TuyenSinh.Services
{
     public interface IQuestionService
    {
        Task<List<QuestionViewModel>> GetAll();

        Task<int> Create(QuestionCreateRequest request);

        Task<QuestionViewModel> Detail(int id);

        Task<QuestionUpdateRequest> Edit(int id);

        Task<int> Update(QuestionUpdateRequest request);

        Task<int> Delete(int id);
    }
    public class QuestionService:IQuestionService
    {
        private readonly tuyensinhContext _context;
        private readonly IStorageService _storageService;
        private const string USER_CONTENT_FOLDER_NAME = "uploads";

        public QuestionService(tuyensinhContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public async Task<List<QuestionViewModel>> GetAll()
        {
            return await _context.Questions.Select(p => new QuestionViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                Image = p.Image,
                Description = p.Description,
                Detail = p.Detail,
                IsNew = p.IsNew,
                Url = p.Url,
                DisplayOrder = p.DisplayOrder,
                Status = p.Status,
                CreateDate = p.CreateDate
            }).ToListAsync();
        }

         public async Task<int> Create(QuestionCreateRequest request)
        {
            try
            {
                Question news = new Question()
                {
                    Name = request.Name,
                    Image = request.Image,
                    Description = request.Description,
                    Detail = request.Detail,
                    IsNew = request.IsNew,                 
                    Url = request.Url,
                    DisplayOrder = request.DisplayOrder,
                    Status = request.Status,
                    CreateDate = DateTime.Now
                };
                if(request.FileUpload != null)
                {
                    news.Image = await SaveFile(request.FileUpload);
                }
                _context.Questions.Add(news);
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
                Question news = await _context.Questions.FindAsync(id);
                if (news == null) return -1;
                if (news.Image != null)
                {
                    await _storageService.DeleteFileAsync(news.Image);
                }
                _context.Questions.Remove(news);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public async Task<QuestionViewModel> Detail(int id)
        {
            try
            {
                return await _context.Questions.Where(x=>x.Id==id).Select(p => new QuestionViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Image = p.Image,
                    Description = p.Description,
                    Detail = p.Detail,
                    IsNew = p.IsNew
                }).FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<QuestionUpdateRequest> Edit(int id)
        {
            try
            {
                Question news = await _context.Questions.FindAsync(id);
                if (news == null) return null;
                QuestionUpdateRequest updateQuestionViewModel = new QuestionUpdateRequest()
                {
                    Id = news.Id,
                    Name = news.Name,
                    Image = news.Image,
                    Description = news.Description,
                    Detail = news.Detail,
                    IsNew = news.IsNew,
                    Url = news.Url,
                    DisplayOrder = news.DisplayOrder,
                    Status = news.Status
                };

                return updateQuestionViewModel;
            }
            catch (Exception)
            {
                return null;
            }
        }  
     
        public async Task<int> Update(QuestionUpdateRequest request)
        {
            try
            {
                Question news = await _context.Questions.FindAsync(request.Id);
                if (news == null) return -1;
                news.Name = request.Name;
                news.Description = request.Description;
                news.Detail = request.Detail;
                news.IsNew = request.IsNew;
                news.Url = request.Url;
                news.DisplayOrder = request.DisplayOrder;
                news.Status = request.Status;
                news.EditDate = DateTime.Now;
                if (request.FileUpload != null)
                {
                    await _storageService.DeleteFileAsync(news.Image);
                    news.Image = await SaveFile(request.FileUpload);
                }
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return "/" + USER_CONTENT_FOLDER_NAME + "/" + fileName;
        }

    }
}
