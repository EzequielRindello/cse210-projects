public class Fiat:Car
{
    private string _info;
    private string _page;
    public Fiat(string model, string name,int year,string info,string page): base(model, name,year)
    {
        // Here we set the MathAssignment specific variables
        _info=info;
        _page=page;
    }
    public string DisplayFiatInfo()
    {
        return $"{_info} {_page}";
    }
}