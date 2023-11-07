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
            return _context.LoaiRecord.ToList();
        }

        public List<LoaiRecord> GetAllLoaiRecord_Grid()
        {
            return _context.LoaiRecord.ToList();
        }

        public LoaiRecord GetLoaiRecordById(int? Id)
        {
            return _context.LoaiRecord.FirstOrDefault(t => t.ID == Id);
        }

        public void DeleteLoaiRecordById(int? Id)
        {
            LoaiRecord p = _context.LoaiRecord.FirstOrDefault(t => t.ID == Id);
            _context.LoaiRecord.Remove(p);
            _context.SaveChanges();
        }

        public int AddEditLoaiRecord(LoaiRecord model)
        {
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
                p.MoTa = model.MoTa;
                p.ThoiGian = model.ThoiGian;
                p.SoLan = model.SoLan;
                p.TenLoaiRecord = model.TenLoaiRecord;

                _context.LoaiRecord.AddOrUpdate(p);
            }

            result = _context.SaveChanges();
            return result;
        }
    }
}
