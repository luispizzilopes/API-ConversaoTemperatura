using ApiConversaoTemperatura.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.Controllers;
using ApiConversaoTemperatura.Models;

namespace ApiConversaoTemperatura.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscalasTemperaturasController : ControllerBase
    {
        ConversaoTemperatura conversao = new ConversaoTemperatura();

        [HttpGet("celsius/{valor:double}")]
        public ActionResult<EscalasModel> Get(double valor)
        {
            try
            {
                return Ok(conversao.ConversaoCelsius(valor));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("Kelvin/{valor:double}")]
        public ActionResult<EscalasModel> GetKelvin(double valor)
        {
            try
            { 
                return Ok(conversao.ConversaoKelvin(valor));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("Fahrenheit/{valor:double}")]
        public ActionResult<EscalasModel> GetFahrenheit(double valor)
        {
            try
            {
                return Ok(conversao.ConversaoFahrenheit(valor));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
