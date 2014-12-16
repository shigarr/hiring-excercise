using Adbrain.FullStack.Domain.Interfaces;
using Adbrain.FullStack.WebApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Adbrain.FullStack.WebApi.Controllers
{
   public class SportsController : ApiController
   {
      private IRedditDomainService _redditDomainService;

      public SportsController(IRedditDomainService redditDomainService)
      {
         this._redditDomainService = redditDomainService;
      }
      

      // GET api/values/5
      public string Get(string domain)
      {
         var posts = _redditDomainService.GetPostsByDomain(domain);
         var jPosts = from p in posts 
                        group p by p.Author
                        into g
                        select new RedditPostViewModel {
                           author = g.Key,
                           items = g.Select(p => new Item{
                              createdDate = p.CreatedUtc,
                              id = p.Id,
                              premalink = p.PermaLink,
                              title = p.Title
                           })
                        };
         return JsonConvert.SerializeObject(jPosts);
      }
      
   }
}
