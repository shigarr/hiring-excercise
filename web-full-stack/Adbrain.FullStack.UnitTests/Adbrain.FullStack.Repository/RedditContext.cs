using Adbrain.FullStack.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adbrain.FullStack.Repository
{
   public class RedditContext : DbContext
   {
      public RedditContext() 
         : base("RedditContext")
      {
         AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
      }

      /// <summary>
      /// Constructor to use on a DbConnection that is already opened
      /// </summary>
      /// <param name="existingConnection"></param>
      /// <param name="contextOwnsConnection"></param>
      public RedditContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
      {

      }


      public DbSet<RedditPost> RedditPosts { get; set; }
      public DbSet<Media> Media { get; set; }
      public DbSet<MediaEmbed> MediaEmbed { get; set; }
      public DbSet<ModReport> ModReports { get; set; }
      public DbSet<OEmbed> OEmbed { get; set; }
      public DbSet<UserReport> UserReports { get; set; }

      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
         modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
         modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
      }
   }
}
