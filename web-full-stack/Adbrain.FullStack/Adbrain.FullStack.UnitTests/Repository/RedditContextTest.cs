using Adbrain.FullStack.Repository;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBehave.Spec.NUnit;

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

      [Test]
      public void then_database_should_contain_reddit_posts()
      {
         var posts = context.RedditPosts.Count();
         posts.ShouldBeGreaterThan(0);
      }
   }
}
