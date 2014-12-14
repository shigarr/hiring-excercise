using Adbrain.FullStack.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adbrain.FullStack.Domain.Interfaces
{
   public interface IRedditDomainService
   {
      string JsonRaw { get; }

      List<RedditPost> GetRedditPosts();
   }
}
