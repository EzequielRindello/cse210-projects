public class PeugeotInfo : Car
{
    private string _hayquedefinirquehacelaclase;  // pasar un txt con info y la pagina oficial de peogueot

    public PeugeotInfo(string name, string model, int year, string hayquedefinirquehacelaclase) : base(name, model, year)
    {
        _model = "XR 1.8";
        _year = 1998;
        _name = "Peugeot 306";
        _hayquedefinirquehacelaclase = hayquedefinirquehacelaclase;
    }

    //el comportamiento de esta clase podria ser display the text especifico de aca
}