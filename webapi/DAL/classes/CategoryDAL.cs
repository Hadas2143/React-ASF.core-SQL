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
    public class CategoryDAL : IcategoryDAL
    {
        Game_storeContext DB = new();
        public bool AddCategory(CategoryTbl category)
        {
            try
            {
                DB.CategoryTbls.Add(category);
                DB.SaveChanges();
                return true;
            }
            catch 
            { 
                return false; 
            }
        }

        public bool DeleteCategory(int id)
        {
            try
            {
                CategoryTbl Ct=DB.CategoryTbls.FirstOrDefault(x=>x.Idcategory==id);
                DB.CategoryTbls.Remove(Ct);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<CategoryTbl> GetAllCategories()
        {
            return DB.CategoryTbls.Include(j=>j.Games).ToList();
        }

        //public string GetCategoryById(int id)
        //{
        //    CategoryTbl c = DB.CategoryTbls.FirstOrDefault(x => x.Idcategory == id);
        //    return c.NameCategory;
        //}

        public bool UpdateCAtegory(CategoryTbl categoryTbl, int id)
        {
            try
            {
                CategoryTbl Ct = DB.CategoryTbls.FirstOrDefault(x => x.Idcategory == id);
                DB.Entry(Ct).CurrentValues.SetValues(categoryTbl);
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
