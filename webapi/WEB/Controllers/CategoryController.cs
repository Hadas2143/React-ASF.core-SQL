using BL.interfaces;
using DAL.models;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        IcategoryBL C_bl;
        public CategoryController(IcategoryBL c_bl)
        {
            this.C_bl = c_bl;
        }
        [HttpGet("getCategory")]
        public List<CategoryDTO> GetCategories()
        {
            return C_bl.GetAllCategories();
        }
        [HttpDelete("deleteCategory/{id}")]
        public bool Delete(int id)
        {
            return C_bl.DeleteCategory(id);
        }
        [HttpPost("updateCategory/{id}")]
        public bool updateCategory(CategoryDTO category, int id)
        {
            return C_bl.UpdateCAtegory(category, id);
        }
        [HttpPut("add")]
        public bool AddCategory(CategoryDTO category)
        {
            return C_bl.AddCategory(category);
        }
        [HttpGet("getById/{id}")]
        public CategoryDTO GetCategory(int id)
        {
            return C_bl.GetCategoryById(id);  
        }
    }
}
