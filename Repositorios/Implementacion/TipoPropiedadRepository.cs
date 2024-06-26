﻿using maps2.Models;
using maps2.Repositorios.Contrato;
using System.Data;
using System.Data.SqlClient;

namespace maps2.Reporsitorio.Implementacion
{
    public class TipoPropiedadRepository : IGenericRepository<TipoPropiedad>
    {
        private readonly string _cadenaSQL = "";

        public TipoPropiedadRepository(IConfiguration configuration)
        {
            _cadenaSQL = configuration.GetConnectionString("cadenaSQL");
        }

        public async Task<List<TipoPropiedad>> Lista()
        {
            List<TipoPropiedad> _lista = new List<TipoPropiedad>();

            using (var conexion = new SqlConnection(_cadenaSQL))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_ListaTipoPropiedades", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        _lista.Add(new TipoPropiedad
                        {
                            idTipoPropiedad = Convert.ToInt32(dr["idTipoPropiedades"]),
                            nombre = dr["nombre"].ToString()
                        });
                    }
                }
            }

            return _lista;
        }

        public Task<bool> Editar(TipoPropiedad modelo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Guardar(TipoPropiedad modelo)
        {
            throw new NotImplementedException();
        }


    }
}
