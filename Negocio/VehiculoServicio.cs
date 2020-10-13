using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class VehiculoServicio
    {
        private VehiculoMapper _vehiculoMapper;
        
        public VehiculoServicio()
        {
            _vehiculoMapper = new VehiculoMapper();
        }
        public List<Vehiculo> TraerVehiculos()
        {
            List<Vehiculo> result = _vehiculoMapper.GetVehiculos();
            return result;
        }
        public int AltaVehiculo(string patente, string marca, string modelo, int puertas, string titular)
        {
            Vehiculo v = new Vehiculo();
            v.Patente = patente;
            v.Marca = marca;
            v.Modelo = modelo;
            v.Puertas = puertas;
            v.Titular = titular;
            int resultado = _vehiculoMapper.InsertVehiculo(v);
            if (resultado != 0)
            {
                return resultado;
            }
            else
            {
                throw new Exception("Hubo un error en la petición al servidor.");
            }
        }
    }
}
