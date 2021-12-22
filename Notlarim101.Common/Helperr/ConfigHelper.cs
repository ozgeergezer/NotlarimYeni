using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notlarim101.Common.Helperr
{
    public class ConfigHelper
    {
        //configurasyon manager web.config dosyası içinde appsettings içinde oluşturduğumuz mail dosyyalarının keylerine ulaşmak için kullanacağız
        //public static string Get(string key)
        //{
        //    return ConfigurationManager.AppSettings[key];
        //}

        public static T Get<T>(string key)
        {
            //port numarası gibi int bir geri dönüş istenirse bunu için metodu generic hale getirerek gelen tipi istenen tipe çevirerek göndeririz
            return (T)Convert.ChangeType(ConfigurationManager.AppSettings[key], typeof(T));
        }
    }
}
