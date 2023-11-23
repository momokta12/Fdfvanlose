namespace Fdfvanlose.Models
{
    public class Leder
    {
        private string navn { get; set; }
        private List<Børnegruppe> grupper = new List<Børnegruppe>();

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