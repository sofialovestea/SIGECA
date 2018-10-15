using BackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.BLL
{
    public interface IUserBLL
    {

        bool insertar(int idRole, string login);
        bool insertar(string roleName, string login);
        Usuario getUsuario(string nombreUsuario);
        Usuario getUsuario(string nombreUsuario, string contrasenna);
        Usuario get(int id);
        List<Usuario> getAll();
        //bool rolUsuario(string nombreUsuario, string rol);
       // string[] getRolesUsuario(string nombreUsuario);
      //  List<Usuario> getUsuarioRol(string nombreRol);
        List<Rol> listarRoles();
        bool eliminar(string idRol, int idUsuario);
        Usuario ObtenerPorID(int id);
    }
}
