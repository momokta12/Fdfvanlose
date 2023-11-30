using Microsoft.AspNetCore.Identity;
using System.Data;

namespace Fdfvanlose.Models
{
    public class Bruger
    {
        private string Brugernavn { get; set; }
        private string Kodeord { get; set; }
        private Role Rolle { get; set; }

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
