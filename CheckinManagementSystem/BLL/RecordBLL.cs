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

        public List<SP_GetAllDangKy_Result> GetAllDangKy(bool status = false, int? idxSL = 4, int? idNhanSu = null, int? idLoaiRecord = null, int? idPhong = null, int? idPhongMacDinh = null, bool? isThoiGianRa = null, DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            _context = new CheckInEntities();
            return _context.SP_GetAllDangKy(status, idxSL, idNhanSu, idLoaiRecord, idPhong, idPhongMacDinh, isThoiGianRa, tuNgay, denNgay).OrderByDescending(t => t.ThoiGianVao).ToList();
        }

        public List<SP_GetAllDiemDanh_Result> GetAllDiemDanh(int? idxSL = 4, int? idNhanSu = null, int? idPhong = null, int? idPhongMacDinh = null, bool? isThoiGianRa = null)
        {
            _context = new CheckInEntities();
            return _context.SP_GetAllDiemDanh(idxSL, idNhanSu, idPhong, idPhongMacDinh, isThoiGianRa).OrderByDescending(t => t.ThoiGianVao).ToList();
        }

        public bool checkNhanSuGanNhat(int IdNhanSu)
        {
            var result = false;
            _context = new CheckInEntities();
            var re = _context.Record.Where(t => t.IdNhanSu == IdNhanSu && t.IdLoaiRecord == 0).ToList().LastOrDefault();

            if (re != null && re.ThoiGianRa.HasValue)
            {
                TimeSpan timeDifference = DateTime.Now - re.ThoiGianRa.Value;
                return timeDifference.TotalHours < 5;
            }

            return result;
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

        public int DeleteRecordDiemDanh(int ID)
        {
            _context = new CheckInEntities();
            var result = 0;
            try
            {
                var re = _context.Record.FirstOrDefault(t => t.ID == ID);
                _context.Record.Remove(re);
                result = _context.SaveChanges();
            }
            catch (Exception) { }
            return result;
        }
    }
}
