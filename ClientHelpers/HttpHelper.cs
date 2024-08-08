using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Shared.ClientHelpers
{
    public class HttpHelper
    {
        private readonly HttpClient _httpClient;

        public HttpHelper()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetAsync(string url)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                throw new Exception("Error in GET request", ex);
            }
        } 
    }
}
