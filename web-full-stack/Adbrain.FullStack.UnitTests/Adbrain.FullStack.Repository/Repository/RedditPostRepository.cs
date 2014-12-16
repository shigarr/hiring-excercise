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
      public List<RedditPost> GetPostsByDomain(string domain)
      {
         var posts = Context.RedditPosts.Where(p => p.Domain.ToLower().Equals(domain.ToLower())).ToList();
         return posts;
      }
   }
}
