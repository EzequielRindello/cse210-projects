public class Car
{
    protected string _name;
    protected string _model;
    protected int _year;

    public Car(string a,string b,int c)
    {
        _name=a;
        _model=b;
        _year=c;
    }
   
    public string GetCarInfo()
    {
        return $"{_name} {_model} {_year}";
    }
    
} 