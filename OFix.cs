public interface IDiscountStrategy {
    double ApplyDiscount(double total);
}

public class RegularDiscount : IDiscountStrategy {
    public double ApplyDiscount(double total) => total * 0.9;
}

public class VipDiscount : IDiscountStrategy {
    public double ApplyDiscount(double total) => total * 0.8;
}

public class DiscountCalculator {
    public double Calculate(IDiscountStrategy strategy, double total) {
        return strategy.ApplyDiscount(total);
    }
}
