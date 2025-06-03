using AutoMapper;
using BL.interfaces;
using DAL.interfaces;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.classes
{
    public class categoryBL : IcategoryBL
    {
        IcategoryDAL C_DAl;
        IMapper mapper;
        
        public categoryBL(IcategoryDAL c_dal)
        {
            this.C_DAl = c_dal;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<myProfile>();
            });
            mapper = config.CreateMapper();

        }
        public bool AddCategory(CategoryDTO category)
        {
            CategoryTbl c=mapper.Map<CategoryDTO,CategoryTbl>(category);
            return C_DAl.AddCategory(c);
        }

        public bool DeleteCategory(int id)
        {
            return C_DAl.DeleteCategory(id);
        }

        public List<CategoryDTO> GetAllCategories()
        {
            return mapper.Map<List<CategoryTbl>, List<CategoryDTO>>(C_DAl.GetAllCategories());
        }
        public CategoryDTO GetCategoryById(int id)
        {
            List<CategoryDTO> l = GetAllCategories();
            return l.FirstOrDefault(x => x.Idcategory == id);
        }
    

        public bool UpdateCAtegory(CategoryDTO category, int id)
        {
            CategoryTbl c=mapper.Map<CategoryDTO,CategoryTbl>(category);
            return C_DAl.UpdateCAtegory(c, id);
        }
    }
}
