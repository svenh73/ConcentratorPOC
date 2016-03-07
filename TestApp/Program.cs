using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concentrator.Entities;

namespace TestApp
{
  class Program
  {
    static void Main(string[] args)
    {
      
      
      CNextContext context = new CNextContext();
      var x = context.Settings.Find();
    }
  }
}
