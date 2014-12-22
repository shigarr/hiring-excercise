using Adbrain.FullStack.Domain.Entities;
using Adbrain.FullStack.Domain.Interfaces;
using Adbrain.FullStack.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adbrain.FullStack.Domain.DomainService
{
   public class RedditDomainService : IRedditDomainService
   {
      #region Member Variables
      IRedditPostRepository _redditPostRepository;
      #endregion

      #region Constructors
      /// <summary>
      /// Intantiate RedditDomainService with reddit post repository
      /// </summary>
      /// <param name="redditPostRepository">reddit post repository</param>
      public RedditDomainService(IRedditPostRepository redditPostRepository)
      {
         this._redditPostRepository = redditPostRepository;
      }
      #endregion

      #region Public Methods
      /// <summary>
      /// Get RedditPosts by domain
      /// </summary>
      /// <param name="domain">domain name e.g. youtube.com</param>
      /// <returns></returns>
      public List<RedditPost> GetPostsByDomain(string domain)
      {
         if(string.IsNullOrEmpty(domain))
            throw new ArgumentException("invalid domain");

         return _redditPostRepository.GetPostsByDomain(domain);
      }

      #endregion
   }
}
