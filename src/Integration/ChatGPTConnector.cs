using System;
using System.Threading.Tasks;
using OpenAI_API;

namespace CNCPulse.Integration
{
    public class ChatGPTConnector
    {
        private readonly OpenAIAPI api;

        public ChatGPTConnector(string apiKey)
        {
            api = new OpenAIAPI(apiKey);
        }

        public async Task<string> GetChatResponse(string prompt)
        {
            try
            {
                var result = await api.Completions.CreateCompletionAsync(prompt);
                return result.Completions[0].Text;
            }
            catch (Exception ex)
            {
                Logger.Log($"Error in ChatGPT API call: {ex.Message}");
                throw;
            }
        }
    }
}
