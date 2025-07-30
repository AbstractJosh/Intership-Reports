public class Bird {
    public virtual void Fly() {
        Console.WriteLine("Flying");
    }
}

public class Ostrich : Bird {
    public override void Fly() {
        throw new NotImplementedException(); // Ostriches can't fly!
    }
}
