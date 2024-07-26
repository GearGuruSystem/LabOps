using System.Text.Json.Serialization;

namespace LabOps.Application.DTO.Response
{
    public class Response<TData>
    {
        public bool Sucess { get; set; } = true;
        public TData? Data { get; set; }
        public string? Message { get; set; }

        protected Response() { }

        [JsonConstructor]
        public Response(TData? data, string? message = null)
        {
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
