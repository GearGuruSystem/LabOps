using System.Net.Http.Headers;
using System.Text.Json;
#pragma warning disable IDE0090 // Use 'new(...)'

namespace GG_LabOps_Infra.Useful
{
    internal static class HttpClientExtensions
    {

        private static readonly MediaTypeHeaderValue _contentType = new MediaTypeHeaderValue("application/json");

        public static async Task<T> ReadContentAs<T>(this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Algo deu errado: {response.ReasonPhrase}");
            }
            var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            JsonSerializerOptions options = jsonSerializerOptions;
            return JsonSerializer.Deserialize<T>(dataAsString,
                options);
        }

        public static Task<HttpResponseMessage> PostAsJson<T>(this HttpClient httpClient, string url, T data)
        {
            var dataAsString = JsonSerializer.Serialize(data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = _contentType;
            return httpClient.PostAsync(url, content);
        }

        public static Task<HttpResponseMessage> PutAsJson<T>(this HttpClient httpClient, string url, T data)
        {
            var dataAsString = JsonSerializer.Serialize(data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = _contentType;
            return httpClient.PutAsync(url, content);
        }
    }
}
