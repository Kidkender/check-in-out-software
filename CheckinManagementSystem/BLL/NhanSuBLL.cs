using CheckinManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckinManagementSystem.BLL
{
    public class NhanSuBLL
    {
        CheckInEntities _context = new CheckInEntities();

        public List<NhanSu> GetAllNhanSu()
        {
            return _context.NhanSu.ToList();
        }

        public List<Phong> GetAlPhong()
        {
            return _context.Phong.ToList();
        }

        public List<SP_GetAllNhanSu_Result> GetAllNhanSu_Grid()
        {
            return _context.SP_GetAllNhanSu().ToList();
        }

        public NhanSu GetNhanSuById(int? IdNhanSu)
        {
            return _context.NhanSu.FirstOrDefault(t => t.ID == IdNhanSu);
        }

        public void DeleteNhanSuById(int? IdNhanSu)
        {
            NhanSu ns = _context.NhanSu.FirstOrDefault(t => t.ID == IdNhanSu);
            _context.NhanSu.Remove(ns);
            _context.SaveChanges();
        }

        public int AddEditNhanSu(string HoTen, string maNhanSu, string TenPhong, int? IDNhanSu = null)
        {
            int result = 0;
            var IdPhong = _context.Phong.FirstOrDefault(t => t.TenPhong == TenPhong)?.ID;
            if (IdPhong != null)
            {
                NhanSu ns = _context.NhanSu.FirstOrDefault(t => t.ID == IDNhanSu);
                if (ns == null)
                {
                    ns = new NhanSu();
                    _context.NhanSu.Add(ns);
                }

                ns.HoTen = HoTen;
                ns.MaNhanSu = maNhanSu;
                ns.IdPhong = IdPhong;

                result = _context.SaveChanges();
            }
            return result;
        }
    }
}
