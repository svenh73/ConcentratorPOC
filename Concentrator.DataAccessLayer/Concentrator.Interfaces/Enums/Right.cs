using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concentrator.SharedObjects.Enums
{
  [Flags]
  public enum Rights
  {
    Read,
    Write,
    Delete,
    Manage
  }
}
