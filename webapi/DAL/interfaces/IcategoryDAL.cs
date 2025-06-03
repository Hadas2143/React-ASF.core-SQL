using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IcategoryDAL
    {
        //get
        public List<CategoryTbl> GetAllCategories();
        //delete
        public bool DeleteCategory(int id);
        //upt
        public bool UpdateCAtegory(CategoryTbl categoryTbl,int id);
        // add
        public bool AddCategory(CategoryTbl categoryTbl);
        ////getById
        //public string GetCategoryById(int id);
    }
}
