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
      /// <summary>
      /// Reddit webapi url
      /// </summary>
      public string Url { get; private set; }
      
      /// <summary>
      /// read and return the results of Reddit response utilizing Url
      /// </summary>
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
      /// <summary>
      /// Instantiate OnlineRedditDomainService that also intialise Reddit service URL
      /// </summary>
      /// <param name="domain">Url domain</param>
      /// <param name="category">category e.g. sports</param>
      /// <param name="count">number of records to fetch</param>
      public OnlineRedditDomainService(string domain, string category, int count)
      {
         Url = string.Format("{0}{1}.json?limit={2}", domain, category, count.ToString());
      }

      #endregion
      
      #region Public Methods
      /// <summary>
      /// parse the raw json string to RedditPost list and return
      /// </summary>
      /// <returns>a list of RedditPosts</returns>
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
