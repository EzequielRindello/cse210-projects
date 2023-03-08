public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private string _ramdomPromp;
    private string _randomQuestion;

    public ReflectingActivity(string name, string description, List<string> promps, List<string> questions) :
        base(name, description)
    {
        _name = "Reflecting activity.";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = promps;
        _questions = questions;
    }

    public void RunReflectingActivity()
    {
        Console.Clear();
        GetRandomPrompt();
        DisplayPromp();
        Console.WriteLine("Now ponder on each of the following as they related to this experience...");
        Timer();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            GetRandomQuestion();
            DisplayQuestion();
            PauseSpinner();
        }
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string ramdomPromp = _prompts[index];
        _ramdomPromp = ramdomPromp;
    }

    public void GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string ramdomquestion = _questions[index];
        _randomQuestion = ramdomquestion;
    }

    public void DisplayPromp()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following promp: ");
        Console.WriteLine($"--- {_ramdomPromp} ---");
        Console.WriteLine("When you have somethig in your mind enter any key to continue.");
        Console.ReadKey();
    }

    public void DisplayQuestion()
    {
        Console.Write($"> {_randomQuestion} ");
        Console.WriteLine();
    }

}