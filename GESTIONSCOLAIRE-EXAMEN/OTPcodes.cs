﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GESTIONSCOLAIRE_EXAMEN.Utilisateur;

namespace GESTIONSCOLAIRE_EXAMEN
{
    public class OTPCodes
    {
        public int Id { get; set; }  // Clé primaire
        public int IdUtilisateur { get; set; }  // Clé étrangère vers Utilisateur
        public Utilisateur Utilisateur { get; set; }  // Navigation vers Utilisateur
        public string Code { get; set; }
        public DateTime DateExpiration { get; set; }
    }

}
