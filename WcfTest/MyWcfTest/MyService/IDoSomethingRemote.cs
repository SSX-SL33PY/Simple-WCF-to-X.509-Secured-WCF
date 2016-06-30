using System.ServiceModel;

namespace MyWcfTest.MyService
{
    [ServiceContract]
    public interface IDoSomethingRemote
    {
        [OperationContract]
        string GetMessage(string name);
    }
}
