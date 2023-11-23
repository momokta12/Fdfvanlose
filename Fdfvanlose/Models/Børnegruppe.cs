namespace Fdfvanlose.Models
{
    public class Børnegruppe
    {
        private string navn { get; set; }
        private List<Lodseddel> lodsedler = new List<Lodseddel>();
        private List<Barn> børn = new List<Barn>();

        public void tilføjLodseddel(Lodseddel lodseddel)
        {
            // Implementering her
        }

        public void fjernLodseddel(Lodseddel lodseddel)
        {
            // Implementering her
        }

        public void tilføjBarn(Barn barn)
        {
            // Implementering her
        }
    }

}
