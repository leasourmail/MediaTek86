using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les absences
    /// </summary>
    public class AbsenceAccess
    {
        ///<summary>
        ///Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        ///<summary>
        ///Constructeur pour créer l'accès aux données
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les absences du personnel sélectionné du plus récent au plus ancien
        /// </summary>
        /// <returns>liste des absences</returns>
        public List<Absence> GetLesAbsences(string nomPersonnel = "", string prenomPersonnel = "")
        {
            List<Absence> lesAbsences = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "select a.idpersonnel as idpersonnel, a.datedebut as datedebut, a.datefin as datefin, m.idmotif as idmotif, m.nom as nom ";
                req += "from absence a join motif m on (a.idmotif = m.idmotif) join personnel p on (a.idpersonnel = p.idpersonnel) ";
                req += $"where p.nom = '{nomPersonnel}' and p.prenom = '{prenomPersonnel}'";
                req += "order by a.datedebut DESC;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Motif motif = new Motif((int)record[3], (string)record[4]);
                            Absence absence = new Absence((int)record[0], (DateTime)record[1], (DateTime)record[2], motif);
                            lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }
    }
}

