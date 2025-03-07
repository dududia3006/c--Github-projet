using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GESTIONSCOLAIRE_EXAMEN.Etudiant;
using static GESTIONSCOLAIRE_EXAMEN.Matière;

namespace GESTIONSCOLAIRE_EXAMEN
{
    public class Note
    {
        public int Id { get; set; }  // Clé primaire
        public float Valeur { get; set; }

        // Clé étrangère vers l'étudiant
        public int IdEtudiant { get; set; }
        public Etudiant Etudiant { get; set; }  // Navigation vers l'étudiant

        // Clé étrangère vers la matière
        public int IdMatière { get; set; }
        public Matière Matière { get; set; }  // Navigation vers la matière
    }

}
