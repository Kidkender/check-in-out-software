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
        CheckInEntities _context;

        public List<Record> GetAllRecord()
        {
            _context = new CheckInEntities();
            return _context.Record.ToList();
        }

        public List<LoaiRecord> GetAllLoaiRecord()
        {
            _context = new CheckInEntities();
            var data = _context.LoaiRecord.ToList();
            return data;
        }

        public List<SP_GetAllDangKy_Result> GetAllDangKy(bool status = false)
        {
            _context = new CheckInEntities();
            return _context.SP_GetAllDangKy(status).ToList();
        }

        public List<SP_GetAllDiemDanh_Result> GetAllDiemDanh()
        {
            _context = new CheckInEntities();
            return _context.SP_GetAllDiemDanh().ToList();
        }

        public List<SP_QuanLyCheckIn_Result> GetAllHistory(string tuKhoa, int? iDNhanSu, int? iDPhong, DateTime? tuNgay, DateTime? denNgay)
        {
            _context = new CheckInEntities();
            return _context.SP_QuanLyCheckIn(tuKhoa, iDNhanSu, iDPhong, tuNgay, denNgay).ToList();
        }

        public void UpdateGhiChu(int? ID, string GhiChu)
        {
            _context = new CheckInEntities();
            Record p = _context.Record.FirstOrDefault(t => t.ID == ID);
            if (p != null)
            {
                p.GhiChu = GhiChu;
                _context.SaveChanges();
            }
        }
    }
}
