using CheckinManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckinManagementSystem.BLL
{
    public class LoaiRecordBLL
    {
        CheckInEntities _context = new CheckInEntities();

        public List<LoaiRecord> GetAllLoaiRecord()
        {
            _context = new CheckInEntities();
            return _context.LoaiRecord.ToList();
        }

        public List<LoaiRecord> GetAllLoaiRecord_Grid()
        {
            _context = new CheckInEntities();
            return _context.LoaiRecord.ToList();
        }

        public List<LoaiRecord> GetAllLoaiRecord_Grid(string text)
        {
            _context = new CheckInEntities();
            if (string.IsNullOrEmpty(text))
                return _context.LoaiRecord.ToList();
            return _context.LoaiRecord.Where(t => t.TenLoaiRecord.Trim().ToLower().Contains(text.ToLower().Trim())).ToList();
        }

        public LoaiRecord GetLoaiRecordById(int? Id)
        {
            _context = new CheckInEntities();
            return _context.LoaiRecord.FirstOrDefault(t => t.ID == Id);
        }

        public void DeleteLoaiRecordById(int? Id)
        {
            _context = new CheckInEntities();
            LoaiRecord p = _context.LoaiRecord.FirstOrDefault(t => t.ID == Id);
            _context.LoaiRecord.Remove(p);
            _context.SaveChanges();
        }

        public void AddEditLoaiRecord(LoaiRecord model)
        {
            _context = new CheckInEntities();
            int result = 0;
            LoaiRecord p = _context.LoaiRecord.FirstOrDefault(t => t.ID == model.ID);
            if (p == null)
            {
                p = new LoaiRecord()
                {
                    ID = 0,
                    TenLoaiRecord = model.TenLoaiRecord,
                    SoLan = model.SoLan,
                    ThoiGian = model.ThoiGian,
                    MoTa = model.MoTa
                };
                _context.LoaiRecord.Add(p);
            }
            else
            {
                p.ID = model.ID;
                p.MoTa = model.MoTa;
                p.ThoiGian = model.ThoiGian;
                p.SoLan = model.SoLan;
                p.TenLoaiRecord = model.TenLoaiRecord;
            }

            result = _context.SaveChanges();
        }
    }
}
