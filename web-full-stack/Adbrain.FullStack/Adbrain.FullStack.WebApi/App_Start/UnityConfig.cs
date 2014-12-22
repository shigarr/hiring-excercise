using Adbrain.FullStack.Domain.DomainService;
using Adbrain.FullStack.Domain.Interfaces;
using Adbrain.FullStack.Domain.Interfaces.Repository;
using Adbrain.FullStack.Repository.Repository;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace Adbrain.FullStack.WebApi
{
   public static class UnityConfig
   {
      public static void RegisterComponents()
      {
         var container = new UnityContainer();

         // register all your components with the container here
         // it is NOT necessary to register your controllers

         // e.g. container.RegisterType<ITestService, TestService>();
         container.RegisterType<IRedditDomainService, RedditDomainService>();
         container.RegisterType<IRedditPostRepository, RedditPostRepository>();

         GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
      }
   }
}