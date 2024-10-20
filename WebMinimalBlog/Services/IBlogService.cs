
using WebMinimalBlog.Model;

namespace WebMinimalBlog.Services
{
    public interface IBlogService
    {
        IEnumerable<Blog> GetAll();
        Blog GetById(int id);
        Blog Create(Blog blog);
        void Update(int id, Blog blog);
        void Delete(int id);
    }
}
