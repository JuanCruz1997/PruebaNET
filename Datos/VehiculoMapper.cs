using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Entidades;
using System.Collections.Specialized;
using System.Data;

namespace Datos
{
    public class VehiculoMapper
    {
        public List<Vehiculo> GetVehiculos()
        {
            var reader = dbHelper.GetReader("select * from Vehiculo");

            List<Vehiculo> result = new List<Vehiculo>();
            while (reader.Read())
            {
                result.Add(Map(reader, new Vehiculo()));
            }
            reader.Close();
            return result;
        }

        protected Vehiculo Map(IDataReader dt, Vehiculo v)
        {
            v.Patente = dt["Patente"].ToString();
            v.Marca = dt["Marca"].ToString();
            v.Modelo = dt["Modelo"].ToString();
            v.Puertas = Convert.ToInt32(dt["Puertas"]);
            v.Titular = dt["Titular"].ToString();
            return v;
        }

        public int InsertVehiculo(Vehiculo v)
        {
            return dbHelper.Execute(ReverseMap(v));
        }

        protected string ReverseMap(Vehiculo v)
        {
            string q = string.Format("insert into Vehiculo({0},{1},{2},{3},{4})", v.Patente, v.Marca, v.Modelo, v.Puertas, v.Titular); 
            return q;
        }

    }
}
