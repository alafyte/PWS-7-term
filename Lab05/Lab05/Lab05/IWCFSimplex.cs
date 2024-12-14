using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace Lab05
{
    [ServiceContract]
    public interface IWCFSimplex
    {
        [OperationContract]
        int Add(int a, int b);

        [OperationContract]
        string Concat(string a, string b);

        [OperationContract]
        A Sum(A a, A b);
    }

   
}
