namespace Tman.LabOps.Infrastructure.CrossCutting.Response
{
    public class ApiResponse<TData>
    {
        public bool? Success { get; set; }
        public int? TotalCount { get; set; }
        public string? Message { get; set; }
        public IEnumerable<TData> Data { get; set; } = null!;
    }
}
