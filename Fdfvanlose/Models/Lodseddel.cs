namespace Fdfvanlose.Models
{
    public class Lodseddel
    {
        private int nummer { get; set; }
        private Børnegruppe gruppe { get; set; }
        private bool erSolgt { get; set; }

        public void tilknytBetaling(Betaling betaling)
        {
            // Implementering her
        }
    }

}
