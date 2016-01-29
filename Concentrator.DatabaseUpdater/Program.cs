
using System.Linq;
using Concentrator.DataLayer;

namespace DatabaseUpdater
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var context = new ConcentratorDataContext())
      {
        var configs = context.Configs.ToList();
      }

    }
  }
}
