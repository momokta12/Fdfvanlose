namespace Fdfvanlose.Models
{
    public class Børnegruppe
    {
        public string Navn { get; set; }
        public List<Barn> Børn { get; set; }

        public void TilføjLodseddel(Lodseddel lodseddel) { }
        public void FjernLodseddel(Lodseddel lodseddel) { }
        public void TilføjBarn(Barn barn) { }
    }

}

