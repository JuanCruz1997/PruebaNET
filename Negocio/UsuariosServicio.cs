using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class UsuariosServicio
    {
        private NombresMapper _nombresMapper;
        public UsuariosServicio()
        {
            _nombresMapper = new NombresMapper();
        }
        public List<String> TraerTitulares()
        {
            List<String> result = _nombresMapper.TraerNombres();
            return result;
        }
    }
}
