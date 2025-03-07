using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static GESTIONSCOLAIRE_EXAMEN.Classe;
using static GESTIONSCOLAIRE_EXAMEN.Note;

namespace GESTIONSCOLAIRE_EXAMEN
{



    public class Etudiant
    {
        public int Id { get; set; }  // Clé primaire
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Sexe { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        // Clé étrangère vers la classe
        public int IdClasse { get; set; }
        
    }




}

