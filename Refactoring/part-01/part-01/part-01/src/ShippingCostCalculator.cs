namespace part_01;

public interface IShippingCostCalculator
{
    decimal CalculateShipingCost(string carrier , decimal weight); 
}

public class AramexShipping : IShippingCostCalculator
{
    public decimal CalculateShipingCost(string carrier , decimal weightKg)
    {
        Console.WriteLine("Aramex is Working ... "); // for test 
        
        return weightKg * 12m; 
    }
}
public class FedExShipping : IShippingCostCalculator
{
    public decimal CalculateShipingCost(string carrier , decimal weightKg)
    {
        Console.WriteLine("FedEx is Working... " ); // for test 
        
        return weightKg * 15m; 
    }
}

public class DhlShipping : IShippingCostCalculator
{
    public decimal CalculateShipingCost(string carrier , decimal weightKg)
    {
        Console.WriteLine("Dhl is Working..."); // for test 
        return weightKg * 18m; 
    }
}

public class ShippingCostCalculator
{
    private readonly IShippingCostCalculator _shippingCostCalculator;

    public ShippingCostCalculator(IShippingCostCalculator shippingCostCalculator)
    {
        _shippingCostCalculator = shippingCostCalculator; 
    }

    public decimal Calculate(string carrier , decimal weightKg)
    {
        return _shippingCostCalculator.CalculateShipingCost(carrier , weightKg); 
    }
}