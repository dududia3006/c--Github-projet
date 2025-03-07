namespace GESTIONSCOLAIRE_EXAMEN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class examenmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomClasse = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClassesCours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUtilisateur = c.Int(nullable: false),
                        Code = c.String(),
                        DateExpiration = c.DateTime(nullable: false),
                        Utilisateur_Id = c.Int(),
                        Classe_Id = c.Int(),
                        Cours_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilisateurs", t => t.Utilisateur_Id)
                .ForeignKey("dbo.Classes", t => t.Classe_Id)
                .ForeignKey("dbo.Cours", t => t.Cours_Id)
                .Index(t => t.Utilisateur_Id)
                .Index(t => t.Classe_Id)
                .Index(t => t.Cours_Id);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomUtilisateur = c.String(),
                        MotDePasse = c.String(),
                        Role = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OTPCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUtilisateur = c.Int(nullable: false),
                        Code = c.String(),
                        DateExpiration = c.DateTime(nullable: false),
                        Utilisateur_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilisateurs", t => t.Utilisateur_Id)
                .Index(t => t.Utilisateur_Id);
            
            CreateTable(
                "dbo.Etudiants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Matricule = c.String(),
                        Nom = c.String(),
                        Prenom = c.String(),
                        DateNaissance = c.DateTime(nullable: false),
                        Sexe = c.String(),
                        Adresse = c.String(),
                        Telephone = c.String(),
                        Email = c.String(),
                        IdClasse = c.Int(nullable: false),
                        Classe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Classe_Id)
                .Index(t => t.Classe_Id);
            
            CreateTable(
                "dbo.ProfesseursClasses",
                c => new
                    {
                        IdProfesseur = c.Int(nullable: false, identity: true),
                        IdClasse = c.Int(nullable: false),
                        Classe_Id = c.Int(),
                        Professeur_Id = c.Int(),
                    })
                .PrimaryKey(t => t.IdProfesseur)
                .ForeignKey("dbo.Classes", t => t.Classe_Id)
                .ForeignKey("dbo.Professeurs", t => t.Professeur_Id)
                .Index(t => t.Classe_Id)
                .Index(t => t.Professeur_Id);
            
            CreateTable(
                "dbo.Professeurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Email = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProfesseursMatières",
                c => new
                    {
                        IdProfesseur = c.Int(nullable: false, identity: true),
                        IdMatière = c.Int(nullable: false),
                        Matière_Id = c.Int(),
                        Professeur_Id = c.Int(),
                    })
                .PrimaryKey(t => t.IdProfesseur)
                .ForeignKey("dbo.Matière", t => t.Matière_Id)
                .ForeignKey("dbo.Professeurs", t => t.Professeur_Id)
                .Index(t => t.Matière_Id)
                .Index(t => t.Professeur_Id);
            
            CreateTable(
                "dbo.Matière",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomMatière = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CoursMatières",
                c => new
                    {
                        IdCours = c.Int(nullable: false, identity: true),
                        IdMatière = c.Int(nullable: false),
                        Cours_Id = c.Int(),
                        Matière_Id = c.Int(),
                    })
                .PrimaryKey(t => t.IdCours)
                .ForeignKey("dbo.Cours", t => t.Cours_Id)
                .ForeignKey("dbo.Matière", t => t.Matière_Id)
                .Index(t => t.Cours_Id)
                .Index(t => t.Matière_Id);
            
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomCours = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valeur = c.Single(nullable: false),
                        IdEtudiant = c.Int(nullable: false),
                        IdMatière = c.Int(nullable: false),
                        Etudiant_Id = c.Int(),
                        Matière_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Etudiants", t => t.Etudiant_Id)
                .ForeignKey("dbo.Matière", t => t.Matière_Id)
                .Index(t => t.Etudiant_Id)
                .Index(t => t.Matière_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notes", "Matière_Id", "dbo.Matière");
            DropForeignKey("dbo.Notes", "Etudiant_Id", "dbo.Etudiants");
            DropForeignKey("dbo.ProfesseursMatières", "Professeur_Id", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseursMatières", "Matière_Id", "dbo.Matière");
            DropForeignKey("dbo.CoursMatières", "Matière_Id", "dbo.Matière");
            DropForeignKey("dbo.CoursMatières", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.ClassesCours", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.ProfesseursClasses", "Professeur_Id", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseursClasses", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.Etudiants", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.ClassesCours", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.ClassesCours", "Utilisateur_Id", "dbo.Utilisateurs");
            DropForeignKey("dbo.OTPCodes", "Utilisateur_Id", "dbo.Utilisateurs");
            DropIndex("dbo.Notes", new[] { "Matière_Id" });
            DropIndex("dbo.Notes", new[] { "Etudiant_Id" });
            DropIndex("dbo.CoursMatières", new[] { "Matière_Id" });
            DropIndex("dbo.CoursMatières", new[] { "Cours_Id" });
            DropIndex("dbo.ProfesseursMatières", new[] { "Professeur_Id" });
            DropIndex("dbo.ProfesseursMatières", new[] { "Matière_Id" });
            DropIndex("dbo.ProfesseursClasses", new[] { "Professeur_Id" });
            DropIndex("dbo.ProfesseursClasses", new[] { "Classe_Id" });
            DropIndex("dbo.Etudiants", new[] { "Classe_Id" });
            DropIndex("dbo.OTPCodes", new[] { "Utilisateur_Id" });
            DropIndex("dbo.ClassesCours", new[] { "Cours_Id" });
            DropIndex("dbo.ClassesCours", new[] { "Classe_Id" });
            DropIndex("dbo.ClassesCours", new[] { "Utilisateur_Id" });
            DropTable("dbo.Notes");
            DropTable("dbo.Cours");
            DropTable("dbo.CoursMatières");
            DropTable("dbo.Matière");
            DropTable("dbo.ProfesseursMatières");
            DropTable("dbo.Professeurs");
            DropTable("dbo.ProfesseursClasses");
            DropTable("dbo.Etudiants");
            DropTable("dbo.OTPCodes");
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.ClassesCours");
            DropTable("dbo.Classes");
        }
    }
}
