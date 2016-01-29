using System;
using System.Collections.Generic;
using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.DataAccessServiceLayer
{
  public class ProcessStoreService : BaseStoreService<ProcessDto> , IProcessStoreService
  {
    public int[] GetIds()
    {
      throw new NotImplementedException();
    }

    public List<ProcessDto> GetItems(int[] ids)
    {
      throw new NotImplementedException();
    }

    public int Insert(ProcessDto item)
    {
      throw new NotImplementedException();
    }

    public bool Update(ProcessDto item)
    {
      throw new NotImplementedException();
    }

    public bool Delete(ProcessDto item)
    {
      throw new NotImplementedException();
    }
  }
}
