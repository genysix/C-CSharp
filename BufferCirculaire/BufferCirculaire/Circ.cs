using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufferCirculaire
{
    class Circ
    {
        /* Attributs */
        public int iNbCaractere = 7;
        public char[] strTableau;
        int iIndexGET = 0;
        int iIndexPUT = 0;
        /* Constructeurs */
        public Circ()
        {
            // Création d'un tableau de 10 caractères
            strTableau = new char[iNbCaractere];
        }

        public Circ(int c_iNbCaractere)
        {
            // Création d'un tableau de x caractères
            iNbCaractere = c_iNbCaractere + 1;
            if(iNbCaractere >= 5 && iNbCaractere <= 20)
            {
                strTableau = new char[iNbCaractere];
            }
        }
        
        /* Propriétés */

        /* Méthodes */

        public bool PUT(char p_str_Caractere)
        {
            if (iIndexPUT == iNbCaractere - 1)
            {
                if (iIndexGET == 0)
                {
                    return false;
                }
                else
                {
                    iIndexPUT = 0;
                    strTableau[iIndexPUT] = p_str_Caractere;
                    return true;
                }
            }
            else
            if (iIndexGET == iIndexPUT + 1)
            {
                return false;
            }
            else // Le buffer n'est pas vide
            {
                iIndexPUT++;
                strTableau[iIndexPUT] = p_str_Caractere;
                return true;
            }            
        }

        public char GET()
        {
            char c;
            if(iIndexPUT == iIndexGET + 1)
            {
                iIndexGET++;
                c = strTableau[iIndexGET];
                return c; // Buffer Vide
            }
            else
                if(iIndexGET == iNbCaractere - 1 && iIndexPUT == 0)
                {
                iIndexGET=0;
                c = strTableau[iIndexGET];
                return c; // Buffer Vide
                }
            else
            {
                if(iIndexGET == iIndexPUT)
                {
                    c = '\0';
                    return c; // Buffer Vide
                }
                else
                {
                    if(iIndexGET == iNbCaractere - 1)
                    {
                        iIndexGET = 0;
                    }
                    else
                    {
                        iIndexGET++;
                    }
                        
                     c = strTableau[iIndexGET];
                     return c;
                    
                }
            }
        }
    }
}
