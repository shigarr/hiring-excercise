using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adbrain.FullStack.Domain.Entities
{
   public class RedditPost : BaseEntity
   {
      public string Domain { get; set; }
      public string BannedBy { get; set; }
      public string SubReddit { get; set; }
      public string SelfTextHtml { get; set; }
      public string SelfText { get; set; }
      public int Likes { get; set; }
      public string LinkFlairText { get; set; }
      public string RedditId { get; set; }
      public int Gilded { get; set; }
      public bool Clicked { get; set; }
      public string ReportReasons { get; set; }
      public string Author { get; set; }
      public int Score { get; set; }
      public string ApprovedBy { get; set; }
      public bool Over18 { get; set; }
      public bool Hidden { get; set; }
      public string Thumbnail { get; set; }
      public string SubredditId { get; set; }
      public bool Edited { get; set; }
      public string LinkFlairCssClass { get; set; }
      public string AuthorFlairCssClass { get; set; }
      public int Downs { get; set; }
      public bool Saved { get; set; }
      public bool IsSelf { get; set; }
      public string Name { get; set; }
      public string PermaLink { get; set; }
      public bool Stickied { get; set; }
      public DateTime? Created { get; set; }
      public string Url { get; set; }
      public string AuthorFlairText { get; set; }
      public string Title { get; set; }
      public DateTime? CreatedUtc { get; set; }
      public int Ups { get; set; }
      public int NumComments { get; set; }
      public bool Visited { get; set; }
      public string NumReports { get; set; }
      public string Distinguished { get; set; }

      public MediaEmbed MediaEmbed { get; set; }
      public List<UserReport> UserReports { get; set; }
      public Media SecureMedia { get; set; }
      public MediaEmbed SecureMediaEmbed { get; set; }
      public Media Media { get; set; }
      public List<ModReport> ModReports { get; set; }
   }
}
