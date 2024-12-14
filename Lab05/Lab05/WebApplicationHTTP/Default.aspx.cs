using System;
using System.Web.UI;
using WebApplicationHTTP.ServiceReference1;

namespace WebApplicationHTTP
{
    public partial class _Default : Page
    {
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            int addVal1 = int.Parse(inputAdd1.Text);
            int addVal2 = int.Parse(inputAdd2.Text);
            string concatStr1 = inputConcat1.Text;
            string concatVal2 = inputConcat2.Text;

            A a = new A
            {
                f = float.Parse(inputA_f.Text),
                k = int.Parse(inputA_k.Text),
                s = inputA_s.Text
            };

            A b = new A
            {
                f = float.Parse(inputB_f.Text),
                k = int.Parse(inputB_k.Text),
                s = inputB_s.Text
            };

            using (WCFSimplexClient client = new WCFSimplexClient("http"))
            {
                addResult.Text = client.Add(addVal1, addVal2).ToString();

                concatResult.Text = client.Concat(concatStr1, concatVal2);

                A resultA = client.Sum(a, b);
                sumResultF.Text = resultA.f.ToString();
                sumResultK.Text = resultA.k.ToString();
                sumResultS.Text = resultA.s;
            }
        }
    }
}
