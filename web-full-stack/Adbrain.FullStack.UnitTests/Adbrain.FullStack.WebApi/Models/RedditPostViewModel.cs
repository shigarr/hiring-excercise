using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adbrain.FullStack.WebApi.Models
{
   public class RedditPostViewModel
   {
      public string author { get; set; }
      public IEnumerable<Item> items { get; set; }
   }

   public class Item
   {
      public int id { get; set; }
      public string createdDate { get; set; }
      public string title { get; set; }
      public string premalink { get; set; }
   }
}