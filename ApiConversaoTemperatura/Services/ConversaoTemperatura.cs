using ApiConversaoTemperatura.Models;

namespace ApiConversaoTemperatura.Services
{
    public class ConversaoTemperatura
    {
        public EscalasModel ConversaoCelsius(double valor)
        {
            EscalasModel escalas = new EscalasModel();

            escalas.Celsius = valor;
            escalas.Kelvin = valor + 273.15;
            escalas.Fahrenheit = valor * 1.8 + 32; 

            return escalas;
        }

        public EscalasModel ConversaoKelvin(double valor)
        {
            EscalasModel escalas = new EscalasModel();

            escalas.Kelvin = valor;
            escalas.Celsius = valor - 273.15; 
            escalas.Fahrenheit = valor * 1.6 - 459.67;

            return escalas;
        }

        public EscalasModel ConversaoFahrenheit(double valor)
        {
            EscalasModel escalas = new EscalasModel();

            escalas.Fahrenheit = valor; 
            escalas.Celsius = (valor - 32) / 1.8;
            escalas.Kelvin = (valor + 459.67) / 1.8;

            return escalas; 
        }
    }
}
