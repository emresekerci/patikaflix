using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patikaflix.Models
{
    public class Dizi
    {
        public string DiziAdi { get; set; }
        public int YapimYili { get; set; }
        public string Turu { get; set; }
        public int YayinaBaslamaYili { get; set; }
        public string Yonetenler { get; set; }
        public string YayinlandigiIlkPlatform { get; set; }
    }

}
