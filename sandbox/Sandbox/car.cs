public class Car
{
    protected string _name="";
    protected string _model="";
    protected int _year=0;
  
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
    
    /* 
    public Car(string a,string b,int c)
    {
        _name=a;
        _model=b;
        _year=c;
    }
    */
    public string GetCarInfo()
    {
        return $"{_name} {_model} {_year}";
    }
} 