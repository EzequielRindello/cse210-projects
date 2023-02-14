public class Car
{
    private string _model="";
    private string _name="";
    private int _year=0;
    public Car(string a, string b, int c)
    {
        _model = a;
        _name = b;
        _year = c;
    }
    public string GetModel()
    {
        return _model;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetYear()
    {
        return _year;
    }

    public string GetCarInfo()
    {
        return $"{_model} {_name} {_year}";
    }
} 