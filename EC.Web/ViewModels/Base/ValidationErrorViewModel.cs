using Newtonsoft.Json;

namespace EC.Web.ViewModels.Base
{
    public class ValidationErrorViewModel
    {
        [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
        public string FieldName { get; set; }

        public string Message { get; set; }

        public ValidationErrorViewModel(string fieldName, string message)
        {
            FieldName = fieldName != string.Empty ? fieldName : null;
            Message = message;
        }
    }
}
