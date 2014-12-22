using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adbrain.FullStack.Utilities
{
   public class Utilities
   {
      public static bool IsNull(object obj)
      {
         throw new NotImplementedException();
      }

      public static DateTime? ConverToDateTime(long time)
      {
         return new DateTime?(new DateTime(1970, 1, 1).AddSeconds(time));
      }
   }
}
