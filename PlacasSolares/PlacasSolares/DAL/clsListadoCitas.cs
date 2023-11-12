using PlacasSolares.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacasSolares.DAL
{
    public static class clsListadoCitas
    {
        public static ObservableCollection<clsCita> getListadoCitas()
        {
            ObservableCollection<clsCita> listadoCitas= new ObservableCollection<clsCita>()

             {
             
                new clsCita() {Id = 1, Nombre = "Carmen Martin", Direccion="Calle San Cristobal, 8", Tlf=653873241, Tipo="Instalación de placas de tipo A", Hora="09:30"},
                new clsCita() {Id = 2, Nombre = "Carmen Martin", Direccion="Calle San Cristobal, 8", Tlf=653873241, Tipo="Instalación de placas de tipo A", Hora="09:30"},
                new clsCita() {Id = 3, Nombre = "Carmen Martin", Direccion="Calle San Cristobal, 8", Tlf=653873241, Tipo="Instalación de placas de tipo A", Hora="09:30"},
                new clsCita() {Id = 4, Nombre = "Carmen Martin", Direccion="Calle San Cristobal, 8", Tlf=653873241, Tipo="Instalación de placas de tipo A", Hora="09:30"},
                new clsCita() {Id = 5, Nombre = "Carmen Martin", Direccion="Calle San Cristobal, 8", Tlf=653873241, Tipo="Instalación de placas de tipo A", Hora="09:30"},
                new clsCita() {Id = 6, Nombre = "Carmen Martin", Direccion="Calle San Cristobal, 8", Tlf=653873241, Tipo="Instalación de placas de tipo A", Hora="09:30"},
                new clsCita() {Id = 7, Nombre = "Carmen Martin", Direccion="Calle San Cristobal, 8", Tlf=653873241, Tipo="Instalación de placas de tipo A", Hora="09:30"},
                new clsCita() {Id = 8, Nombre = "Carmen Martin", Direccion="Calle San Cristobal, 8", Tlf=653873241, Tipo="Instalación de placas de tipo A", Hora="09:30"},
                new clsCita() {Id = 9, Nombre = "Carmen Martin", Direccion="Calle San Cristobal, 8", Tlf=653873241, Tipo="Instalación de placas de tipo A", Hora="09:30"},
                new clsCita() {Id = 10, Nombre = "Carmen Martin", Direccion="Calle San Cristobal, 8", Tlf=653873241, Tipo="Instalación de placas de tipo A", Hora="09:30"},
                new clsCita() {Id = 11, Nombre = "Carmen Martin", Direccion="Calle San Cristobal, 8", Tlf=653873241, Tipo="Instalación de placas de tipo A", Hora="09:30"},
                new clsCita() {Id = 12, Nombre = "Carmen Martin", Direccion="Calle San Cristobal, 8", Tlf=653873241, Tipo="Instalación de placas de tipo A", Hora="09:30"},
                new clsCita() {Id = 13, Nombre = "Carmen Martin", Direccion="Calle San Cristobal, 8", Tlf=653873241, Tipo="Instalación de placas de tipo A", Hora="09:30"},

             };

            return listadoCitas;
        }
              
    }      
    
}
