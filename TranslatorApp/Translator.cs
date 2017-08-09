using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TranslatorApp
{

    public class Translator
    {



        private string subKey = "2d2642b2a44e4f6ca314a6aacfe9bf65";

        public async Task<string> Translate(string input, string lang) { }

        private HttpClient cl = new HttpClient();

        string currentToken = GetToken();
        string apiRequest = "http://api.microsofttranslator.com/v2/Http.svc/Translate?text=" + System.Net.WebUtility.UrlEncode(input) + "&to=" + lang;
        string translatedText = await.GetStringAsync(apiRequest);
        string Translation = XDocument.Parse(translatedText);
        translatedText = Translation.Root?.FirstNode.ToString();

                return translatedText




            async Task<string> GetToken()
        {
            Uri uri = new Uri("https://api.cognitive.microsoft.com/sts/v1.0/issueToken");
            var client = new HttpClient();
            var request = new HttpRequestMessage();

            request.Method = HttpMethod.Post;
            request.RequestUri = uri;
            request.Content = new StringContent(string.Empty);
            request.Headers.TryAddWithoutValidation("Ocp-Apim-Subscription-Key", subKey);
            var response = await client.SendAsync(request);
            string token = await response.Content.ReadAsStringAsync();

            return token;


        }




    }
}
