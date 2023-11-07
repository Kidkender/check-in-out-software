using CheckinManagementSystem.Control;
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

        public List<DanhMucRole> GetAllNoiQuy()
        {
            return _context.DanhMucRole.ToList();
        }

        public DanhMucRole GetNoiQuyById(int? IDNoiQuy)
        {
            return _context.DanhMucRole.FirstOrDefault(t => t.ID == IDNoiQuy);
        }

        public void DeleteNoiQuyById(int? IdNhanSu)
        {
            DanhMucRole rl = _context.DanhMucRole.FirstOrDefault(t => t.ID == IdNhanSu);
            _context.DanhMucRole.Remove(rl);
            _context.SaveChanges();
        }

        public int AddEditNoiQuy(string Ten, string MoTa, int? IdNoiQuy = null)
        {
            int result = 0;

            DanhMucRole rl = _context.DanhMucRole.FirstOrDefault(t => t.ID == IdNoiQuy);
            if (rl == null)
            {
                rl = new DanhMucRole();
                _context.DanhMucRole.Add(rl);
            }

            rl.TenRole = Ten;
            rl.MoTa = MoTa;

            result = _context.SaveChanges();

            return result;
        }
    }
}
