using System;
using System.Configuration;

namespace BitcoinClient.Tests
{
    public static class ConfigUtility
    {
        public static ConnectionInfo GetConnectionInfo()
        {
            return new ConnectionInfo
            {
                Url = GetRequiredAppSetting("RpcUrl"),
                Username = GetRequiredAppSetting("RpcUsername"),
                Password = GetRequiredAppSetting("RpcPassword")
            };
        }

        public static string GetRequiredAppSetting(string key)
        {
            string result = ConfigurationManager.AppSettings[key];

            if (string.IsNullOrEmpty(result))
                throw new Exception($"Missing required AppSetting: {key}");

            return result;
        }
    }
}