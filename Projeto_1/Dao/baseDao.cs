using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// organização do tipos
namespace Dao
// escopo do namespace
{
    
    //criação da classe
      public class baseDao
    {
        //declaração da instancia da classe de conexão
       private Project_oneEntities objEntities = new Project_oneEntities();

        // métodos de intrução entities
        /// <summary>
        /// Criar lista base_log
        /// </summary>
        /// <returns>base_log</returns>
        public List <base_log> Listar()
        { 
               try
            {
                return objEntities.base_log.ToList();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        /// <summary>
        /// Criar consultas diretas ao banco de dados
        /// </summary>
        /// <returns>base_log</returns>
        public IQueryable<base_log> Iquery()
        {
            try
            {
                return objEntities.base_log.AsQueryable();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}

