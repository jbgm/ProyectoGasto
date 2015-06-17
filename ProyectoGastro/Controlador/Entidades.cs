using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProyectoGastro.Modelo;

namespace ProyectoGastro.Controlador
{
    public static class Entidades
    {
        private static DBGastroClinicaEntities entidades = null;

        public static DBGastroClinicaEntities EntidadesGC { get { return entidades == null ? entidades = new DBGastroClinicaEntities() : entidades; } }

        public static DbSet<producto> Productos { get { return EntidadesGC.productoes; } }

        /// <summary>
        /// Categorias a las que puede pertenecer un producto especifico.
        /// </summary>
        public static DbSet<categoria> Categorias { get { return EntidadesGC.categorias; } }

        public static DbSet<usuario> Usuarios { get { return EntidadesGC.usuarios; } }

    }
}
