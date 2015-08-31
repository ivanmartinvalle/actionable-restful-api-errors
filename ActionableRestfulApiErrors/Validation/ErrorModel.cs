namespace ActionableRestfulApiErrors.Validation
{
    public class ErrorModel
    {
        public ErrorCode ErrorCode { get; set; }
        public string Field { get; set; }
        public string DeveloperMessage { get; set; }
        public string Documentation { get; set; }
        public string UserMessage { get; set; }
    }
}