using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Komis.Models
{
    [MetadataType(typeof(carregMetaData))]
    public partial class carreg
    {
        public class carregMetaData
        {
            [DisplayName("ID")]
            public int id { get; set; }

            [DisplayName("VIN")]
            public string VIN { get; set; }

            [DisplayName("Numer rejestracyjny")]
            public string nr_tablicy { get; set; }

            [DisplayName("Marka")]
            public string marka { get; set; }

            [DisplayName("Rocznik")]
            public int rocznik { get; set; }

            [DisplayName("Przebieg")]
            public int przebieg { get; set; }

            [DisplayName("Kolor")]
            public string kolor { get; set; }

            [DisplayName("Dostępność")]
            public string dostepnosc { get; set; }
        }
        
    }
}