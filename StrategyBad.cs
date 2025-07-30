public class PaymentProcessor {
    public void Pay(string type, double amount) {
        if (type == "CreditCard")
            Console.WriteLine("Paid with credit card");
        else if (type == "PayPal")
            Console.WriteLine("Paid with PayPal");
    }
}
