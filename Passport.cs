using System.Collections.Generic;
public class Passport
{
    public List<BalkaNadressornaya> Balki {get;set;}
    public List<KolesnayaPara> KolesnayaPara {get;set;}
    public List<RamaBokovaya> RamaBokovaya{get;set;}
    public string Number;

    public Passport()
    {
        Balki =  new List<BalkaNadressornaya>();
        KolesnayaPara = new List<KolesnayaPara>();
        RamaBokovaya = new List<RamaBokovaya>();
    }
    
}