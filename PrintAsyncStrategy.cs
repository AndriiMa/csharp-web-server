using System.Net;
using System.Threading.Tasks;

namespace web_practice
{
    public class PrintAsyncStrategy : IPrintPhraseStrategy
    {
        public Task<WebResponse[]> GetIncampResponse()
        {
            throw new System.NotImplementedException();
        }
    }
}
