using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concentrator.SharedObjects.Exceptions
{
  public class ValidationException : Exception
  {
    public ValidationException()
    {
      ValidationErrors = new Dictionary<string, string>();
    }

    public Dictionary<string,string> ValidationErrors { get; set; }

    public override string Message
    {
      get
      {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("");

        foreach (var validationError in ValidationErrors)
        {
          sb.AppendLine(String.Format("{0} : {1}", validationError.Key, validationError.Value));
        }
        
        return sb.ToString();
      }
    }
  }
}
