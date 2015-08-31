namespace ActionableRestfulApiErrors.Validation
{
    public class ErrorState
    {
        public ErrorCode ErrorCode { get; set; }
        public string DocumentationPath { get; set; }
        public string DeveloperMessageTemplate { get; set; }
        public string UserMessage { get; set; }
    }
}