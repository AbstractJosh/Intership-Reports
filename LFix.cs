public abstract class Bird { }

public interface IFlyingBird {
    void Fly();
}

public class Sparrow : Bird, IFlyingBird {
    public void Fly() {
        Console.WriteLine("Flying");
    }
}

public class Ostrich : Bird {
    // Does not implement IFlyingBird
}
