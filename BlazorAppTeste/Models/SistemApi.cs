using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAppTeste.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemApi : ControllerBase
    {
        public int IdSistema { get; set; } 
        public string Descricao { get; set; } 
    }
}
