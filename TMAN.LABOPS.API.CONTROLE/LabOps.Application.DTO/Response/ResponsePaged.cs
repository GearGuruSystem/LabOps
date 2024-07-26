using System.Text.Json.Serialization;

namespace LabOps.Application.DTO.Response
{
    public class ResponsePaged<TData> : Response<TData>
    {
        public int PageSize { get; private set; } = 25;
        public int PageNumber { get; private set; } = 1;
        public int TotalCount { get; private set; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
        public int CurrentPage {  get; private set; }

        [JsonConstructor]
        public ResponsePaged(TData? data, int totalCount, int currentPage = 1, int pageSize = 25) : base(data)
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
