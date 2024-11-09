namespace Lab05
{
    public class WCFSimplex : IWCFSimplex
    {
        public int Add(int a, int b) => a + b;
        public string Concat(string a, string b) => a + b;
        public A Sum(A a, A b) => a + b;
    }
}
