using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TuyenSinh.Model;
using TuyenSinh.Models;

namespace TuyenSinh.Services
{
    public interface IStudentService
    {
        Task<int> DangKyHocBa(DangKyHocBaModel request);
    }
    public class StudentService : IStudentService
    {
        private readonly tuyensinhContext _context;
        private readonly IStorageService _storageService;
        private const string USER_CONTENT_FOLDER_NAME = "uploads";

        public StudentService(tuyensinhContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public async Task<int> DangKyHocBa(DangKyHocBaModel request)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    Student student = new Student()
                    {
                        Name = request.Name,
                        NationId = request.NationId,
                        Address = request.Address,
                        Email = request.Email,
                        Dob = request.Dob,
                        Gender = request.Gender,
                        Cmnd = request.Cmnd,
                        Status = request.Status,
                        CreateDate = DateTime.Now,
                        ProvinceId = request.ProvinceId,
                        Phone = request.Phone
                    };
                   
                    _context.Students.Add(student);
                    await _context.SaveChangesAsync();
                    var infoTHPT = new InfoThpt()
                    {
                        Province10Id = request.Province10Id,
                        Province11Id=request.Province11Id,
                        Province12Id=request.Province12Id,
                        School10Id=request.School10Id,
                        School11Id=request.School11Id,
                        School12Id=request.School12Id,
                        AbilityId=request.AbilityId,
                        ConductId=request.ConductId,
                        Point=request.Point,
                        Sbd=request.Sbd,
                        Hsddkxt=request.Hsddkxt,
                        Math=request.Math,
                        Literature=request.Literature,
                        English=request.English,
                        Physics=request.Physics,
                        Chemistry=request.Chemistry,
                        Biology=request.Biology,
                        History=request.History,
                        Geography=request.Geography,
                        StudentId=student.Id
                    };
                    if (request.ScoreCardFile != null)
                    {
                        infoTHPT.ScoreCard = await SaveFile(request.ScoreCardFile);
                    }
                    if (request.GraduationFile != null)
                    {
                        infoTHPT.Graduation = await SaveFile(request.GraduationFile);
                    }
                    _context.InfoThpts.Add(infoTHPT);

                    var wish = new Wish()
                    {
                        Major1Id = request.Major1Id,
                        Major2Id = request.Major2Id,
                        Combination1Id = request.Combination1Id,
                        Combination2Id = request.Combination2Id,
                        Point1 = request.Point1,
                        Point2 = request.Point2,
                        StudentId = student.Id
                    };
                    _context.Wishes.Add(wish);

                    int res = await _context.SaveChangesAsync();
                    transaction.Commit();
                    return res;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return -1;
                }
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
