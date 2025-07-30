public class Car {
    public string Engine;
    public int Wheels;
    public bool Sunroof;

    private Car() { }

    public class Builder {
        private Car _car = new Car();

        public Builder SetEngine(string engine) {
            _car.Engine = engine;
            return this;
        }

        public Builder SetWheels(int wheels) {
            _car.Wheels = wheels;
            return this;
        }

        public Builder AddSunroof(bool hasSunroof) {
            _car.Sunroof = hasSunroof;
            return this;
        }

        public Car Build() => _car;
    }
}
