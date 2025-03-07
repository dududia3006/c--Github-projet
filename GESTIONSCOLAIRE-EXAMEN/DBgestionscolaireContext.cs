using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GESTIONSCOLAIRE_EXAMEN.Cours;
using static GESTIONSCOLAIRE_EXAMEN.Etudiant;
using static GESTIONSCOLAIRE_EXAMEN.Matière;
using static GESTIONSCOLAIRE_EXAMEN.Note;
using static GESTIONSCOLAIRE_EXAMEN.Professeur;
using static GESTIONSCOLAIRE_EXAMEN.Utilisateur;

namespace GESTIONSCOLAIRE_EXAMEN
{
    internal class DBgestionscolaireContext : DbContext

    {
        public DBgestionscolaireContext() : base("ExamenL3GLConnect")
        {


        }
        // DbSets pour chaque entité (tables dans la base de données)
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Matière> Matières { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<OTPCodes> OTPCodes { get; set; }

        // Tables de liaison pour les relations N:N
        public DbSet<ClassesCours> ClassesCours { get; set; }
        public DbSet<CoursMatières> CoursMatières { get; set; }
        public DbSet<ProfesseursMatières> ProfesseursMatières { get; set; }
        public DbSet<ProfesseursClasses> ProfesseursClasses { get; set; }







    }
    }
