using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;

namespace Lab01
{
    public class IISHandler1 : IHttpHandler, IRequiresSessionState
    {
        private int _result;

        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest req = context.Request;
            HttpResponse res = context.Response;
            HttpSessionState session = HttpContext.Current.Session;
            Stack<int> stack = session["Stack"] as Stack<int>;


            stack = session["Stack"] as Stack<int> ?? new Stack<int>();
            session["Stack"] = stack;


            switch (req.HttpMethod)
            {
                case "GET":
                    var result = (stack.Count > 0) ? (_result + stack.Peek()) : _result;
                    res.ContentType = "application/json";
                    res.Write("{\"result\": " + result + "}");
                    break;

                case "POST":
                    if (!int.TryParse(req.QueryString["result"], out int resultParameter))
                    {   
                        res.StatusCode = 400;
                        res.Write("Invalid parameter format");
                        break;
                    }
                    _result = resultParameter;
                    break;

                case "PUT":
                    if (!int.TryParse(req.QueryString["add"], out int addParameter))
                    {
                        res.StatusCode = 400;
                        res.Write("Invalid parameter format");
                        break;
                    }
                    stack.Push(addParameter);
                    break;

                case "DELETE":
                    if (stack.Count <= 0)
                    {
                        res.StatusCode = 400;
                        res.Write("Stack is empty");
                        break;
                    }
                    stack.Pop();
                    break;

                default:
                    res.StatusCode = 405;
                    res.Write("Method is not allowed.");
                    break;
            }
        }
    }
}
