using System;
using System.Net;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace web_practice
{
    public class PrintAsyncStrategy : IPrintPhraseStrategy
    {
        public async Task<List<WebResponse>> GetIncampResponse()
        {
            List<Task<WebResponse>> responses = new List<Task<WebResponse>>();

            responses.Add(GetResponse("who"));
            responses.Add(GetResponse("how"));
            responses.Add(GetResponse("does"));
            responses.Add(GetResponse("what"));

            return await Task.WhenAll(responses)
            .ContinueWith(async task => task.Result.Select(responses => responses)
            .ToList()).Result;
        }

        private async Task<WebResponse> GetResponse(String mapping)
        {
            return await WebRequest.Create($"{UrlService.GetRandomUrl()}/{mapping}").GetResponseAsync();
        }
    }
}
