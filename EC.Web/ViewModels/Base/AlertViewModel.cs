using System;

namespace EC.Web.ViewModels.Base
{
    [Serializable]
    public class AlertViewModel
    {
        public string AlertType { get; set; }

        public string AlertTitle { get; set; }

        public string AlertBody { get; set; }
    }
}
