using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerieTelevision
{
    public class Temporadas
    {
        public string FechaEstreno
        {
            get;
            set;
        }
        public string FechaProduccionTemporada
        {
            get;
            set;
        }
        public bool SeguirTemporada
        {
            get;
            set;
        }
        public bool TemporadaEmpezada
        {
            get;
            set;
        }
        public bool TemporadaVista
        {
            get;
            set;
        }

        public List<Capitulos> Capitulos
        {
            get => default;
            set
            {
            }
        }

        public float PorcentageTemporada()
        {
            throw new System.NotImplementedException();
        }
    }
    
}