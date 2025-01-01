using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.models;

namespace BUS
{
    public class Class_GET
    {
        public List<LopHoc> GetAll()
        {
            Model1 context = new Model1();

            return context.LopHocs.ToList();

        }
    }
}

