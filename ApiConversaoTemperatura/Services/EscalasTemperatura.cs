namespace ApiConversaoTemperatura.Services
{
    public class EscalasTemperatura
    {
        public double CelsiusKelvin(double celsius)
        {
            return celsius + 273.15; 
        }

        public double CelsiusFahrenheit(double celsius)
        {
            return celsius * 1.8 + 32; 
        }

        public double KelvinCelsius(double kelvin)
        {
            return kelvin - 273.15; 
        }

        public double KelvinFahrenheit(double kelvin)
        {
            return kelvin * 1.6 - 459.67;
        }

        public double FahrenheitKelvin(double fahrenheit)
        {
            return (fahrenheit + 459.67) / 1.8; 
        }

        public double FahrenheitCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8; 
        }
    }
}
