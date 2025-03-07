using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GESTIONSCOLAIRE_EXAMEN
{
    public class CoursMatières
    {
        [Key]
        public int IdCours { get; set; }  // Clé étrangère vers Cours
        public Cours Cours { get; set; }

        public int IdMatière { get; set; }  // Clé étrangère vers Matière
        public Matière Matière { get; set; }
    }

}
