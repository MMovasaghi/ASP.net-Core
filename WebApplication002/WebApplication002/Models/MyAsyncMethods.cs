using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace WebApplication002.Models
{
    public class MyAsyncMethods
    {
        public static Task<long?> GetPageLength1()
        {
            HttpClient client = new HttpClient();
            var httpTask = client.GetAsync("http://apress.com");
            return httpTask.ContinueWith((Task<HttpResponseMessage> antecedent) => {
                return antecedent.Result.Content.Headers.ContentLength;
            });
        }
        public async static Task<long?> GetPageLength2()
        {
            HttpClient client = new HttpClient();
            try
            {
                var httpMessage = await client.GetAsync("http://aparat.com");
                return httpMessage.Content.Headers.ContentLength;
            }
            catch (Exception)
            {
                return null;
            }
            
        }
    }
}
