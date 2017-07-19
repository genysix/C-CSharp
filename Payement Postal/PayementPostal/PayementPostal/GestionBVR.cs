using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayementPostal
{
    class GestionBVR /* Vérifie l'intégrité des données du bulletin de versement */
    {
        /* Constructeurs */

        /* Attributs */
        bool bValide;
        int[,] Modulo10 = new int[10, 11]
            {
                {0,9,4,6,8,2,7,1,3,5,0},
                {9,4,6,8,2,7,1,3,5,0,9},
                {4,6,8,2,7,1,3,5,0,9,8},
                {6,8,2,7,1,3,5,0,9,4,7},
                {8,2,7,1,3,5,0,9,4,6,6},
                {2,7,1,3,5,0,9,4,6,8,5},
                {7,1,3,5,0,9,4,6,8,2,4},
                {1,3,5,0,9,4,6,8,2,7,3},
                {3,5,0,9,4,6,8,2,7,1,2},
                {5,0,9,4,6,8,2,7,1,3,1},
            };
        /* Propriétées */

        /* Méthodes */

        public bool NumeroAdherent(string strNumeroAdherent)
        {
            
            string strCodeBVR = "";
            string strPremierTiret = "";
            string strDeuxiemeTiret = "";
            int iNbNumeroOrdre = 0;
            int iNbNumeroOrdreRajout = 0;

            /* Contrôle le VV du compte */
            strCodeBVR += strNumeroAdherent.Substring(0, 2);
            /*if(strCodeBVR == "01")
            {
                bValide = true;
            }
            else
            {
                return false;
            }
            */
            /* Remplissage des Numéros d'ordres  */
            for (int i = 3; i < strNumeroAdherent.Length - 2; i++)
            {
                iNbNumeroOrdre++;
            }
            if(iNbNumeroOrdre >= 3 && iNbNumeroOrdre <= 6)
            {
                iNbNumeroOrdreRajout = 6 - iNbNumeroOrdre;
                for (int i = 0; i < iNbNumeroOrdreRajout; i++)
                {
                    strNumeroAdherent = strNumeroAdherent.Insert(3 + i, "0");
                }
                bValide = true;
            }
            else
            {
                return false;
            }
            

            /* Contrôle des tirets en position 3 et 10 */
            strPremierTiret = strNumeroAdherent.Substring(2, 1);
            strDeuxiemeTiret = strNumeroAdherent.Substring(9, 1);
            if (strPremierTiret == "-" && strDeuxiemeTiret == "-")
            {
                bValide = true;
            }
            else
            {
                return false;
            }

            /* Vérification selon le modulo 10 */
            /* Tableau de relation du modulo 10 */
            int iIndiceHaut = 0;
            int iIndiceGauche = 0;
            int iChiffreClef = 0;
            string strNumAdherentSansTiret = strNumeroAdherent.Remove(2, 1);
            strNumAdherentSansTiret = strNumAdherentSansTiret.Remove(8, 2);

            foreach (char c in strNumAdherentSansTiret)
            {
                if(c >= 48 && c <= 57 )
                {
                    bValide = true;
                }
                else
                {
                    return false;
                }
            }

            for (int i = 0; i < strNumAdherentSansTiret.Length; i++) // Parcours tout les charactère du numéro de compte
            {
                iIndiceHaut = Convert.ToInt32(strNumAdherentSansTiret[i] - 48); // Récupération de l'indice à partir de la valeur du numéro de compte
                iIndiceGauche = Modulo10[iIndiceGauche, iIndiceHaut];
            }
            iChiffreClef = Modulo10[iIndiceGauche, 10];
            if (iChiffreClef == (int)strNumeroAdherent[10] - 48)
            {
                bValide = true;
            }
            else
            {
                return false;
            }
            return bValide;
        }

        public bool NumeroReference(string strNumeroReference)
        {
            int iIndiceHaut = 0;
            int iIndiceGauche = 0;
            int iChiffreClef = 0;
            int iNbCaractère = 0;
            int iNbZeroRajout = 0;
            /* Test si tout les caractères sont des chiffres */
            foreach (char c in strNumeroReference)
            {
                if (c >= 48 && c <= 57)
                {
                    bValide = true;

                }
                else
                {
                    return false;
                }
            }

            iNbCaractère = strNumeroReference.Length;
            iNbZeroRajout = 26 - iNbCaractère;
            /* Rajoute les caractères 0 jusqu'à l'obtention d'une chaine de 26 caractères */
            for (int i = 0; i < iNbZeroRajout; i++)
            {
                strNumeroReference = strNumeroReference.Insert(0 + i, "0"); // Position relative de départ 0 (début de la chaine)
            }

            /* Check si le dernier nombre est conforme au modulo 10 */
            
            string strNumeroReferenceModulo10 = "";
            /* Récupère toute la chaine sans le dernier chiffre*/
            strNumeroReferenceModulo10 = strNumeroReference.Substring(0, strNumeroReference.Length - 1);

            for (int i = 0; i < strNumeroReferenceModulo10.Length; i++) // Parcours tout les charactère du numéro de compte
            {
                iIndiceHaut = Convert.ToInt32(strNumeroReferenceModulo10[i] - 48); // Récupération de l'indice à partir de la valeur du numéro de compte
                iIndiceGauche = Modulo10[iIndiceGauche, iIndiceHaut];
            }
            iChiffreClef = Modulo10[iIndiceGauche, 10];
            if (iChiffreClef == (int)strNumeroReference[25] - 48)
            {
                bValide = true;
            }
            else
            {
                return false;
            }
            return bValide;
        }

        public bool Montant(string strMontant)
        {
            /* Vérifie si le montant est de type double */
            double Montant;
            if (Double.TryParse(strMontant, out Montant))
            {
                bValide = true;
            }
            else
            {
                return false;
            }
            return bValide;
        }


    }
}
