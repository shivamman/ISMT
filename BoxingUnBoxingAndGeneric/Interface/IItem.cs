using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnBoxingAndGeneric
{
  public interface IItem
  {
    void Add();
    void Remove();
    void Update();
    List<Item> GetAll();
  }
}
