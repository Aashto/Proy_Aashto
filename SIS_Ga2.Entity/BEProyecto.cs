﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Ga2.Entity
{
  public  class BEProyecto
    {
        public int idProyecto{ get; set; }
        public string Num_Proyecto { get; set; }
        public string Proyecto { get; set; }
        public string idUsuario { get; set; }
        public bool Estado { get; set; }
        public string Aplicacion { get; set; }   
        public double FechaCreacion { get; set; }
        public double HoraCreacion { get; set; }
        public string UsrCreacion { get; set; }
        public double FechaActualizacion { get; set; }
        public double HoraActualizacion { get; set; }
        public string UsrActualizacion { get; set; }
    }
}
