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
      /// <summary>
      /// Gets RedditPost from database filtered by domain name
      /// </summary>
      /// <param name="domain">domain name e.g. youtube.com</param>
      /// <returns>List of RedditPost</returns>
      List<RedditPost> GetPostsByDomain(string domain);
   }
}
