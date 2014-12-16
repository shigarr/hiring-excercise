﻿using Adbrain.FullStack.Domain.Entities;
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
      public RedditDomainService(IRedditPostRepository redditPostRepository)
      {
         this._redditPostRepository = redditPostRepository;
      }
      #endregion

      #region Public Methods
      public List<RedditPost> GetPostsByDomain(string domain)
      {
         if(string.IsNullOrEmpty(domain))
            throw new ArgumentException("invalid domain");

         return _redditPostRepository.GetPostsByDomain(domain);
      }

      #endregion
   }
}
