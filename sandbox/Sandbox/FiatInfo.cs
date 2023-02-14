public class FiatInfo:Car
{
    private string _hayquedefinirquehacelaclase; // pasar un txt con info y la pagina oficial de fiat
    private string _hayquedefinirquehacelaclase2;

    public FiatInfo(string name,string model,int year,string hayquedefinirquehacelaclase) : base(name,model,year)
    {
        _hayquedefinirquehacelaclase=hayquedefinirquehacelaclase;
    }


    //el comportamiento de esta clase podria ser display the text especifico de aca
}