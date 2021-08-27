using System.IO;
using System.Net;

namespace GitHubSearchProject.Add_App
{
    public static class GetData
    {
        public static string Get(string searchString)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"{Settings.Url}{searchString}");
            request.Accept = Settings.Accept;
            request.Headers.Add(Settings.AcceptLanguageKey, Settings.AcceptLanguageValue);
            request.UserAgent = Settings.UserAgent;
            string responseFromServer;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (Stream dataStream = response.GetResponseStream())
            {
                var reader = new StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();
            }
            response.Close();
            return responseFromServer;
        }
    }
}
