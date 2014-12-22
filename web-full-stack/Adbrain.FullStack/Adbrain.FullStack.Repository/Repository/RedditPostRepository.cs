using Adbrain.FullStack.Domain.Entities;
using Adbrain.FullStack.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adbrain.FullStack.Repository.Repository
{
   public class RedditPostRepository : BaseRepository, IRedditPostRepository
   {
      /// <summary>
      /// Gets RedditPost from database filtered by domain name
      /// </summary>
      /// <param name="domain">domain name e.g. youtube.com</param>
      /// <returns>List of RedditPost</returns>
      public List<RedditPost> GetPostsByDomain(string domain)
      {
         var posts = Context.RedditPosts.Where(p => p.Domain.ToLower().Equals(domain.ToLower())).ToList();
         return posts;
      }
   }
}
