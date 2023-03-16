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
        EscalasTemperatura escalasTemperatura = new EscalasTemperatura();
        [HttpGet("celsius/{valor:double}")]
        public ActionResult<EscalasModel> Get(double valor)
        {
            try
            {
                EscalasModel escalas = new EscalasModel(valor, 
                    escalasTemperatura.CelsiusKelvin(valor), escalasTemperatura.CelsiusFahrenheit(valor));

                return Ok(escalas);
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
                EscalasModel escalas = new EscalasModel(escalasTemperatura.KelvinCelsius(valor),
                    valor, escalasTemperatura.KelvinFahrenheit(valor));

                return Ok(escalas);
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
                EscalasModel escalas = new EscalasModel(escalasTemperatura.FahrenheitCelsius(valor),
                    escalasTemperatura.FahrenheitKelvin(valor), valor);

                return Ok(escalas);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
