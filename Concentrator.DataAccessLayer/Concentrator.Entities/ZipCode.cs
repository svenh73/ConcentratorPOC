using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ZipCode
    {
        public int ZipCodeID { get; set; }
        public string PCWIJK { get; set; }
        public string PCLETTER { get; set; }
        public string PCREEKSID { get; set; }
        public Nullable<int> PCREEKSVAN { get; set; }
        public Nullable<int> PCREEKSTOT { get; set; }
        public string PCCITYTPG { get; set; }
        public string PCCITYNEN { get; set; }
        public string PCSTRTPG { get; set; }
        public string PCSTRNEN { get; set; }
        public string PCSTROFF { get; set; }
        public string PCCITYEXT { get; set; }
        public string PCSTREXT { get; set; }
        public Nullable<int> PCGEMEENTEID { get; set; }
        public string PCGEMEENTENAAM { get; set; }
        public string PCPROVINCIE { get; set; }
        public Nullable<int> PCCEBUCO { get; set; }
    }
}
