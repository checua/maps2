using maps2.Models;
using maps2.Repositorios.Contrato;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProyectoLogin.Models;

namespace ProyectoLogin.Servicios.Implementacion
{
    public class UsuarioService : IUsuarioService
    {
        private readonly DBMarkersContext _dbContext;
        public UsuarioService(DBMarkersContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Usuario> GetUsuario(string correo, string clave)
        {
            Usuario usuario_encontrado = await _dbContext.Usuarios.Where(u => u.correo == correo && u.contra == clave)
                 .FirstOrDefaultAsync();

            return usuario_encontrado;
        }

        public async Task<Usuario> SaveUsuario(Usuario modelo)
        {
            _dbContext.Usuarios.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return modelo;
        }
    }
}