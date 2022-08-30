using Backend.Context;
using Backend.Modelo;
using Backend.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreMySQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private IEmpleadoRepositorio empleadoRepositorio;

        public EmpleadoController(MyDBContext context, IEmpleadoRepositorio _empleadoRepositorio)
        {
            empleadoRepositorio = _empleadoRepositorio;
        }

        [HttpGet]
        public IList<Empleado> Get()
        {
            return (empleadoRepositorio.traerEmpleados());
        }

        [HttpPost]
        public void Post([FromBody]string nombre)
        {
            Empleado empleado = new Empleado()
            {
                ApellidoYNombre = nombre
            };
            empleadoRepositorio.crearEmpleado(empleado);
        }

    }
}