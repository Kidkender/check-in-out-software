﻿using CheckinManagementSystem.DAL;
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
    }
}
