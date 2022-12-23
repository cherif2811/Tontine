using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using suivibouteilles.Properties;

namespace suivibouteilles.Classes
{
    public class AppSetting
    {
        Configuration config;
        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
        public string getconnectionstring(string Key)
        {
            return config.ConnectionStrings.ConnectionStrings[Key].ConnectionString;
        }
        public void saveconnectionstring(string Key, string value)
        {
            config.ConnectionStrings.ConnectionStrings[Key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[Key].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
            suivibouteilles.Properties.Settings.Default.Reset();
        }
    }
}


