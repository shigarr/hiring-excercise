using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adbrain.FullStack.Utilities
{
   public static class ExtensionMethods
   {
      public static DateTime ConvertToDateTime(this DateTime dt, int seconds)
      {
         DateTime dateTime = new DateTime(1970, 1, 1);
         return dateTime.AddSeconds(seconds);
      }
   }
}
