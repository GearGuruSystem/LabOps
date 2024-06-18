namespace LabOps.Application.Requests
{
    public abstract class Request<T> where T : class
    {
        public Guid IdRequest { get; set; } = Guid.NewGuid();
        public object? Dados { get; set; }
    }
}
