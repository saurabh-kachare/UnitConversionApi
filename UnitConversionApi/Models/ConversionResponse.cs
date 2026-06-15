namespace UnitConversionApi.Models
{
    public class ConversionResponse
    {
        public double InputValue { get; set; }
        public string FromUnit { get; set; }
        public string ToUnit { get; set; }
        public double Result { get; set; }
    }
}