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

        public bool AddRecord(int? IdNhanSu)
        {
            int result = 0;
            if (IdNhanSu != null)
            {
                Record record = new Record()
                {
                    IdLoaiRecord = 0,
                    IdNhanSu = IdNhanSu,
                    ThoiGian = DateTime.Now,
                    InOut = 0
                };
                _context.Record.Add(record);
                result = _context.SaveChanges();
            }
            return result > 0;
        }
    }
}
