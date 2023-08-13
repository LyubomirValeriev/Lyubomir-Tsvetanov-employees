namespace SirmaTaskCal.Services
{
    using Models;

    public interface ICalculatorService
    {
        BestPairServiceModel GetTheBestPair(string fileName);
    }
}
