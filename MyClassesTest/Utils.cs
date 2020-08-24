using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace MyClassesTest
{
    public class Utils
    {
        public static string SetGoodFileName()
        {
            //adicionar um json como settings.....
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var _GoodFileName = config["GoodFileName"].ToString();

            if (_GoodFileName.Contains("[AppFile]"))
            {
                _GoodFileName = _GoodFileName.Replace("[AppFile]", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            }

            return _GoodFileName;
        }

    }
}
