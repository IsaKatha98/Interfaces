using DAL.HandlerDAL;
using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.HandlerBL
{
    public static class clsHandlerDepartamentoBL
    {
        public async static Task<int> insertaDepartamentoBL(clsDepartamento departamento)
        {
            return await clsHandlerDepartamentoDAL.insertaDepartamentoDAL(departamento);


        }
        public async static Task<int> actualizaDepartamentoBL(clsDepartamento departamento)
        {
            return await clsHandlerDepartamentoDAL.actualizaDepartamentoDAL(departamento);
        }
    }
}
