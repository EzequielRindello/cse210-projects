public class Car
{
    private string _name="";
    private string _model="";
    private int _year=0;
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name=name;
    }
    public string GetModel()
    {
        return _model;
    }
    public void SetModel(string model)
    {
        _model=model;
    }

    public int GetYear()
    {
        return _year;
    }
    public void SetYear(int year)
    {
        _year=year;
    }

    public string GetCarInfo()
    {
        return $"{_name} {_model} {_year}";
    }
} 