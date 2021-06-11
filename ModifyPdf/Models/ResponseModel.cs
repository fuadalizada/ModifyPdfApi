namespace ModifyPdf.Models
{
    public class ResponseModel
    {
        public object Data { get; set; }
        public bool IsSucceed { get; set; }
        public string ErrorMessage { get; set; }
    }
}