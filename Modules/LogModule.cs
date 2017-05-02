using System;
using System.Web;
using System.Diagnostics;
using System.Threading.Tasks;

[assembly: PreApplicationStartMethod(typeof(Modules.LogModule), "Register")]

namespace Modules
{
    public class LogModule : IHttpModule
    {
        public void Dispose()
        {
            Debug.WriteLine("Dispose was logged!");
        }

        public void Init(HttpApplication context)
        {
            Debug.WriteLine("Init was logged!");
        }

        public static void Register()
        {
            Debug.WriteLine("PreApplicationStartMethod Register()");
        }
    }
}
