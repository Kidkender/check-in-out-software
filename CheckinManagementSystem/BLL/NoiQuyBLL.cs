using CheckinManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CheckinManagementSystem.BLL
{
    public class NoiQuyBLL
    {
        CheckInEntities _context;

        public List<NoiQuy> GetAllNoiQuy()
        {
            _context = new CheckInEntities();
            return _context.NoiQuy.ToList();
        }

        public List<NoiQuy> GetAllNoiQuy_Grid()
        {
            _context = new CheckInEntities();
            return _context.NoiQuy.ToList();
        }

        public List<NoiQuy> GetAllNoiQuy_Grid(string text)
        {
            _context = new CheckInEntities();
            if (string.IsNullOrEmpty(text))
                return _context.NoiQuy.ToList();
            return _context.NoiQuy.Where(t => t.NoiDung.Trim().ToLower().Contains(text.ToLower().Trim())).ToList();
        }

        public NoiQuy GetNoiQuyById(int? Id)
        {
            _context = new CheckInEntities();
            return _context.NoiQuy.FirstOrDefault(t => t.ID == Id);
        }

        public void DeleteNoiQuyById(int? Id)
        {
            _context = new CheckInEntities();
            NoiQuy p = _context.NoiQuy.FirstOrDefault(t => t.ID == Id);
            _context.NoiQuy.Remove(p);
            _context.SaveChanges();
        }

        public void AddEditNoiQuy(NoiQuy model)
        {
            _context = new CheckInEntities();
            int result = 0;
            NoiQuy p = _context.NoiQuy.FirstOrDefault(t => t.ID == model.ID);
            if (p == null)
            {
                p = new NoiQuy();
                _context.NoiQuy.Add(p);
            }
            p.NoiDung = model.NoiDung;
            p.XuPhat = model.XuPhat;
            p.LoaiNoiQuy = model.LoaiNoiQuy;

            result = _context.SaveChanges();
        }
    }
}
