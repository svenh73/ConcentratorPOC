
using System.Linq;
using Concentrator.DataLayer;
using Concentrator.Entities;

namespace DatabaseUpdater
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var context = new CNxtContext())
      {
        var configs = context.Settings.ToList();
      }

    }
  }
}
