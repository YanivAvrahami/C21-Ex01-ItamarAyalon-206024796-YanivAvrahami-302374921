using FacebookWrapper;

namespace Logic
{
    public interface ILoginStrategy
    {
        LoginResult TryLogin();
    }
}