namespace Fdfvanlose.Models
{
    public class Lotteribestyrer
    {
        public string Navn { get; set; }

        public Børnegruppe OpretBørnegruppe(string navn) { return null; }
        public void FjernBørnegruppe(Børnegruppe gruppe) { }
        public void TilføjBarnTilGruppe(Børnegruppe gruppe, Barn barn) { }
    }
}