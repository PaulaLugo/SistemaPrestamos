﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Layer
{
    [DataContract]
    public class Cliente:Persona
    {
        private DateTime fechaAlta;
        private bool activo;

        [DataMember]
        public string Usuario { get; set; }

        public Cliente()
        {
            this.Usuario = "pau";
            this.fechaAlta = DateTime.Now;
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }


        public DateTime FechaAlta
        {
            get { return fechaAlta; }
            set { fechaAlta = value; }
        }

        public override string ToString()
        {
            return string.Format("Cliente {0}, {1}",this._apellido,this._nombre);
        }
    }
}
