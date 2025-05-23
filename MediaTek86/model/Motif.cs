using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    public class Motif
    {
        ///<summary>
        ///Valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="nom"></param>
        
        public Motif (int idmotif, string nom)
        {
            this.Idmotif = idmotif;
            this.Nom = nom;
        }

        public int Idmotif { get; }
        public string Nom { get; }

        ///<summary>
        ///Définit l'information à retourner (ici juste le nom du motif)
        /// </summary>
        /// <retunrs>nom du motif</retunrs>

        public override string ToString()
        {
            return this.Nom;
        }
    }

}
