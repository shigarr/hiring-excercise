using Adbrain.FullStack.Domain.Entities;
using Adbrain.FullStack.Domain.Factory;
using Adbrain.FullStack.Domain.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Adbrain.FullStack.Domain.DomainService
{
   public class OnlineRedditDomainService : IOnlineRedditDomainService
   {
      #region Member Variables
      private string _jsonRaw;
      #endregion

      #region Properties
      public string Url { get; private set; }
      public string JsonRaw 
      {
         get
         {
            if (string.IsNullOrEmpty(_jsonRaw)) 
            { 
               using (WebClient client = new WebClient())
               {
                  _jsonRaw = client.DownloadString(Url);
               }
            }
            return _jsonRaw;
         }
      }
      #endregion

      #region Constructors
      public OnlineRedditDomainService(string url, string category, int count)
      {
         Url = string.Format("{0}{1}.json?limit={2}", url, category, count.ToString());
      }

      #endregion
      
      #region Public Methods
      public List<RedditPost> GetRedditPosts()
      {
         dynamic jsonObject = JsonConvert.DeserializeObject(JsonRaw);
         List<JToken> children = ((JArray)jsonObject.data.children).ToList();
         List<RedditPost> redditPosts = new List<RedditPost>();
         children.ForEach(c => redditPosts.Add(RedditPostFactory.CreateRedditPosts(c)));

         return redditPosts;
      }
      #endregion

   }
}
