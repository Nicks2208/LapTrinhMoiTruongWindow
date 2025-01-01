using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.models;

namespace BUS
{
    public class HV_GET
    {
        public List<HocVien> GetAll()
        {

            Model1 context = new Model1();

            return context.HocViens.ToList();

        }
    }
}
