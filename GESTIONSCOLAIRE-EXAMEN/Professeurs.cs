using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTIONSCOLAIRE_EXAMEN
{
    public class Professeur
    {
        public int Id { get; set; }  // Clé primaire
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        // Liste des matières enseignées par ce professeur via la table de liaison
        public ICollection<ProfesseursMatières> ProfesseursMatières { get; set; }

        // Liste des classes auxquelles ce professeur enseigne via la table de liaison
        public ICollection<ProfesseursClasses> ProfesseursClasses { get; set; }
    }

}
