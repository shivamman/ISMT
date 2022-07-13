namespace BoxingUnBoxingAndGeneric
{
  public class GenericRepository<T> : IGenericrRepository<T> where T : class
  {
    public void Add(T data)
    {
      throw new NotImplementedException();
    }

    public List<T> GetAll()
    {
      throw new NotImplementedException();
    }

    public void Remove()
    {
      throw new NotImplementedException();
    }

    public void Update(T data)
    {
      throw new NotImplementedException();
    }
  }
}
