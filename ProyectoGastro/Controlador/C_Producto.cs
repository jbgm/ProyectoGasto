using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoGastro.Modelo;

namespace ProyectoGastro.Controlador
{
    public class C_Producto
    {
        private producto _producto = null; 
        public C_Producto(producto Producto)
        {
            this.Producto = Producto;
        }

        public producto Producto
        {
            get { return this._producto; }
            protected set { this._producto = value; }
        }

        public string Nombre
        {
            get { return this.Producto.Nombre; }
        }

        public string Fabricante
        {
            get { return this.Producto.Fabricante; }
        }


        public C_Producto BuscarPorNombre(string nombre)
        {
            return new C_Producto((from p in Entidades.Productos where p.Nombre.StartsWith(nombre) select p).First());
        }

        public C_Producto BuscarPorID(int id)
        {
            return new C_Producto((from p in Entidades.Productos where p.id == id select p).First());
        }

        public List<C_Producto> BuscarListaPorNombre(string nombre)
        {
            List<producto> productosTemp = (from p in Entidades.Productos where p.Nombre.StartsWith(nombre) select p).ToList();
            List<C_Producto> productos = new List<C_Producto>();
            foreach (producto i in productosTemp)
                productos.Add(i);
            return productos;
        }

        public List<C_Producto> BuscarListaPorTipo(string nombre)
        {
            return (from p in Entidades.Productos where p.Nombre.StartsWith(nombre) select p).ToList();
        }

        public static implicit operator C_Producto(producto value)
        {
            return new C_Producto(value);
        }

    }
}
