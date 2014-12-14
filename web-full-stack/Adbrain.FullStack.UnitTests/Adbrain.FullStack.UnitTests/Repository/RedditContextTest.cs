using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adbrain.FullStack.UnitTests.Repository
{
   public class when_working_with_reddit_context : Specification
   {
   }

   public class and_initializing_context : when_working_with_reddit_context
   {
      private RedditContext context;

      protected override void Establish_context()
      {
         base.Establish_context();
      }

      protected override void Because_of()
      {
         context = new RedditContext();
      }


   }
}
