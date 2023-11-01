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
            return _context.LoaiRecord.ToList();
        }
    }
}
