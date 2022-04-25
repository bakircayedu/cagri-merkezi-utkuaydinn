using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev200601019
{ 
    public enum MusteriTur
        {
        Bireysel,
        Ticari
        }
    internal class Kisi
    {   
       

        public MusteriTur musteriTur { get; set; }

        
        
        

        public string Ad { get; set; }

        public string SoyAd { get; set; }
        
    }
    
}
