using Microsoft.AspNetCore.Identity;
using System.Data;

namespace Fdfvanlose.Models
{
    public class Bruger
    {
        private string brugernavn { get; set; }
        private string kodeord { get; set; }
        private Role rolle { get; set; }

        public void logInd()
        {
            // Implementering her
        }

        public void logUd()
        {
            // Implementering her
        }
    }

}
