using DependancyInjectionMVC5.Models;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace DependancyInjectionMVC5
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            //container.RegisterSingleton<IEmployeeRepository, MockEmployeeRepository>();
            container.RegisterType<IEmployeeRepository, MockEmployeeRepository>();
            //container.RegisterInstance<IEmployeeRepository>(new MockEmployeeRepository());
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}