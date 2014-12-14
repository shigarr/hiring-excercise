using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBehave.Spec.NUnit;

namespace Adbrain.FullStack.UnitTests.Domain
{
   public class when_working_with_reddit_json_service : Specification
   {
   }

   public class and_parsing_json_data : when_working_with_reddit_json_service
   {
      private IRedditDomainService redditDomainService;

      protected override void Establish_context()
      {
         base.Establish_context();
      }

      protected override void Because_of()
      {
         string url = "http://www.reddit.com/r/";
         string category = "sports";
         int count = 100;
         redditDomainService = new RedditDomainService(url, category, count);
      }

      [Test]
      public void then_get_json_raw_string()
      {
         string json = redditDomainService.GetJsonRawString();
         json.ShouldNotBeEmpty();
      }

   }
}
