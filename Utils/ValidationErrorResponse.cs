using System.Collections.Generic;

    namespace Formula1Backend.Utils
 {
    public class ValidationErrorResponse
    {
        public List<string> Errors { get; set; }

        public ValidationErrorResponse()
        {
            Errors = new List<string>();
        }
    }
 }
