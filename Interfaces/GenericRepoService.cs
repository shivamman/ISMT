using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
  public class GenericRepoService<T> : IGenericRepo<T> where T: class
  {
    public void Add(T item)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public T Get(int id)
    {
      throw new NotImplementedException();
    }

    public List<T> GetAll()
    {
      throw new NotImplementedException();
    }

    public void Update(T item)
    {
      throw new NotImplementedException();
    }
  }
}
