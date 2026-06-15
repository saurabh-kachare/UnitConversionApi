using UnitConversionApi.Models;

namespace UnitConversionApi.Repositories
{
    public class UnitRepository : IUnitRepository
    {
        public Dictionary<string, UnitDefinition> GetLengthUnits()
        {
            return new Dictionary<string, UnitDefinition>
            {
                { "meter", new UnitDefinition { Name = "meter", Factor = 1 } },
                { "foot", new UnitDefinition { Name = "foot", Factor = 3.28084 } },
                { "kilometer", new UnitDefinition { Name = "kilometer", Factor = 0.001 } }
            };
        }

        public Dictionary<string, UnitDefinition> GetWeightUnits()
        {
            return new Dictionary<string, UnitDefinition>
            {
                { "kilogram", new UnitDefinition { Name = "kilogram", Factor = 1 } },
                { "pound", new UnitDefinition { Name = "pound", Factor = 2.20462 } }
            };
        }
    }
}