using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TextAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class helloWorldAPI : ControllerBase
    {
       

        [HttpGet]
        public string Get()
        {
            return "Hello world";
            
        }

        [HttpGet("GetSaludo/{nombre}")]
        public string Get(string nombre) 
        {
            return "Hola " + nombre;
        }

        private struct User
        {
            public string nombre; 
            public int id;
            public string edad;
        }

        [HttpGet("GetUsuario/{id}/{nombre}/{edad}")]
        public string Get(string edad, int id, string nombre) 
        { 
            User usuario = new User();
            usuario.edad = edad;    
            usuario.id = id;
            usuario.nombre = nombre;

            string respuesta  = JsonConvert.SerializeObject(usuario);
            return respuesta;
        }

        public class UsuarioP
        {
            public int id { get; set; }
            public string name { get; set;}
        }

        [HttpPost("PostUser")]
        public string Post(UsuarioP usuario)
        {
            return JsonConvert.SerializeObject(usuario);
        }

    }
}
