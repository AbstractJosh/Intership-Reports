public class Document {
    public string Content;
    public Document Copy() {
        var doc = new Document();
        doc.Content = this.Content; // manual, error-prone
        return doc;
    }
}
