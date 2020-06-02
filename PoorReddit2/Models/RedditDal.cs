using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PoorReddit2.Models
{
    public class RedditDal
    {
        public string GetAPIString(string subreddit)
        {
            string url = $"https://www.reddit.com/r/{subreddit}/.json";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            string output = rd.ReadToEnd();
            return output;
        }

        public RedditPost GetPost(string sr)
        {
            string output = GetAPIString(sr);
            RedditPost rp = JsonConvert.DeserializeObject<RedditPost>(output); 
            return rp;
        }
    }
}
