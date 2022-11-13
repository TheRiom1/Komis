using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Komis.Models
{
    [MetadataType(typeof(sprzedazMetaData))]
    public partial class sprzedaz
    {
        public class sprzedazMetaData
        {
            [DisplayName("ID samochodu")]
          
            public string carid { get; set; }

            [DisplayName("ID klienta")]

            public int custid { get; set; }

            [DisplayName("Cena sprzedaży")]
            public decimal cena { get; set; }

            [DisplayName("Data sprzedaży")]
            public System.DateTime data_sprzedazy { get; set; }
        }
    }

}
