using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GESTIONSCOLAIRE_EXAMEN.Etudiant;

namespace GESTIONSCOLAIRE_EXAMEN
{


    public class Classe
    {
        public int Id { get; set; }  // Clé primaire
        public string NomClasse { get; set; }

        // Liste des étudiants associés à cette classe
        public ICollection<Etudiant> Etudiants { get; set; }

        // Liste des cours associés à cette classe via la table de liaison
        public ICollection<ClassesCours> ClassesCours { get; set; }

        // Liste des professeurs associés à cette classe via la table de liaison
        public ICollection<ProfesseursClasses> ProfesseursClasses { get; set; }
    }


}

