using System.Text.Json.Serialization;

namespace LabOps.Application.DTO.Response
{
    public class Response<TData>
    {
        [JsonPropertyOrder(0)]
        public bool Sucess { get; set; } = true;

        [JsonPropertyOrder(8)]
        public TData? Data { get; set; }

        [JsonPropertyOrder(2)]
        public string? Message { get; set; }

        [JsonPropertyOrder(1)]
        public int TotalCount {  get; set; }

        protected Response() { }

        public Response(TData? data, int totalCount, string? message = null)
        {
            TotalCount = totalCount;
            Data = data;
            Message = message;
        }

        public Response(TData? data, bool sucess, string? message = null)
        {
            Data = data;
            Sucess = sucess;
            Message = message;
        }
    }
}
