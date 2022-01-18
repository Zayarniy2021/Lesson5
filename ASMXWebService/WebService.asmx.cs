using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ASMXWebService
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string Summ(string number1, string number2)
        {
            // Входные параметры объявляем типа String, чтобы принимать от пользователя любые символы,
            // их анализировать, и при "плохом вводе" сообщать по-русски.
            float a, b;
            bool flag = float.TryParse(number1, System.Globalization.NumberStyles.Number,
            System.Globalization.NumberFormatInfo.CurrentInfo, out a);
            if (flag == false) return "В первом поле должно быть число";
            flag = float.TryParse(number2, System.Globalization.NumberStyles.Number,
            System.Globalization.NumberFormatInfo.CurrentInfo, out b);
            if (flag == false) return "В первом поле должно быть число";
            return "Сумма:" + (a + b).ToString();
        }
    }
}
