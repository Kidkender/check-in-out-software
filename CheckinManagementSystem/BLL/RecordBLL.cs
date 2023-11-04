using CheckinManagementSystem.Control;
using CheckinManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckinManagementSystem.BLL
{
    public class RecordBLL
    {
        CheckInEntities _context = new CheckInEntities();

        public List<Record> GetAllRecord()
        {
            return _context.Record.ToList();
        }

        public List<LoaiRecord> GetAllLoaiRecord()
        {
            var data = _context.LoaiRecord.ToList();
            data.Insert(0, new LoaiRecord() { ID = 0, TenLoaiRecord = "Điểm danh" });
            return data;
        }

        public List<SP_GetAllDangKy_Result> GetAllDangKy()
        {
            return _context.SP_GetAllDangKy().ToList();
        }

        public List<SP_QuanLyCheckIn_Result> GetAllHistory(int? iDNhanVien, int? iDPhong, DateTime? tuNgay, DateTime? denNgay)
        {
            return _context.SP_QuanLyCheckIn(iDNhanVien, iDPhong, tuNgay, denNgay).ToList();
        }
    }
}
