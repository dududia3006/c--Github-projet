using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace GESTIONSCOLAIRE_EXAMEN
{
    public class ProfesseursClasses

    {
        [Key]
        public int IdProfesseur { get; set; }  // Clé étrangère vers Professeurs
        public Professeur Professeur { get; set; }

        public int IdClasse { get; set; }  // Clé étrangère vers Classes
        public Classe Classe { get; set; }
    }

}
