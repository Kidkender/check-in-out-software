using CheckinManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckinManagementSystem.BLL
{
    public class NoiQuyBLL
    {
        CheckInEntities _context = new CheckInEntities();

        //public List<NoiQuy> GetAllNoiQuy()
        //{
        //    return _context.NoiQuy.ToList();
        //}

        //public List<NoiQuy> GetAllNoiQuy_Grid()
        //{
        //    return _context.NoiQuy.ToList();
        //}

        //public NoiQuy GetNoiQuyById(int? Id)
        //{
        //    return _context.NoiQuy.FirstOrDefault(t => t.ID == Id);
        //}

        //public void DeleteNoiQuyById(int? Id)
        //{
        //    NoiQuy p = _context.NoiQuy.FirstOrDefault(t => t.ID == Id);
        //    _context.NoiQuy.Remove(p);
        //    _context.SaveChanges();
        //}

        //public int AddEditNoiQuy(NoiQuy model)
        //{
        //    int result = 0;
        //    NoiQuy p = _context.NoiQuy.FirstOrDefault(t => t.ID == model.ID);
        //    if (p == null)
        //    {
        //        p = new NoiQuy()
        //        {
        //            ID = 0,
        //            TenNoiQuy = model.TenNoiQuy,
        //            ThoiGianVao = model.ThoiGianVao,
        //            ThoiGiaRa = model.ThoiGiaRa,
        //            MoTa = model.MoTa
        //        };
        //        _context.NoiQuy.Add(p);
        //    }
        //    else
        //    {
        //        p.MoTa = model.MoTa;
        //        p.ThoiGiaRa = model.ThoiGiaRa;
        //        p.ThoiGianVao = model.ThoiGianVao;
        //        p.TenNoiQuy = model.TenNoiQuy;

        //        _context.NoiQuy.AddOrUpdate(p);
        //    }

        //    result = _context.SaveChanges();
        //    return result;
        //}
    }
}
