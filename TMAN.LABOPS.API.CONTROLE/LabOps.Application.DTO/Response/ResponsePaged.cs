using System.Text.Json.Serialization;

namespace LabOps.Application.DTO.Response
{
    public class ResponsePaged<TData> : Response<TData>
    {
        [JsonPropertyOrder(5)]
        public int PageSize { get; private set; } = 25;

        [JsonPropertyOrder(4)]
        public int PageNumber { get; private set; } = 1;

        [JsonPropertyOrder(6)]
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);

        [JsonPropertyOrder(7)]
        public int CurrentPage { get; private set; }

        protected ResponsePaged() { }


        public ResponsePaged(TData? data, int totalCount, int currentPage = 1, int pageSize = 25) : base(data, totalCount)
        {
            Data = data;
            TotalCount = totalCount;
            PageSize = pageSize;
            CurrentPage = currentPage;
        }


        public ResponsePaged(bool sucess, string? message)
        {
            Sucess = sucess;
            Message = message;
        }


        public ResponsePaged(TData data, bool sucess, string? message = null) : base(data, sucess, message)
        {
            Data = data;
            Sucess = sucess;
            Message = message;
        }
    }
}
