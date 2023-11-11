using CheckinManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CheckinManagementSystem.BLL
{
    public class PhongBLL
    {
        CheckInEntities _context;

        public List<Phong> GetAllPhong()
        {
            _context = new CheckInEntities();
            return _context.Phong.ToList();
        }

        public List<Phong> GetAllPhong_Grid()
        {
            _context = new CheckInEntities();
            return _context.Phong.ToList();
        }

        public List<Phong> GetAllPhong_Grid(string text)
        {
            _context = new CheckInEntities();
            if (string.IsNullOrEmpty(text))
                return _context.Phong.ToList();
            return _context.Phong.Where(t => t.TenPhong.Trim().ToLower().Contains(text.ToLower().Trim())).ToList();
        }

        public bool checkExists(string ten)
        {
            _context = new CheckInEntities();
            var check = _context.Phong.Where(t => t.TenPhong.Trim().ToLower() == ten.Trim().ToLower()).FirstOrDefault();
            if (check != null)
                return true;
            else
                return false;
        }

        public Phong GetPhongById(int? Id)
        {
            _context = new CheckInEntities();
            return _context.Phong.FirstOrDefault(t => t.ID == Id);
        }

        public void DeletePhongById(int? Id)
        {
            _context = new CheckInEntities();
            Phong p = _context.Phong.FirstOrDefault(t => t.ID == Id);
            _context.Phong.Remove(p);
            _context.SaveChanges();
        }

        public void AddEditPhong(Phong model)
        {
            _context = new CheckInEntities();
            Phong p = _context.Phong.FirstOrDefault(t => t.ID == model.ID);
            if (p == null)
            {
                p = new Phong()
                {
                    TenPhong = model.TenPhong,
                    ThoiGianVao = model.ThoiGianVao,
                    ThoiGianRa = model.ThoiGianRa,
                    MoTa = model.MoTa
                };
                _context.Phong.Add(p);
            }
            p.TenPhong = model.TenPhong;
            p.ThoiGianVao = model.ThoiGianVao;
            p.ThoiGianRa = model.ThoiGianRa;
            p.MoTa = model.MoTa;

            _context.SaveChanges();
        }
    }
}
