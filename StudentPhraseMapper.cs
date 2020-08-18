using System;
using System.Net;
using System.Text;
using System.Linq;


namespace web_practice{
    public class StudentPhraseMapper{

        public StudentPhraseDto mapResponseToStudentPhraseDto(WebResponse response)
        {
            StudentPhraseDto studentDto = new StudentPhraseDto();
            String internName = response.Headers.GetValues("InCamp-Student").First();
            String incampWord = "";

            using (var read = new System.IO.StreamReader(response.GetResponseStream(), UTF8Encoding.UTF8))
            {
                incampWord += read.ReadToEnd();
            }

            studentDto.SetStudentName(internName);
            studentDto.SetWord(incampWord);

            return studentDto;
        }

    }
}
