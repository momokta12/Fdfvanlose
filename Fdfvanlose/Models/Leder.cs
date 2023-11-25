namespace Fdfvanlose.Models
{
    public class Leder
    {
        private string navn { get; set; }
        private List<Børnegruppe> grupper = new List<Børnegruppe>();

        //referer til 1.userstory
        public void VisGruuppe(Børnegruppe gruppe) 
        {
            // Implementering her 
        }
        public void tilføjGruppe(Børnegruppe gruppe)
        {
            // Implementering her
        }

        public void fjernGruppe(Børnegruppe gruppe)
        {
            // Implementering her
        }

        public void registrerLodsedler(Børnegruppe gruppe, Barn barn, int antal)
        {
            // Implementering her
        }
    }

}