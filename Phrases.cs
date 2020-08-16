using System;

namespace web_practice{

    public class Phrases{

        private String[] whoes = {"Rat", "Mouse", "Dragon", "Andrew", "Eggs", "Soup", "Company", "Dungeon master"};
        private String[] howes = {"Not bad", "Bad", "Lovely", "Madly", "Sadly", "Good"};
        private String[] doeses = {"Burn with fire", "Dance with", "Develop", "Write", "Kill", "Resurrect", "Penetrete"};
        private String[] whates = {"Dungeon hole", "Himself", "Your mama", "His friend", "Your laptop", "Rat", "Banana", "Rat", "Server"};

        private Random rand = new Random();

        public Phrases(){}

        public String GetRandomWho(){
            return whoes[rand.Next(whoes.Length)];
        }
        public String GetRandomHow(){
            return howes[rand.Next(howes.Length)];
        }
        public String GetRandomDoes(){
            return doeses[rand.Next(doeses.Length)];
        }
        public String GetRandomWhat(){
            return whates[rand.Next(0,whates.Length)];
        }
    }

}