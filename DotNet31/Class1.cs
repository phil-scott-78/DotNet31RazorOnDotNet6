using System;
using Microsoft.Extensions.DependencyInjection;

namespace DotNet31
{
    public class Class1
    {
        public static void DoIt(ServiceCollection services)
        {
            services
                .AddRazorPages()
                .AddRazorRuntimeCompilation();
        }
    }
}