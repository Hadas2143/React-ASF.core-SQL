using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.interfaces
{
    public interface IcategoryBL
    {
        //get
        public List<CategoryDTO> GetAllCategories();
        //delete
        public bool DeleteCategory(int id);
        //upt
        public bool UpdateCAtegory(CategoryDTO category, int id);
        // add
        public bool AddCategory(CategoryDTO category);
        //getById
        public CategoryDTO GetCategoryById(int id);
    }
}
