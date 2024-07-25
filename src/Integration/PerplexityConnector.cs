using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CNCPulse.Integration
{
    public class PerplexityConnector
    {
        private readonly HttpClient client;
        private readonly string apiKey;

        public PerplexityConnector(string apiKey)
        {
            this.apiKey = apiKey;
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
        }

        public async Task<string> GetChatResponse(string prompt)
        {
            var request = new
            {
                model = "llama-3-sonar-small-32k-chat",
                messages = new[]
                {
                    new { role = "user", content = prompt }
                }
            };

            var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            
            try
            {
                var response = await client.PostAsync("https://api.perplexity.ai/chat/completions", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    dynamic jsonResponse = JsonConvert.DeserializeObject(responseContent);
                    return jsonResponse.choices[0].message.content;
                }
                else
                {
                    throw new Exception($"Error: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"Error in Perplexity API call: {ex.Message}");
                throw;
            }
        }
    }
}
