using Backend.Modelo;
using Backend.Repositorios.Interfaces;
using System.Collections.Generic;

namespace Backend.Repositorios.Mocks
{
    public class MockEmpleadoRepositorio : IEmpleadoRepositorio
    {
        private List<Empleado> _empleados = new List<Empleado> { 
            new Empleado() { ApellidoYNombre = "Marcelo" },
            new Empleado() { },
            new Empleado() { },
        };

        public void crearEmpleado(Empleado empleado)
        {
            _empleados.Add(empleado);
        }

        public void modificarEmpleado(int id, Empleado usuario)
        {
            throw new System.NotImplementedException();
        }

        public List<Empleado> traerEmpleados()
        {
            return _empleados;
        }
    }
}
