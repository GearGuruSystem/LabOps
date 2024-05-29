using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Headers;

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
                throw new ApplicationException(response.ReasonPhrase);
            }
            var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            JsonSerializerSettings jsonSerializerOptions = new JsonSerializerSettings { ContractResolver = new CustomContractResolver() };
            JsonSerializerSettings options = jsonSerializerOptions;
            return JsonConvert.DeserializeObject<T>(dataAsString, options);
        }

        public static Task<HttpResponseMessage> PostAsJson<T>(this HttpClient httpClient, string url, T data)
        {
            var dataAsString = JsonConvert.SerializeObject(data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = _contentType;
            return httpClient.PostAsync(url, content);
        }

        public static Task<HttpResponseMessage> PutAsJson<T>(this HttpClient httpClient, string url, T data)
        {
            var dataAsString = JsonConvert.SerializeObject(data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = _contentType;
            return httpClient.PutAsync(url, content);
        }

        private class CustomContractResolver : DefaultContractResolver
        {
            protected override string ResolvePropertyName(string propertyName)
            {
                return propertyName.ToLower();
            }
        }
    }
}
