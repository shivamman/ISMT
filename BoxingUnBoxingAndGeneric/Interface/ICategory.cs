using BoxingUnBoxingAndGeneric;

namespace BoxingUnBoxingAndGeneric
{
  public interface ICategory
  {
    void Add(Category cat);
    void Remove();
    void Update(Category cat);
    List<Category> GetAll();
  }
}
