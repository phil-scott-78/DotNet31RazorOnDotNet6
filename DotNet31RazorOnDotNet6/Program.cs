using System;
using DotNet31;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace DotNet31RazorOnDotNet6
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            Class1.DoIt(services);
            Console.WriteLine(services.First(f => f.ServiceType == typeof(IViewCompilerProvider)).ImplementationType?.FullName);
        }
    }
}