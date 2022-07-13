using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
  public interface IGenericRepo<T> where T: class
  {
    void Add(T item);
    void Update(T item);
    T Get(int id);
    List<T> GetAll();
    void Delete(int id);
  }
}
