public interface IMachine {
    void Print();
    void Scan();
}

public class SimplePrinter : IMachine {
    public void Print() {
        Console.WriteLine("Printing...");
    }

    public void Scan() {
        throw new NotImplementedException(); // Cannot scan
    }
}
