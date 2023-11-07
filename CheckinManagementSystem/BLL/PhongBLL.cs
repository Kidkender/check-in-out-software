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

        public int AddEditPhong(Phong model)
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
            return result;
        }
    }
}
