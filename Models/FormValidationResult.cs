using System.Collections.Generic;

namespace DynamicFormGenerator.Models
{
    public class FormValidationResult
    {
        public bool IsValid { get; set; }
        public List<string> ErrorMessages { get; set; } = new();
    }
}
