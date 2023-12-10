using DAL.HandlerDAL;
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
        public async static Task<int> borrarDepartamentoBL(int idDepartamento)
        {
            return await clsHandlerDepartamentoDAL.borrarDepartamentoDAL(idDepartamento);
        }
    }
}
