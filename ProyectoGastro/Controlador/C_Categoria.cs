using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoGastro.Modelo;

namespace ProyectoGastro.Controlador
{
    class C_Categoria
    {
        private categoria Categoria = null;

        public C_Categoria(categoria Categoria)
        {
            this.Categoria = Categoria;
        }


        public static implicit operator categoria(C_Categoria value)
        {
            return value.Categoria;
        }
    }
}
