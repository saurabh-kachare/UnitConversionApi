using UnitConversionApi.Models;

namespace UnitConversionApi.Repositories
{
    public interface IUnitRepository
    {
        Dictionary<string, UnitDefinition> GetLengthUnits();
        Dictionary<string, UnitDefinition> GetWeightUnits();
    }
}