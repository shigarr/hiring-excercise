using Adbrain.FullStack.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adbrain.FullStack.Repository.Repository
{
   public class RedditPostRepository : IRedditPostRepository
   {
      public List<Domain.Entities.RedditPost> GetPostsByDomain(string domain)
      {
         throw new NotImplementedException();
      }
   }
}
