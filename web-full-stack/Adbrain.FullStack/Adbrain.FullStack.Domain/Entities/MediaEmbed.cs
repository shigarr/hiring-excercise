using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adbrain.FullStack.Domain.Entities
{
   public class MediaEmbed : BaseEntity
   {
      public string Content { get; set; }
      public string Width { get; set; }
      public string Scrolling { get; set; }
      public string Height { get; set; }
   }
}
