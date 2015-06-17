using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoGastro.Modelo;

namespace ProyectoGastro.Controlador
{
    public class C_Usuario
    {
        private static C_Usuario _usuario = null;
        usuario usuario = null;


        private C_Usuario()
        {
            
        }

        public static C_Usuario Usuario
        {
            get { return _usuario == null ? _usuario = new C_Usuario(): _usuario; }
        }

        public bool conectar(string nombre, string contraseña)
        {
            return true;
        }
    }
}
