public interface IPrinter {
    void Print();
}

public interface IScanner {
    void Scan();
}

public class SimplePrinter : IPrinter {
    public void Print() {
        Console.WriteLine("Printing...");
    }
}
