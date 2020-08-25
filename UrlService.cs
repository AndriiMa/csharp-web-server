using System;

namespace web_practice
{

    public class UrlService
    {

        private static Random rand = new Random();

        private static String[] url = {
            "http://localhost:5001/",
            "http://localhost:5002/",
            "http://localhost:5003/"
        };

        public static String GetRandomUrl(){
             return url[rand.Next(url.Length)]; 
        }
    }

}