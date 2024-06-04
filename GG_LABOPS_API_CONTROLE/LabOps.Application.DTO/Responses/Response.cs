using System.Text.Json.Serialization;

namespace LabOps.Application.DTO.Responses
{
    public class Response<TData>
    {
        private readonly int _statusCode = Configuration.DefaultStatusCode;

        public TData? Data { get; set; }
        public string? Message { get; set; }

        public Response(TData? data, int code = Configuration.DefaultStatusCode, string? message = null)
        {
            Data = data;
            _statusCode = code;
            Message = message;
        }

        [JsonConstructor]
        public Response()
        {
            _statusCode = Configuration.DefaultStatusCode;
        }

        [JsonIgnore]
        public bool IsSuccess => _statusCode >= 200 && _statusCode <= 299;
    }
}
