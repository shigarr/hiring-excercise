using Adbrain.FullStack.Domain.DomainService;
using Adbrain.FullStack.Domain.Entities;
using Adbrain.FullStack.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adbrain.FullStack.Repository
{
   public class RedditContextInializer : DropCreateDatabaseIfModelChanges<RedditContext>
   {
      /// <summary>
      /// 
      /// </summary>
      /// <param name="context"></param>
      protected override void Seed(RedditContext context)
      {
         context.Configuration.AutoDetectChangesEnabled = false;
         AddRedditPostsToDb(context);
         context.Configuration.AutoDetectChangesEnabled = true;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="context"></param>
      private void AddRedditPostsToDb(RedditContext context)
      {
         string url = ConfigurationManager.AppSettings["Url"];
         string category = ConfigurationManager.AppSettings["Category"];
         int count = Int32.Parse(ConfigurationManager.AppSettings["Count"]);
         
         IOnlineRedditDomainService redditDomainService = new OnlineRedditDomainService(url, category, count);
         List<RedditPost> redditPosts = redditDomainService.GetRedditPosts();
         context.RedditPosts.AddRange(redditPosts);
         
         context.SaveChanges();
      }
   }
}
