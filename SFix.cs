public class UserService {
    private readonly Logger _logger = new Logger();

    public void Register(string username) {
        Console.WriteLine("User registered.");
        _logger.Log("User registered: " + username);
    }
}

public class Logger {
    public void Log(string message) {
        File.WriteAllText("log.txt", message);
    }
}
