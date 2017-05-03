﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcRequestLifeCycle.Handlers
{
    public class SampleHandler : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<p>This wa generated by the sample handler.</p>");
        }
    }
}