using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace GESTIONSCOLAIRE_EXAMEN
{

    public class ProfesseursMatières
    {
        [Key]
        public int IdProfesseur { get; set; }  // Clé étrangère vers Professeurs
        public Professeur Professeur { get; set; }

        public int IdMatière { get; set; }  // Clé étrangère vers Matière
        public Matière Matière { get; set; }
    }

}
