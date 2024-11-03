using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace Lab04
{
    /// <summary>
    /// Summary description Simplex
    /// </summary>
    [WebService(Namespace = "http://rna/", Description ="Lab04 Simplex Service")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class Simplex : System.Web.Services.WebService
    {
        [WebMethod(MessageName = "Add", Description = "Returns the sum of two numbers")]
        public int Add(int a, int b) => a + b;

        [WebMethod(MessageName = "Concat", Description = "Returns the concatenation of two strings")]
        public string Concat(string a, string b) => a + b;

        [WebMethod(MessageName = "Sum", Description = "Returns the sum of two objects A")]
        public A Sum(A a, A b)
        {
            System.IO.Stream requestStream = HttpContext.Current.Request.InputStream;
            requestStream.Position = 0;
            using (System.IO.StreamReader reader = new System.IO.StreamReader(requestStream))
            {
                string requestBody = reader.ReadToEnd();
                System.Diagnostics.Debug.WriteLine(requestBody);
            }
            return new A(a.s + b.s, a.k + b.k, a.f + b.f);
        }

        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        [WebMethod(MessageName = "AddS", Description = "Returns the sum of two numbers (JSON)")]
        public int AddS(int a, int b) => a + b;

    }

    public class A
    {
        public string s;
        public int k;
        public float f;

        public A()
        {
        }

        public A(string v1, int v2, float v3)
        {
            s = v1;
            k = v2;
            f = v3;
        }
    }
}
