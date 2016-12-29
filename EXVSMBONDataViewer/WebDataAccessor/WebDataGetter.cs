using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXVSMBONDataViewer.WebDataAccessor
{
    public class WebDataGetter
    {
        private static WebDataGetter wInstance;
        string id = "kaihuusvms@gmail.com";//メールアドレス
        string password = "1020tosiakiU";//パスワード

        Hashtable vals = new Hashtable();
        string url = "https://www.bandainamcoid.com/v2/oauth2/login?callback=https%3A%2F%2Fwww.bandainamcoid.com%2Fv2%2Foauth2%2Fauth%3Fclient_id%3Dgundamexvs%26redirect_uri%3Dhttp%253A%252F%252Fweb.vsmobile.jp%252Fon%252Flogin%252Fauth.html%26scope%3DJpGroupAll&client_id=gundamexvs&adcode=&scope=JpGroupAll&prompt=&text=";

        private WebDataGetter()
        {  
            vals.Add("callback", "https://www.bandainamcoid.com/v2/oauth2/auth?client_id=gundamexvs&amp;redirect_uri=http%3A%2F%2Fweb.vsmobile.jp%2Fon%2Flogin%2Fauth.html&amp;scope=JpGroupAll");
            vals.Add("client_id", "gundamexvs");
            vals.Add("adcode", "");
            vals.Add("scope", "JpGroupAll");
            vals.Add("mode", "exec");
            vals.Add("prompt", "");
            vals.Add("text", "");
            vals.Add("login_id", id);
            vals.Add("password", password);
            vals.Add("shortcut", "1");
            vals.Add("backto", "login?client_id=gundamexvs&amp;callback=https%3A%2F%2Fwww.bandainamcoid.com%2Fv2%2Foauth2%2Fauth%3Fclient_id%3Dgundamexvs%26redirect_uri%3Dhttp%253A%252F%252Fweb.vsmobile.jp%252Fon%252Flogin%252Fauth.html%26scope%3DJpGroupAll");
        }
        public static WebDataGetter Instance
        {
            get
            {
                if (wInstance == null)
                {
                    wInstance = new WebDataGetter();
                }
                return wInstance;
            }

        }
        public void getData()
        {
            string param = "";
            foreach(string k in vals.Keys)
            {
                param += String.Format("{0}={1}&", k, vals[k]);
            }
            byte[] data = Encoding.ASCII.GetBytes(param);
        }
    }
}
