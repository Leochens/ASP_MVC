using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web3
{
    /// <summary>
    /// test 的摘要说明
    /// </summary>
    public class test : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string action = context.Request["name"];
            int age = Convert.ToInt32(context.Request["age"]);
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World "+action+"your age is "+age);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}