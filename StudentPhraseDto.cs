using System;

namespace web_practice
{

    public class StudentPhraseDto
    {

        private String word;
        private String studentName;



        public void SetStudentName(String name){
            this.studentName = name;
        }

        public void SetWord(String word){
            this.word = word;
        }

        public String GetWord()
        {
            return this.word;
        }
        public String GetStudentName()
        {
            return this.studentName;
        }
    }
}