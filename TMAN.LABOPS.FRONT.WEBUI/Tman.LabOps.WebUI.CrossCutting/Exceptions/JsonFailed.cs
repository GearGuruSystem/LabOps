namespace Tman.LabOps.Infrastructure.CrossCutting.Exceptions
{
#pragma warning disable IDE0290

    public class JsonFailed : Exception
    {
        public string? Msg { get; set; }

        public JsonFailed(string msg)
        {
            Msg = msg;
        }
    }
}
