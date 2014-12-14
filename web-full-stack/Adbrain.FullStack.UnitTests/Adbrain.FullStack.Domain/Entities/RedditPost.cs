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
      public string Likes { get; set; }
      public string LinkFlairText { get; set; }
      public string RedditId { get; set; }
      public string Gilded { get; set; }
      public string Clicked { get; set; }
      public string ReportReasons { get; set; }
      public string Author { get; set; }
      public string Score { get; set; }
      public string ApprovedBy { get; set; }
      public string Over18 { get; set; }
      public string Hidden { get; set; }
      public string Thumbnail { get; set; }
      public string SubredditId { get; set; }
      public string Edited { get; set; }
      public string LinkFlairCssClass { get; set; }
      public string AuthorFlairCssClass { get; set; }
      public string Downs { get; set; }
      public string Saved { get; set; }
      public string IsSelf { get; set; }
      public string Name { get; set; }
      public string PermaLink { get; set; }
      public string Stickied { get; set; }
      public string Created { get; set; }
      public string Url { get; set; }
      public string AuthorFlairText { get; set; }
      public string Title { get; set; }
      public string CreatedUtc { get; set; }
      public string Ups { get; set; }
      public string NumComments { get; set; }
      public string Visited { get; set; }
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
