using DAL.interfaces;
using DAL.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.classes
{
    public class InformationDAL : IinformationDAL
    {
        Game_storeContext DB = new();
        public bool AddInformation(Information Information)
        {
            try
            {
                DB.Information.Add(Information);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteInformation(int id)
        {
            try
            {
                Information info = DB.Information.FirstOrDefault(x => x.IdNumOfShooping == id);
                DB.Remove(info);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Information> GetAllInformation()
        {
            return DB.Information.ToList(); 
        }

        public bool UpdateInformation(Information Information, int id)
        {
            try
            {
                Information info = DB.Information.FirstOrDefault(x => x.IdNumOfShooping == id);
                DB.Entry(info).CurrentValues.SetValues(Information);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
