public class FiatInfo : Car
{
    private string _hayquedefinirquehacelaclase; // pasar un txt con info y la pagina oficial de fiat

    public FiatInfo(string name, string model, int year, string hayquedefinirquehacelaclase) : base(name, model, year)
    {
        _model = "Spazio TR 1.3";
        _year = 1988;
        _name = "Fiat 147";
        _hayquedefinirquehacelaclase = hayquedefinirquehacelaclase;
    }


    //el comportamiento de esta clase podria ser display the text especifico de aca
}