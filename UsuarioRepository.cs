using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace SistemaProtoGuiA
{
    public class UsuarioRepository
    {
        public static void SaveOrUpdate(Usuario usuario)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (usuario.Id == 0)
                    {
                        dbContext.Usuarios.Add(usuario);
                    }
                    else
                    {
                        dbContext.Entry(usuario).State
                            = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
}
