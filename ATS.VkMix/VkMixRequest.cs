using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;

namespace ATS.VkMix
{
    public class VkMixRequest
    {
        public static RequestBuilder CreateBuilder()
        {
            return new RequestBuilder();
        }
        
        public async Task<string> GetResponseAsync()
        {
            return await $"https://vkmix.com/api/2/{RequestType}"
                .ToString()
                .PostAsync(new FormUrlEncodedContent(CreateRequestBody()))
                .ReceiveString();
        }

        private IEnumerable<KeyValuePair<string, string>> CreateRequestBody()
        {
            var collection = new List<KeyValuePair<string, string>>();
            
            collection.AddRange(new []
            {
                new KeyValuePair<string, string>("api_token", ApiKey),
                new KeyValuePair<string, string>("network", Network), 
                new KeyValuePair<string, string>("section", Section), 
                new KeyValuePair<string, string>("link", Link), 
                new KeyValuePair<string, string>("count", Count), 
                new KeyValuePair<string, string>("amount", Amount),
                new KeyValuePair<string, string>("poll", Poll),
                new KeyValuePair<string, string>("offset", Offset),
                new KeyValuePair<string, string>("hourly_limit", HourlyLimit),
            });

            if (Comments != null)
            {
                collection.AddRange(Comments.Select(comment => new KeyValuePair<string, string>("comments[]", comment)));
            }

            if (Ids != null)
            {
                collection.AddRange(Ids.Select(id => new KeyValuePair<string, string>("ids[]", id)));
            }
            
            collection.RemoveAll(v => string.IsNullOrEmpty(v.Value));
            
            return collection;
        }

        public string ApiKey { get; set; }
        public string RequestType { get; set; }
        public string Network { get; set; }
        public string Section { get; set; }
        public string Link { get; set; }
        public string Count { get; set; }
        public string Amount { get; set; }
        public string[] Comments  { get; set; }
        public string Poll  { get; set; }
        public string[] Ids { get; set; }
        public string Offset { get; set; }
        public string HourlyLimit { get; set; }
    }
}