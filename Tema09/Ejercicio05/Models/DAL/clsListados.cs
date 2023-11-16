using Ejercicio05.Models.Entities;
using HealthKit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05.Models.DAL
{
    public class clsListados
    {
        //Constructor de clsListados, aunque no se puede poner 
        //el mismo nombre que la clase.
        public static ObservableCollection <clsPersona> listados() {

            //Instaciamos la lista.
            ObservableCollection<clsPersona> listadoPersonas = new ObservableCollection<clsPersona>()

            {
                new clsPersona ("Isabel", "Loerzer","https://thispersondoesnotexist.com" ),
                new clsPersona( "Isaac", "Ramos", "https://thispersondoesnotexist.com"),
                new clsPersona("Carmen", "Martín", "https://thispersondoesnotexist.com"),
                new clsPersona("Pedro", "Cornejo", "https://thispersondoesnotexist.com"),
                new clsPersona("Luisa", "Alejandra", "https://thispersondoesnotexist.com"),
                new clsPersona("Paco", "Rodriguez", "https://thispersondoesnotexist.com"),
                new clsPersona("Javi", "Gonzalez", "https://thispersondoesnotexist.com"),
                new clsPersona("Miguel", "Domínguez", "https://thispersondoesnotexist.com")
            };  
            
            
            return listadoPersonas;
        
        }
    }
}
