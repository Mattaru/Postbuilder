using HtmlAgilityPack;
using PBapp.MVVM.Models;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PBapp.Services
{
    class HTTPRequest
    {
        private static async Task<string> GetRequest(string url)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            HttpClient Client = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.SystemDefault;
            Client.DefaultRequestHeaders.Accept.Clear();
            var response = await Client.GetStringAsync(url);

            return response;
        }

        private static HtmlDocument GetHTMLDoc(string httpResponse)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(httpResponse);

            return htmlDoc;
        }

        public static SourceModel GetSourceData(string url)
        {
            var response = (SynchronizationContext.Current is null ? GetRequest(url) : Task.Run(() => GetRequest(url))).Result;
            var htmlDoc = GetHTMLDoc(response);
            var News = HTMLParser.SwitchParser(url, htmlDoc);
            var sourceData = new SourceModel(url, News);

            return sourceData;
        }
    }
}
