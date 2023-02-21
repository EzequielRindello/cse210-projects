public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private string _ramdomPromp;
    private string _randomQuestion;

    public ReflectingActivity(string name, string description, int duration, List<string> promps, List<string> questions) :
        base(name, description, duration)
    {
        _name = "Welcome to the reflecting activity.";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 40;
        _prompts = promps;
        _questions = questions;
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string ramdomPromp = _prompts[index];
        _ramdomPromp=ramdomPromp;
    }

    public void GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string ramdomquestion = _questions[index];
        _randomQuestion=ramdomquestion;
    }

}