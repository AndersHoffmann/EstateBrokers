namespace Gateways
{
    public interface ILogin
    {
        public bool TryLogin(string username, string password);

    }
}
