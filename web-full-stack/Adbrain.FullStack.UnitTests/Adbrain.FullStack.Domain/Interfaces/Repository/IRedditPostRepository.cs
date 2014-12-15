using Adbrain.FullStack.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adbrain.FullStack.Domain.Interfaces.Repository
{
   public interface IRedditPostRepository
   {
      List<RedditPost> GetPostsByDomain(string domain);
   }
}
