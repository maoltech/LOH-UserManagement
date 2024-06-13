namespace Core.Dtos
{
    public class ResponseDto<T>
    {
        public string Message { get; set; }
        public Dictionary<string, string> Errs { get; set; }
        public T Data { get; set; }
        public int ResponseCode { get; set; }
    }
}