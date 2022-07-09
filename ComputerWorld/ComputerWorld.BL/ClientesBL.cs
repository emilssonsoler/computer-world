using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWorld.BL
{
    public class ClientesBL
    {

        Contexto _contexto;
        public List<Cliente> ListaDeClientes { get; set; }
        
        
        //Constructor
        public ClientesBL()
        {
            _contexto = new Contexto();
            ListaDeClientes = new List<Cliente>();
        }

        //obtener cliente
        public List<Cliente> ObtenerClientes()
        {
            ListaDeClientes = _contexto.Clientes
                .OrderBy(r => r.Nombre)
                .ToList();
            return ListaDeClientes;
        }

        //obtener cliente activos
        public List<Cliente> ObtenerClientesActivos()
        {
            ListaDeClientes = _contexto.Clientes
                .Where(r => r.Activo == true)
                .OrderBy(r => r.Nombre)
                .ToList();
            return ListaDeClientes;
        }

        //Guardar Clientes
        public void GuardarCliente(Cliente cliente)
        {
            if (cliente.Id == 0)
            {
                _contexto.Clientes.Add(cliente);
            }
            else
            {
                var clienteExistente = _contexto.Clientes.Find(cliente.Id);

                clienteExistente.Nombre = cliente.Nombre;
                clienteExistente.Telefono = cliente.Telefono;
                clienteExistente.Direccion = cliente.Direccion;
                clienteExistente.Activo = cliente.Activo;
            }

            _contexto.SaveChanges();
        }

        //Obtener un cliente
        public Cliente ObtenerCliente(int id)
        {
            var cliente = _contexto.Clientes.Find(id);

            return cliente;
        }

        //Eliminar un cliente
        public void EliminarCliente(int id)
        {
            var cliente = _contexto.Clientes.Find(id);

            _contexto.Clientes.Remove(cliente);
            _contexto.SaveChanges();
        }

    }
}
