using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsListAnswers
    {
        public static List<clsAnswers> FullListOfAnswers()
        {
            List<clsAnswers> listAnswers;

            listAnswers = new List<clsAnswers>
            {
                new clsAnswers(1,"Bulbasaur"),
                new clsAnswers(2, "Ditto"),
                new clsAnswers(3, "Meowth"),
                new clsAnswers(4, "Cyndaquil"),
                new clsAnswers(5, "Dialga"),
                new clsAnswers(6, "Rayquaza"),
                new clsAnswers(7, "Eevee"),
                new clsAnswers(8, "Zubat"),
                new clsAnswers(9, "Reshiram"),
                new clsAnswers(10, "Indeedee"),
                new clsAnswers(11, "Charmeleon"),
                new clsAnswers(12, "Squirtle"),
                new clsAnswers(13, "Mewtwo"),
                new clsAnswers(14, "Geodude"),
                new clsAnswers(15, "Azumarill"),
                new clsAnswers(16, "Arceus"),
                new clsAnswers(17, "Abra"),


        };

            return listAnswers;
        }
    }
}
