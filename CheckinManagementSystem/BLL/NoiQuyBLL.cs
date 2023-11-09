using CheckinManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CheckinManagementSystem.BLL
{
    public class NoiQuyBLL
    {
        CheckInEntities _context = new CheckInEntities();

        public List<NoiQuy> GetAllNoiQuy()
        {
            return _context.NoiQuy.ToList();
        }

        public List<NoiQuy> GetAllNoiQuy_Grid()
        {
            return _context.NoiQuy.ToList();
        }

        public List<NoiQuy> GetAllNoiQuy_Grid(string text)
        {
            if(string.IsNullOrEmpty(text))
                return _context.NoiQuy.ToList();
            return _context.NoiQuy.Where(t => t.NoiDung.Trim().ToLower().Contains(text.ToLower().Trim())).ToList();
            
        }

        public NoiQuy GetNoiQuyById(int? Id)
        {
            return _context.NoiQuy.FirstOrDefault(t => t.ID == Id);
        }

        public void DeleteNoiQuyById(int? Id)
        {
            NoiQuy p = _context.NoiQuy.FirstOrDefault(t => t.ID == Id);
            _context.NoiQuy.Remove(p);
            _context.SaveChanges();
        }

        public void AddEditNoiQuy(NoiQuy model)
        {
            int result = 0;
            NoiQuy p = _context.NoiQuy.FirstOrDefault(t => t.ID == model.ID);
            if (p == null)
            {
                p = new NoiQuy()
                {
                    ID = 0,
                    NoiDung = model.NoiDung,
                    XuPhat = model.XuPhat,
                };
                _context.NoiQuy.Add(p);
            }
            else
            {
                p.NoiDung = model.NoiDung;
                p.XuPhat = model.XuPhat;
             
                _context.NoiQuy.AddOrUpdate(p);
            }

            result = _context.SaveChanges();
        }
    }
}
