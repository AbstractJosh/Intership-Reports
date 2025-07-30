public interface IPaymentStrategy {
    void Pay(double amount);
}

public class CreditCardPayment : IPaymentStrategy {
    public void Pay(double amount) => Console.WriteLine("Paid with credit card");
}

public class PayPalPayment : IPaymentStrategy {
    public void Pay(double amount) => Console.WriteLine("Paid with PayPal");
}

public class PaymentProcessor {
    private IPaymentStrategy _strategy;

    public PaymentProcessor(IPaymentStrategy strategy) {
        _strategy = strategy;
    }

    public void ProcessPayment(double amount) {
        _strategy.Pay(amount);
    }
}
