using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnBoxingAndGeneric
{
  public interface IGenericrRepository<T> where T : class
  {
    void Add(T data);
    void Remove();
    void Update(T data);
    List<T> GetAll();
  }
}
