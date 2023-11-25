using CheckinManagementSystem.Control;
using CheckinManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CheckinManagementSystem.BLL
{
    public class NhanSuBLL
    {
        CheckInEntities _context;

        public List<NhanSu> GetAllNhanSu()
        {
            _context = new CheckInEntities();
            return _context.NhanSu.Where(t => t.MaNhanSu != "master").ToList();
        }

        public List<Phong> GetAllPhong()
        {
            _context = new CheckInEntities();
            return _context.Phong.ToList();
        }

        public List<SP_GetAllNhanSu_Result> GetAllNhanSu_Grid()
        {
            _context = new CheckInEntities();
            return _context.SP_GetAllNhanSu().Where(t => t.MaNhanSu != "master").ToList();
        }

        public NhanSu GetNhanSuById(int? IdNhanSu)
        {
            _context = new CheckInEntities();
            return _context.NhanSu.FirstOrDefault(t => t.ID == IdNhanSu);
        }

        public void DeleteNhanSuById(int? IdNhanSu)
        {
            _context = new CheckInEntities();
            NhanSu ns = _context.NhanSu.FirstOrDefault(t => t.ID == IdNhanSu);
            _context.NhanSu.Remove(ns);
            _context.SaveChanges();
        }

        public string AddEditNhanSu(string HoTen, string maNhanSu, string TenPhong, int? IDNhanSu = null)
        {
            _context = new CheckInEntities();
            int result = 0;
            var IdPhong = _context.Phong.FirstOrDefault(t => t.TenPhong == TenPhong)?.ID;
            if (_context.NhanSu.Any(t => t.MaNhanSu == maNhanSu && t.ID != IDNhanSu) || string.IsNullOrEmpty(maNhanSu))
            {
                return maNhanSu;
            }
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

                _context.SaveChanges();
            }
            return "";
        }

        public void SetPassWordAdmin(string PassWordAdmin)
        {
            _context = new CheckInEntities();
            NhanSu ns = _context.NhanSu.FirstOrDefault(t => t.MaNhanSu == "master");
            if (ns != null)
            {
                ns.HoTen = CalculateMD5Hash(PassWordAdmin);
                _context.SaveChanges();
            }
        }

        public bool LoginAdmin(string UserAdmin, string PassWordAdmin)
        {
            _context = new CheckInEntities();
            PassWordAdmin = CalculateMD5Hash(PassWordAdmin);
            return _context.NhanSu.Any(t => t.MaNhanSu == UserAdmin && t.HoTen == PassWordAdmin);
        }

        string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2")); // Format byte thành dạng hex
                }

                return sb.ToString();
            }
        }
    }
}
