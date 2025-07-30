public interface ISubscriber {
    void Update(string news);
}

public class EmailSubscriber : ISubscriber {
    public void Update(string news) {
        Console.WriteLine("Email: " + news);
    }
}

public class SmsSubscriber : ISubscriber {
    public void Update(string news) {
        Console.WriteLine("SMS: " + news);
    }
}

public class NewsPublisher {
    private List<ISubscriber> _subscribers = new List<ISubscriber>();

    public void Subscribe(ISubscriber subscriber) {
        _subscribers.Add(subscriber);
    }

    public void Publish(string news) {
        foreach (var sub in _subscribers) {
            sub.Update(news);
        }
    }
}
