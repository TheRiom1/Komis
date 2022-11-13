using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Komis.Models
{
    [MetadataType(typeof(customerMetaData))]
    public partial class customer
    {
        public class customerMetaData
        {
            [DisplayName("ID")]
            public int id { get; set; }

            [DisplayName("Imię")]
            public string imie { get; set; }

            [DisplayName("Nazwisko")]
            public string nazwisko { get; set; }

            [DisplayName("Pesel")]
            public int pesel { get; set; }

            [DisplayName("Ulica")]
            public string ulica { get; set; }

            [DisplayName("Kod pocztowy")]
            public string kodpocztowy { get; set; }

            [DisplayName("Miasto")]
            public string miasto { get; set; }
        }
    }

}
