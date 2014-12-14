using Adbrain.FullStack.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adbrain.FullStack.Domain.Interfaces
{
   public interface IOnlineRedditDomainService
   {
      string JsonRaw { get; }

      List<RedditPost> GetRedditPosts();
   }
}
