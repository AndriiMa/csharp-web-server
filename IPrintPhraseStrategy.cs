using System.Net;
using System.Threading.Tasks;

namespace web_practice{

    public interface IPrintPhraseStrategy
    {
        Task<WebResponse[]> GetIncampResponse();
    }

}