using System;

namespace web_practice
{

    public class UrlService
    {

        private static Random rand = new Random();

        private static String[] url = {
             "http://d0165c8e5358.ngrok.io",
              "http://12f1a14e7e50.ngrok.io",
               "http://4c1449a93861.ngrok.io",
                "http://7a45a5f78857.ngrok.io",
                 "http://e77fd3b7ed59.ngrok.io",
                  "http://a089177a583a.ngrok.io",
                   "http://aba617d86eae.ngrok.io",
                    "http://26b139b05b0f.ngrok.io",
                     "http://17f7ddd05769.ngrok.io",
                      "http://ef845d6343d7.ngrok.io",
                       "http://5e9e572e07b3.ngrok.io",
                        "http://67e5aa89deb6.ngrok.io",
                         "http://8a2f59ef9085.ngrok.io"};

        public static String GetRandomUrl(){
             return url[rand.Next(url.Length)]; 
        }
    }

}