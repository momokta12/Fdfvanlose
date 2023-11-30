namespace Fdfvanlose.Models
{
    public class Lodseddel
    {
        public int Nummer { get; set; }
        public bool ErSolgt { get; set; }
        public Børnegruppe Gruppe { get; set; }

        public void TilknytBetaling(Betaling betaling) { }
    }

}