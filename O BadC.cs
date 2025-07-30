public class DiscountCalculator {
    public double Calculate(string customerType, double total) {
        if (customerType == "Regular") return total * 0.9;
        if (customerType == "VIP") return total * 0.8;
        return total;
    }
}
