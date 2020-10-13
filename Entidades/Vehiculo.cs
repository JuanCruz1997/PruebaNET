using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class Vehiculo
    {
        private string _patente;
        private string _marca;
        private string _modelo;
        private int _puertas;
        private string _titular;
        [DataMember]
        public string Patente { get => _patente; set => _patente = value; }
        [DataMember]
        public string Marca { get => _marca; set => _marca = value; }
        [DataMember]
        public string Modelo { get => _modelo; set => _modelo = value; }
        [DataMember]
        public int Puertas { get => _puertas; set => _puertas = value; }
        [DataMember]
        public string Titular { get => _titular; set => _titular = value; }
        public override string ToString()
        {
            return this._patente + " - " + this._marca + " " + this._modelo + " - Titular: " + this._titular;
        }
    }
}
