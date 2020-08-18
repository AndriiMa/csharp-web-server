using System.Net;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace web_practice{

    public interface IPrintPhraseStrategy
    {
        Task<List<WebResponse>> GetIncampResponse();
    }

}