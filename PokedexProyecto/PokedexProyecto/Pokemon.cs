﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexProyecto
{
    class Pokemon
    {
        public string Nombre { get; set; }
        public int NumeroPokedex { get; set; }
        public string DescripcionDePokemon { get; set; }
        public bool shiny { get; set; }
        public Tipo TipoDeElemento { get; set; }
        public Tipo Debilidad { get; set; }
        public StatsBase EstadisticasBase { get; set; }
        public Naturaleza Naturaleza {get; set; }
        public Habilidad Habilidad { get; set; }
        public Pokemon()
        {
            this.TipoDeElemento = new Tipo();
            this.Debilidad = new Tipo();
            this.EstadisticasBase = new StatsBase();
            this.Naturaleza = new Naturaleza();
            this.Habilidad = new Habilidad();
        }

    }
}