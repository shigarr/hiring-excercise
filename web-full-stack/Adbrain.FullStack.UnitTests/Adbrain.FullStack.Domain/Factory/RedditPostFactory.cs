using Adbrain.FullStack.Domain.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adbrain.FullStack.Domain.Factory
{
   public sealed class RedditPostFactory
   {
      public static RedditPost CreateRedditPosts(JToken token)
      {
         RedditPost redditPost = new RedditPost();

         return redditPost;
      }
   }
}
