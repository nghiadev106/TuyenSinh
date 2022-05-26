using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuyenSinh.Areas.Admin.Models.Major;
using TuyenSinh.Model;
using TuyenSinh.Models;

namespace TuyenSinh.Services
{
    public interface IMajorService
    {

        Task<List<MajorViewModel>> GetAll();
        Task<List<MajorViewModel>> GetEdit(int id);

        Task<int> Create(MajorRequest request);

        Task<MajorViewModel> Detail(int id);

        Task<MajorRequest> Edit(int id);

        Task<int> Update(MajorRequest request);

        Task<int> Delete(int id);
    }
    public class MajorService : IMajorService
    {
        private readonly tuyensinhContext _context;

        public MajorService(tuyensinhContext context)
        {
            _context = context;
        }

        public async Task<int> Create(MajorRequest request)
        {
            try
            {
                Major categoriesNew = new Major()
                {
                    Name = request.Name,
                    Description = request.Description,
                    Combination1= request.Combination1,
                    Combination2 = request.Combination2,
                    Combination3 = request.Combination3,
                    Combination4 = request.Combination4,
                    Code=request.Code,                  
                    CreateDate = DateTime.Now
                };
                _context.Majors.Add(categoriesNew);
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
                Major newsMajor = await _context.Majors.FindAsync(id);
                if (newsMajor == null) return -1;
                _context.Majors.Remove(newsMajor);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public async Task<MajorViewModel> Detail(int id)
        {
            try
            {
                Major m = await _context.Majors.FindAsync(id);
                MajorViewModel detailMajorViewModel = new MajorViewModel()
                {
                    Id = m.Id,
                    Name = m.Name,
                    Code=m.Code,                   
                    CreateDate = m.CreateDate,
                    Description = m.Description,
                    Combination1Id = m.Combination1,
                    Combination2Id = m.Combination2,
                    Combination3Id = m.Combination3,
                    Combination4Id = m.Combination4,
                    Combination1Name = _context.Combinations.Where(x=>x.Id==m.Combination1).FirstOrDefault().Name,
                    Combination2Name = _context.Combinations.Where(x => x.Id == m.Combination2).FirstOrDefault().Name,
                    Combination3Name = _context.Combinations.Where(x => x.Id == m.Combination3).FirstOrDefault().Name,
                    Combination4Name = _context.Combinations.Where(x => x.Id == m.Combination4).FirstOrDefault().Name,
                };
                return detailMajorViewModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<MajorRequest> Edit(int id)
        {
            try
            {
                Major m = await _context.Majors.FindAsync(id);
                if (m == null) return null;
                MajorRequest updateMajorsViewModel = new MajorRequest()
                {
                    Id = m.Id,
                    Name = m.Name,
                    CreateDate = m.CreateDate,
                    Description = m.Description,
                    Combination1 = m.Combination1,
                    Combination2 = m.Combination2,
                    Combination3 = m.Combination3,
                    Combination4 = m.Combination4,
                    Code=m.Code,
                    EditDate=DateTime.Now
                };

                return updateMajorsViewModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<MajorViewModel>> GetAll()
        {

            return await _context.Majors.Select(m => new MajorViewModel()
            {

                Id = m.Id,
                Name = m.Name,
                Code = m.Code,
                CreateDate = m.CreateDate,
                Description = m.Description,
                Combination1Id = m.Combination1,
                Combination2Id = m.Combination2,
                Combination3Id = m.Combination3,
                Combination4Id = m.Combination4,
                Combination1Name = _context.Combinations.Where(x => x.Id == m.Combination1).FirstOrDefault().Name,
                Combination2Name = _context.Combinations.Where(x => x.Id == m.Combination2).FirstOrDefault().Name,
                Combination3Name = _context.Combinations.Where(x => x.Id == m.Combination3).FirstOrDefault().Name,
                Combination4Name = _context.Combinations.Where(x => x.Id == m.Combination4).FirstOrDefault().Name,
            }).ToListAsync();
        }

        public async Task<List<MajorViewModel>> GetEdit(int id)
        {

            return await _context.Majors.Where(x => x.Id != id).Select(m => new MajorViewModel()
            {

                Id = m.Id,
                Name = m.Name,
                Code = m.Code,
                CreateDate = m.CreateDate,
                Description = m.Description,
                Combination1Id = m.Combination1,
                Combination2Id = m.Combination2,
                Combination3Id = m.Combination3,
                Combination4Id = m.Combination4,
                Combination1Name = _context.Combinations.Where(x => x.Id == m.Combination1).FirstOrDefault().Name,
                Combination2Name = _context.Combinations.Where(x => x.Id == m.Combination2).FirstOrDefault().Name,
                Combination3Name = _context.Combinations.Where(x => x.Id == m.Combination3).FirstOrDefault().Name,
                Combination4Name = _context.Combinations.Where(x => x.Id == m.Combination4).FirstOrDefault().Name,
            }).ToListAsync();
        }



        public async Task<int> Update(MajorRequest request)
        {
            try
            {
                Major m = await _context.Majors.FindAsync(request.Id);
                if (m == null) return -1;
                m.Name = request.Name;
                m.Description = request.Description;
                m.EditDate = DateTime.Now;
                m.Code = request.Code;
                m.Combination1 = request.Combination1;
                m.Combination2 = request.Combination2;
                m.Combination3 = request.Combination3;
                m.Combination4 = request.Combination4;
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
