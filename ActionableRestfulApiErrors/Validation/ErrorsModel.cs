using System.Collections.Generic;

namespace ActionableRestfulApiErrors.Validation
{
    public class ErrorsModel
    {
        public IEnumerable<ErrorModel> Errors { get; set; }
    }
}