using System;
using System.Collections.Generic;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.DataAccessServiceLayer
{
  public class ProcessStoreService : BaseStoreService , IProcessStoreService
  {
    public int[] GetIds()
    {
      throw new NotImplementedException();
    }

    public List<IProcess> GetItems(int[] ids)
    {
      throw new NotImplementedException();
    }

    public int Insert(IProcess item)
    {
      throw new NotImplementedException();
    }

    public bool Update(IProcess item)
    {
      throw new NotImplementedException();
    }

    public bool Delete(IProcess item)
    {
      throw new NotImplementedException();
    }
  }
}
