using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace layoutissue
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["Index"];
        }
    }
}