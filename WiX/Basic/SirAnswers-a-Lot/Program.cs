// See https://aka.ms/new-console-template for more information
string[] answerPool = {
    "Yes",
    "No",
    "Maybe",
    "Definitely",
    "Nope"
};

Console.WriteLine("Greetings, curious mortal!");
Thread.Sleep(1500); // Delay 1.5 seconds

Console.WriteLine("I am Sir Answers-a-lot, keeper of knowledge, slayer of ignorance, and whisperer of universal truths.");
Thread.Sleep(2000); // Delay 2 seconds

Console.WriteLine("Ask me thy question, noble traveler, and I shall respond with the wisdom of a thousand stars!");
Thread.Sleep(1000); // Delay 1 second

while (true)
{
    Console.Write("Type your question here: ");
    string question = Console.ReadLine() ?? "";
    Console.Clear();
    if (question.Equals("Ok", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Ah, you wish to end this session. Farewell, seeker of knowledge!");
        Thread.Sleep(1500); // Delay 1.5 second
        break;
    }
    if (string.IsNullOrWhiteSpace(question))
    {
        Console.WriteLine("Ah, silence speaks volumes! I can't answer a question that isn't asked.");
        Thread.Sleep(1000); // Delay 1 second
        Console.WriteLine("Try again, brave seeker of knowledge.");
        Thread.Sleep(1000); // Delay 1 second
    }
    else
    {
        Console.WriteLine($"Ah, you seek answers to: '{question}'");
        Thread.Sleep(1000); // Delay 1 second
        Console.WriteLine("Let me consult the cosmic database of knowledge...");
        Thread.Sleep(2000); // Delay 2 seconds
        Random random = new Random();
        int index = random.Next(answerPool.Length);
        Console.WriteLine($"The answer to your question is: '{answerPool[index]}'");
        Thread.Sleep(1500); // Delay 1.5 seconds
        Console.WriteLine("If you wish to ask another question, type it now. If you wish to end this session, type 'Ok'.");
    }
}
