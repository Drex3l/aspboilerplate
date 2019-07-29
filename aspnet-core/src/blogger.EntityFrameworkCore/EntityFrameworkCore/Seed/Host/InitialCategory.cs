using System.Linq;
using Microsoft.EntityFrameworkCore;
using blogger.Categories;

namespace blogger.EntityFrameworkCore.Seed.Host
{
    public class InitialCategory
    {
        private readonly bloggerDbContext _context;
        public InitialCategory(bloggerDbContext context)
        {
            _context = context;
        }
        public void Create(){
            CreateCategories();
        }

        private  void CreateCategories(){
            var categories = _context.Categories.FirstOrDefault(x => x.Title == "Lifestyle");
            if(categories == null){
                _context.Categories.Add(new Category{Title = "Lifestyle"});
                _context.Categories.Add(new Category{Title = "Technology"});
                _context.Categories.Add(new Category{Title = "Politics"});

                _context.SaveChanges();
            }
        }
    }
}