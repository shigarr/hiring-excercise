using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBehave.Spec.NUnit;
using Adbrain.FullStack.Domain.Interfaces;
using Adbrain.FullStack.Domain.DomainService;
using Adbrain.FullStack.Repository.Repository;

namespace Adbrain.FullStack.UnitTests.Domain
{
   public class when_working_with_reddit_domain_service : Specification
   {
      
   }

   public class and_get_posts_by_domain : when_working_with_reddit_domain_service
   {
      IRedditDomainService redditDomainService;
      protected override void Establish_context()
      {
         base.Establish_context();
      }

      protected override void Because_of()
      {
         redditDomainService = new RedditDomainService(new RedditPostRepository());
      }

      [Test]
      [ExpectedException(typeof(ArgumentException))]
      public void invalid_domain()
      {
         var posts = redditDomainService.GetPostsByDomain("");
      }

      [Test]
      public void get_posts() 
      {
         var posts = redditDomainService.GetPostsByDomain("youtube.com");
         posts.Count().ShouldBeGreaterThan(0);
      }
   }
}
