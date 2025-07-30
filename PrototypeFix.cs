public class Document : ICloneable {
    public string Content;

    public object Clone() {
        return this.MemberwiseClone();
    }
}
