using System;

namespace web_practice
{

    public class UrlService
    {

        private static Random rand = new Random();

        private static String[] url = {
            "http://service1-api:5001",
            "http://service2-api:5002",
	        "http://service3-api:5003"
        };

        public static String GetRandomUrl(){
             return url[rand.Next(url.Length)]; 
        }
    }

}
