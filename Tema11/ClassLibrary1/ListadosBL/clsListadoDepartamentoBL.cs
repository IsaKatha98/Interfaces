using DAL.Listados;
using DAL.ListadosDAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ListadosBL
{
    public static class clsListadoDepartamentoBL
    {
        /// <summary>
        /// Método que llama a la función de listado de departamentos de la capa DAL
        /// y devuelve un listado de personas. 
        /// </summary>
        public async static Task<List<clsDepartamento>> ListadoCompletoDepartamentosBL()
        {
            //llamamos a la lista de personas de la capa DAL
            List<clsDepartamento> listadosDepartamentosBL = await clsListadoDepartamentosDAL.ListadoCompletoDepartamentosDAL();
           

            return listadosDepartamentosBL;
        }

        /// <summary>
        /// Método que lee los detalles de un departamento,
        /// llamando a la función de la capa DAL
        /// 
        /// Pre: recibe un id de un departamento.
        /// Post: 
        /// </summary>
        /// <param name="idDepartamento"></param>
        /// <returns></returns>
        public async static Task<clsDepartamento> readDetailsDepartamentoBL(int idDepartamento)
        {
            //Ponemos await porque está función deberá esperar que la capa DAL haga el request
            clsDepartamento oDepartamento = await clsListadoDepartamentosDAL.readDetailsDepartamentoDAL(idDepartamento);

            return oDepartamento;


        }
    }
}
