using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Datos
{
    public class NombresMapper
    {
        public List<String> TraerNombres()
        {
            string json2 = WebHelper.Get("https://reqres.in/api/users");
            List<String> resultado = MapList(json2);
            return resultado;
        }
        private List<String> MapList(string json)
        {
            List<String> lst = JsonConvert.DeserializeObject<List<String>>(json);
            return lst;
        }
    }
}
