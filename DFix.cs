public interface IMessageSender {
    void Send(string message);
}

public class EmailSender : IMessageSender {
    public void Send(string message) {
        Console.WriteLine("Sending email: " + message);
    }
}

public class UserService {
    private readonly IMessageSender _messageSender;

    public UserService(IMessageSender sender) {
        _messageSender = sender;
    }

    public void NotifyUser(string msg) {
        _messageSender.Send(msg);
    }
}
