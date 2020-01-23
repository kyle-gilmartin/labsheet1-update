using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet1
{
 
    public abstract class Band:IComparable
    {

        
        public string BandName { get; set; }
        public DateTime Year { get; set; }
        public string Members { get; set; }
        
        public List<Album> Albums { get; set; }

        public  Band(string bandName, DateTime year, string members  )
        {
            BandName = bandName;
            Year = year;
            Members = members;

            Albums = new List<Album>();
        }

        public  Band()
        {
            Albums = new List<Album>();
        }

        public class Rap : Band
        {
            public override string ToString()
            {
                return (this.BandName + " - Rap");
            }
        }
        public class Pop : Band
        {
            
            public override string ToString()
            {
                return (this.BandName + " - Pop");
            }
        }
        public class Dance : Band
        {
           
            public override string ToString()
            {
                return (this.BandName + " - Dance");
            }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{BandName}";
        }

        public string GetDetails1()
        {
            return $"{Year.ToShortDateString()}";
        }

        public string GetDetails2()
        {
            return $"{Members}";
        }
        public  string GetAlbums()
        {
            return $"{Albums}";
        }
    }
}
