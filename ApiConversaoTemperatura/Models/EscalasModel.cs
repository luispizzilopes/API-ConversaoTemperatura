namespace ApiConversaoTemperatura.Models
{
    public class EscalasModel
    {
        public double Celsius { get; set; }
        public double Kelvin { get; set; }
        public double Fahrenheit { get; set; } 

        public EscalasModel() { }

        public EscalasModel(double celsius, double kelvin, double fahrenheit)
        {
            Celsius = celsius;
            Kelvin = kelvin;
            Fahrenheit = fahrenheit;
        }
    }
}
