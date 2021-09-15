using System;
using FacebookWrapper;

namespace Logic
{
    public class LoginWithTokenStrategy : ILoginStrategy
    {
        private static readonly object loginLock = new object();

        public LoginResult TryLogin()
        {
            lock (loginLock)
            {
                if (Properties.Settings.Default.RememberMe &&
                    !string.IsNullOrEmpty(Properties.Settings.Default.Token))
                {
                    try
                    {
                        return FacebookService.Connect(Properties.Settings.Default.Token);
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }

                return null;
            }
        }
    }
}