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
            return data;
        }

        public List<SP_GetAllDangKy_Result> GetAllDangKy(bool status = false)
        {
            return _context.SP_GetAllDangKy(status).ToList();
        }

        public List<SP_GetAllDiemDanh_Result> GetAllDiemDanh()
        {
            return _context.SP_GetAllDiemDanh().ToList();
        }

        public List<SP_QuanLyCheckIn_Result> GetAllHistory(string tuKhoa,int? iDNhanSu, int? iDPhong, DateTime? tuNgay, DateTime? denNgay)
        {
            return _context.SP_QuanLyCheckIn(tuKhoa, iDNhanSu, iDPhong, tuNgay, denNgay).ToList();
        }
    }
}
