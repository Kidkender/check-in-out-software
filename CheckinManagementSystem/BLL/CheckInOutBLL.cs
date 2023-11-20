using CheckinManagementSystem.Control;
using CheckinManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace CheckinManagementSystem.BLL
{
    public class CheckInOutBLL
    {
        CheckInEntities _context = new CheckInEntities();

        public bool AddRecord(int? IdNhanSu, int? IdLoaiRecord, int? InOut = 0, int? IdRecord = null)
        {
            int result = 0;
            if (IdNhanSu != null || IdRecord != null)
            {
                Record record = _context.Record.FirstOrDefault(t => (t.IdNhanSu == IdNhanSu && t.IdLoaiRecord == IdLoaiRecord && t.ThoiGianRa == null /*&& EntityFunctions.TruncateTime(t.ThoiGianVao) == EntityFunctions.TruncateTime(DateTime.Now)*/) || t.ID == IdRecord);

                if (record != null)
                {
                    record.ThoiGianRa = DateTime.Now;
                    record.InOut = InOut;
                }
                else
                {
                    record = new Record()
                    {
                        IdLoaiRecord = IdLoaiRecord ?? 0,
                        IdNhanSu = IdNhanSu,
                        ThoiGianVao = DateTime.Now,
                        InOut = InOut
                    };
                    _context.Record.Add(record);
                }

                result = _context.SaveChanges();
            }
            return result > 0;
        }

        public bool checkIsOut(int? IdNhanSu)
        {
            return _context.Record.Any(t => t.IdLoaiRecord != 0 && t.IdNhanSu == IdNhanSu && t.ThoiGianRa == null && t.ThoiGianVao.HasValue);
        }
    }
}
