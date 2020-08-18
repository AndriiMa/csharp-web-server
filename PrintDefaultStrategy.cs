using System.Net;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace web_practice
{
    public class PrintDefaultStrategy : IPrintPhraseStrategy
    {
        public async Task<List<WebResponse>> GetIncampResponse()
        {
            List<WebResponse> responses = new List<WebResponse>();

            responses.Add(GetResponse("/who"));
            responses.Add(GetResponse("/how"));
            responses.Add(GetResponse("/does"));
            responses.Add(GetResponse("/what"));

            return responses;
        }

        private WebResponse GetResponse(String mapping)
        {
            return WebRequest.Create($"{UrlService.GetRandomUrl()}/{mapping}").GetResponse();
        }
    }
}