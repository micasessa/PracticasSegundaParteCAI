﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoClientes.Entidades;
using ProyectoClientes.AccesoDatos;
using ProyectoClientes.Negocio;

namespace ProyectoClientes.Negocio
{
    public class ClienteServicio
    {
        private ClienteMapper _clienteMapper;

        //Constructor
        public ClienteServicio()
        {
            _clienteMapper = new ClienteMapper();
        }

        //metodos
        public List<Cliente> GetClientes()
        {
            return _clienteMapper.TraerClientes();
        }

        public void AddCliente (Cliente cliente)
        {
            _clienteMapper.Agregar(cliente);
        }
        
    }
}
