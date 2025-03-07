using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GESTIONSCOLAIRE_EXAMEN.OTPCodes;

namespace GESTIONSCOLAIRE_EXAMEN
{
    public class Utilisateur
    {
        public int Id { get; set; }  // Clé primaire
        public string NomUtilisateur { get; set; }
        public string MotDePasse { get; set; }
        public string Role { get; set; }  // "Administrateur", "DE", "Agent", "Professeur"
        public string Telephone { get; set; }

        // Relation A2F via table OTP
        public ICollection<OTPCodes> OTPCodes { get; set; }
    }

}
