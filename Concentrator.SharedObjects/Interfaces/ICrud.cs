using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concentrator.SharedObjects.Dtos;

namespace Concentrator.SharedObjects.Interfaces
{
  public interface ICrud<T> where T : BaseDto
  {
    int[] GetIds();

    List<T> GetItems(int[] ids);

    int Insert(T item);

    bool Update(T item);

    bool Delete(T item);

  }
}
