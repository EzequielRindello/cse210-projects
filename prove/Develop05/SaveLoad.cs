public class SaveLoad
{
    private List<string> _file;

    public SaveLoad(List<string> file)
    {
        this._file = file;
    }

    public void DisplayList()
    {
        _file.ForEach(Console.WriteLine);
    }
}