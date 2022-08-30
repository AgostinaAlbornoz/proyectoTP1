using Backend.Modelo;
using System.Collections.Generic;

namespace Backend.Repositorios.Interfaces
{
    public interface IEmpleadoRepositorio
    {
        List<Empleado> traerEmpleados();
        void crearEmpleado(Empleado empleado);
        void modificarEmpleado(int id, Empleado empleado);
    }
}
