namespace CICDPractice.Core;

public static class Greeting
{
    
    public static string Hello(string name)
    {
        return string.IsNullOrEmpty(name)
            ? "What is your name?"
            : $"Hello {name}!";
    }
}
