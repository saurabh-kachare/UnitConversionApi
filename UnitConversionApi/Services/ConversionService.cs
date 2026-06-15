using UnitConversionApi.Repositories;

namespace UnitConversionApi.Services
{
    public class ConversionService
    {
        private readonly IUnitRepository _repository;

        public ConversionService(IUnitRepository repository)
        {
            _repository = repository;
        }

        public double Convert(string category,
                              string fromUnit,
                              string toUnit,
                              double value)
        {
            category = category.ToLower();

            if (category == "length")
            {
                var units = _repository.GetLengthUnits();

                return value *
                       (units[toUnit.ToLower()].Factor /
                        units[fromUnit.ToLower()].Factor);
            }

            if (category == "weight")
            {
                var units = _repository.GetWeightUnits();

                return value *
                       (units[toUnit.ToLower()].Factor /
                        units[fromUnit.ToLower()].Factor);
            }

            if (category == "temperature")
            {
                if (fromUnit.ToLower() == "celsius" &&
                    toUnit.ToLower() == "fahrenheit")
                {
                    return (value * 9 / 5) + 32;
                }

                if (fromUnit.ToLower() == "fahrenheit" &&
                    toUnit.ToLower() == "celsius")
                {
                    return (value - 32) * 5 / 9;
                }
            }

            throw new Exception("Invalid conversion.");
        }
    }
}