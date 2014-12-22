using Adbrain.FullStack.Domain.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adbrain.FullStack.Utilities;

namespace Adbrain.FullStack.Domain.Factory
{
   public sealed class RedditPostFactory
   {
      #region Factory public Methods
      public static RedditPost CreateRedditPosts(dynamic token)
      {
         RedditPost reddit = new RedditPost();
         var jsonObject = token["data"];
         reddit.ApprovedBy = jsonObject.approved_by;
         reddit.Author = jsonObject.author;
         reddit.AuthorFlairCssClass = jsonObject.author_flair_css_class;
         reddit.AuthorFlairText = jsonObject.author_flair_text;
         reddit.BannedBy = jsonObject.banned_by;
         reddit.Clicked = jsonObject.clicked == null ? false : jsonObject.clicked;
         reddit.Created = jsonObject.created == null ? null : Utilities.Utilities.ConverToDateTime((long)jsonObject.created);
         reddit.CreatedUtc = jsonObject.created_utc == null ? null : Utilities.Utilities.ConverToDateTime((long)jsonObject.created_utc);
         reddit.Distinguished = jsonObject.distinguished;
         reddit.Domain = jsonObject.domain;
         reddit.Downs = jsonObject.downs == null ? 0 : (int)jsonObject.downs;
         reddit.Edited = jsonObject.edited == null ? false : jsonObject.edited; ;
         reddit.Gilded = jsonObject.gilded == null ? 0 : (int)jsonObject.gilded;
         reddit.Hidden = jsonObject.hidden == null ? false : jsonObject.hidden;
         reddit.RedditId = jsonObject.id;
         reddit.IsSelf = jsonObject.is_self == null ? false : jsonObject.is_self;
         reddit.Likes = (jsonObject.likes == null ? 0 : (int)jsonObject.likes);
         reddit.LinkFlairCssClass = jsonObject.link_flair_css_class;
         reddit.LinkFlairText = jsonObject.link_flair_text;
         reddit.Media = GetMedia(jsonObject.media);
         reddit.MediaEmbed = GetMediaEmbed(jsonObject.media_embed);
         reddit.ModReports = GetModeReports(jsonObject.mod_reports);
         reddit.Name = jsonObject.name;
         reddit.NumComments = jsonObject.num_comments == null ? 0 : (int)jsonObject.num_comments;
         reddit.NumReports = jsonObject.num_reports;
         reddit.Over18 = jsonObject.over_18 == null ? false : jsonObject.over_18;
         reddit.PermaLink = jsonObject.permalink;
         reddit.ReportReasons = jsonObject.report_reasons;
         reddit.Saved = jsonObject.saved == null ? false : jsonObject.saved;
         reddit.Score = jsonObject.score == null ? 0 : (int)jsonObject.score;
         reddit.SecureMedia = GetMedia(jsonObject.secure_media);
         reddit.SecureMediaEmbed = GetMediaEmbed(jsonObject.secure_media_embed);
         reddit.SelfText = jsonObject.selftext;
         reddit.SelfTextHtml = jsonObject.selftext_html;
         reddit.Stickied = jsonObject.stickied == null ? false : jsonObject.stickied;
         reddit.SubReddit = jsonObject.subreddit;
         reddit.SubredditId = jsonObject.subreddit_id;
         reddit.Thumbnail = jsonObject.thumbnail;
         reddit.Title = jsonObject.title;
         reddit.Ups = jsonObject.ups == null ? 0 : (int)jsonObject.ups;
         reddit.Url = jsonObject.url;
         reddit.UserReports = GetUserReports(jsonObject.user_reports);
         reddit.Visited = jsonObject.visited == null ? false : jsonObject.visited;

         return reddit;
      }

      #endregion

      #region Factory private methods
      private static Media GetMedia(dynamic token)
      {
         if (token == null)
            return null;
         Media media = new Media();
         media.Type = token.type;
         media.OEmbed = GetOEmbed(token.oembed);
         return media;
      }

      static OEmbed GetOEmbed(dynamic token)
      {
         if (token == null)
            return null;
         OEmbed oembed = new OEmbed();
         oembed.AuthorName = token.author_name;
         oembed.AuthorUrl = token.author_url;
         oembed.Description = token.description;
         oembed.Height = token.height;
         oembed.Html = token.html;
         oembed.ProviderName = token.provider_name;
         oembed.ProviderUrl = token.provider_url;
         oembed.ThumbnailHeight = token.thumbnail_height;
         oembed.ThumbnailUrl = token.thumbnail_url;
         oembed.ThumbnailWidth = token.thumbnail_width;
         oembed.Title = token.title;
         oembed.Type = token.type;
         oembed.Version = token.version;
         oembed.Width = token.width;
         return oembed;
      }

      private static MediaEmbed GetMediaEmbed(dynamic token)
      {
         if (token == null || (token.content == null && token.height == null && token.scrolling == null && token.width == null))
            return null;
         MediaEmbed media = new MediaEmbed();
         media.Content = token.content;
         media.Height = token.height;
         media.Scrolling = token.scrolling;
         media.Width = token.width;

         return media;
      }

      static List<ModReport> GetModeReports(JToken token)
      {
         if (token == null)
            return null;
         List<ModReport> modReports = new List<ModReport>();
         Array modReportsArray = token.ToArray();
         foreach (var modReport in modReportsArray)
         {
            modReports.Add(new ModReport
            {
               Value = modReport.ToString()
            });
         }
         return modReports;
      }

      static List<UserReport> GetUserReports(JToken token)
      {
         if (token == null)
            return null;
         List<UserReport> userReports = new List<UserReport>();
         Array userReportsArray = token.ToArray();
         foreach (var userReport in userReportsArray)
         {
            userReports.Add(new UserReport
            {
               Value = userReport.ToString()
            });
         }
         return userReports;
      }
      #endregion
   }
}
