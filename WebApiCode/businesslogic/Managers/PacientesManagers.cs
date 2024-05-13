using LNAT.businesslogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LNAT.businesslogic.Managers
{
    public class PacientesManagers
    {

        public void CrearCodepacientes(pacientes paciente)
        {
            Console.WriteLine("dentro la funcion");
            //logica de recibir un post y crear el paciente
            string code =$"{paciente.nombre[0]}{paciente.apellido[0]}{(paciente.Ci)}";
            Console.WriteLine(code);
            //aqui viene el post al api2
        }
    }
}
