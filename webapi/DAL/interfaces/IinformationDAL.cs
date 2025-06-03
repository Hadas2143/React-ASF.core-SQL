using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IinformationDAL
    {
        //get
        public List<Information> GetAllInformation();
        //delete
        public bool DeleteInformation(int id);
        //upt
        public bool UpdateInformation(Information Information, int id);
        // add
        public bool AddInformation(Information Information);
    }
}
