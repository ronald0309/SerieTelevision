using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SerieTelevision

{
    public class Series
    {
        public bool Favorito
        {
            get;
            set;
        }
        public string TituloSerie
        {
            get;
            set;
        }
        public int AnnoEstreno
        {
            get;
            set;
        }
        public string GeneroSerie
        {
            get;
            set;
        }

        public List<Temporadas> Temporadas
        {
            get => default;
            set
            {
            }
        }

        public List<Series> SeriesSugeridas()
        {
            throw new System.NotImplementedException();
        }
    }
}