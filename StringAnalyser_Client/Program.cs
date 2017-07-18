using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using System.Net.Http;
//using System.Runtime.Serialization.Json;



namespace StringAnalyser_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String below to analyse ");
            string inp = Console.ReadLine();
            string buildUrl = string.Format("http://localhost:40631/AnalyseString.svc/Analyse?value={0}", inp);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(buildUrl);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(responseStream);
            String output=(reader.ReadToEnd());
            StringProperties str= JsonConvert.DeserializeObject<StringProperties>(output);
            Console.WriteLine("Digits : {0}", str.digit_count);
            Console.WriteLine("Uppercase Letters : {0}", str.uppercase_count);
            Console.WriteLine("Lowercase Letters : {0}", str.lowercase_count);
            Console.ReadKey();
        }

        [Serializable]
        public class StringProperties
        {
            
            public int digit_count { get; set; }
            
            public int uppercase_count { get; set; }
            
            public int lowercase_count { get; set; }
        }

    }
}
