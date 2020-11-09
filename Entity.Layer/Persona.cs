﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Layer
{

    [DataContract]
    public class Persona
    {
        protected string _nombre;
        protected string _apellido;
        private string _direccion;
        private string _mail;
        private int _id;


        [DataMember]
        public int Id { get => _id; set => _id = value; }
        [DataMember]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [DataMember]
        public string Apellido { get => _apellido; set => _apellido = value; }

        [DataMember]
        public string Direccion { get => _direccion; set => _direccion = value; }

        [DataMember]
        public string Mail { get => _mail; set => _mail = value; }

        [DataMember]
        public string Telefono { get; set; }


    }
}
