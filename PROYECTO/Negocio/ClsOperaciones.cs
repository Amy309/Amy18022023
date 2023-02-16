using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROYECTO.Entidades;

namespace PROYECTO.Negocio
{
    public class clsOperaciones
    {
        public int Conteo(Operaciones operaciones){
            return operaciones.palabra.Length;
        }
    }
}