using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTIONSCOLAIRE_EXAMEN
{

    public class Cours
    {
        public int Id { get; set; }  // Clé primaire
        public string NomCours { get; set; }
        public string Description { get; set; }

        // Liste des matières associées à ce cours
        public ICollection<CoursMatières> CoursMatières { get; set; }

        // Liste des classes associées à ce cours via la table de liaison
        public ICollection<ClassesCours> ClassesCours { get; set; }
    }


}
