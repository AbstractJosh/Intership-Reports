public class UserService {
    public void Register(string username) {
        // Save user logic
        Console.WriteLine("User registered.");

        // Log to file
        File.WriteAllText("log.txt", "User registered: " + username);
    }
}
