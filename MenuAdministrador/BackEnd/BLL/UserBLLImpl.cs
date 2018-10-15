using BackEnd.DAL;
using BackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.BLL
{
    public class UserBLLImpl : BLLGenericoImpl<Usuario>, IUserBLL
    {
        private UnidadDeTrabajo<Usuario> unidad;
        private SigecaEntities context;

        public bool eliminar(string idRole, int idUsuario)
        {
            throw new NotImplementedException();
        }

        /*     public string[] getRolesUsuario(string nombreUsuario)
            {
               string[] result;
                using (context = new SigecaEntities())
                {
                    result = context.sp_getRolesForUser(userName).ToArray();
                }


                return result;

    }*/

        public Usuario get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> getAll()
        {
            return this.getAll();
        }

        public Usuario getUsuario(string nombreUsuario)
        {
            try
            {
                Usuario resultado;
                using (unidad = new UnidadDeTrabajo<Usuario>(new SigecaEntities()))
                {
                    Expression<Func<Usuario, bool>> consulta = (u => u.nombre.Equals(nombreUsuario));
                    resultado = unidad.genericDAL.Find(consulta).ToList().FirstOrDefault();
                }
                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario getUsuario(string userName, string password)
        {
            try
            {
                Usuario resultado;
                using (unidad = new UnidadDeTrabajo<Usuario>(new SigecaEntities()))
                {
                    Expression<Func<Usuario, bool>> consulta = (u => u.nombre.Equals(userName)/* && u.Password.Equals(password)*/);
                    resultado = unidad.genericDAL.Find(consulta).ToList().FirstOrDefault();
                }
                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }

     /*   public List<Usuario> getUsuarioRol(string nombreRol)
        {
            List<Usuario> result = new List<Usuario>();
            List<string> lista;

            using (context = new SigecaEntities())
            {
                 lista = context.sp_getUsuariosRole(roleName).ToList();
                Usuario user;
                foreach (var item in lista)
                {
                    user = this.getUser(item);
                    result.Add(user);
                }


            }

            return result;
        }*/

        public bool insertar(int idRol, string login)
        {
            throw new NotImplementedException();
        }

        public bool insertar(string roleName, string login)
        {
            throw new NotImplementedException();
        }

      /*  public bool rolUsuario(string nombreUsuario, string rol)
        {

            bool result = false;


            using (context = new SigecaEntities())
            {
                result = context.sp_isUserInRole(userName, roleName) != 0;

            }

            return result;
        }*/

        public List<Rol> listarRoles()
        {
            throw new NotImplementedException();
        }

        public Usuario ObtenerPorID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
