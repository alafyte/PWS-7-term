using System.ServiceModel;

namespace Lab06
{
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        void DoWork();
    }
}
