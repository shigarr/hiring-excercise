using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adbrain.FullStack.Repository.Repository
{
   public class BaseRepository
   {
      private RedditContext _context;
      protected RedditContext Context 
      {
         get
         {
            if (_context == null)
            {
               _context = new RedditContext();
            }
            return _context;
         }
      }
   }
}
