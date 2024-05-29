namespace GG_LabOps_Domain.DTOs
{
    public class ReturnDto<T> where T : class
    {
        public T ObjectReturn { get; set; }
    }
}
