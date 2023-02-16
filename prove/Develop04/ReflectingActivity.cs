public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private string _ramdomPromp;
    private string _randomQuestion;

    public ReflectingActivity(string name, string description, int duration, List<string> promps, List<string> questions) :
        base(name, description, duration)
    {
        _prompts = promps;
        _questions = questions;
    }
    public void GetRandomPrompt()
    {

    }
    public void GetRandomQuestion()
    {

    }

}