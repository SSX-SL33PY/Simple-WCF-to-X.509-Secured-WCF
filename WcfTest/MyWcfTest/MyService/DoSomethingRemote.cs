namespace MyWcfTest.MyService
{
    public class DoSomethingRemote : IDoSomethingRemote
    {
        public string GetMessage(string name)
        {
            return "I did something remote for " + name;
        }
    }
}