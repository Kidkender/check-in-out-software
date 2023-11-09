using CheckinManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckinManagementSystem.BLL
{
    public class PhongBLL
    {
        CheckInEntities _context = new CheckInEntities();

        public List<Phong> GetAllPhong()
        {
            return _context.Phong.ToList();
        }

        public List<Phong> GetAllPhong_Grid()
        {
            return _context.Phong.ToList();
        }

        public List<Phong> GetAllPhong_Grid(string text)
        {
            if(string.IsNullOrEmpty(text))
                return _context.Phong.ToList();
            return _context.Phong.Where(t=>t.TenPhong.Trim().ToLower().Contains(text.ToLower().Trim())).ToList();
        }

        public bool checkExists(string ten)
        {
            var check = _context.Phong.Where(t=> t.TenPhong.Trim().ToLower() == ten.Trim().ToLower()).FirstOrDefault();
            if (check != null)
                return true;
            else
            return false;
        }

        public Phong GetPhongById(int? Id)
        {
            return _context.Phong.FirstOrDefault(t => t.ID == Id);
        }

        public void DeletePhongById(int? Id)
        {
            Phong p = _context.Phong.FirstOrDefault(t => t.ID == Id);
            _context.Phong.Remove(p);
            _context.SaveChanges();
        }

        public void AddEditPhong(Phong model)
        {
            int result = 0;
            Phong p = _context.Phong.FirstOrDefault(t => t.ID == model.ID);
            if (p == null)
            {
                p = new Phong()
                {
                    ID = 0,
                    TenPhong = model.TenPhong,
                    ThoiGianVao = model.ThoiGianVao,
                    ThoiGianRa = model.ThoiGianRa,
                    MoTa = model.MoTa
                };
                _context.Phong.Add(p);
            }
            else
            {
                p.MoTa = model.MoTa;
                p.ThoiGianRa = model.ThoiGianRa;
                p.ThoiGianVao = model.ThoiGianVao;
                p.TenPhong = model.TenPhong;

                _context.Phong.AddOrUpdate(p);
            }

            result = _context.SaveChanges();
        }
    }
}
