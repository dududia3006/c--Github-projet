using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTIONSCOLAIRE_EXAMEN
{
    public class Matière
    {
        public int Id { get; set; }  // Clé primaire
        public string NomMatière { get; set; }

        // Liste des cours associés à cette matière via la table de liaison
        public ICollection<CoursMatières> CoursMatières { get; set; }

        // Liste des professeurs associés à cette matière via la table de liaison
        public ICollection<ProfesseursMatières> ProfesseursMatières { get; set; }
    }


}
