using DAL.HandlerDAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.HandlerBL
{
    public static class clsHandlerPersonaBL
    {
        public async static Task<int> borrarPersonaDAL(int id)
        {
            //TODO:los domingos no se puede eliminar a ninguna persona

            return await clsHandlerPersonaDAL.borrarPersonaDAL(id);
        }
    }
}
