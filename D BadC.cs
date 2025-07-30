public class EmailSender {
    public void Send(string message) {
        Console.WriteLine("Sending email: " + message);
    }
}

public class UserService {
    private EmailSender _emailSender = new EmailSender();

    public void NotifyUser(string msg) {
        _emailSender.Send(msg);
    }
}
