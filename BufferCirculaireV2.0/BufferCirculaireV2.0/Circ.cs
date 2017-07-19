using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufferCirculaireV2._0
{
    class Circ
    {
        /* Attributs */
        int iNbCaractere = 6;
        char[] strBufferCirculaire;
        int iIndexGet = 0;
        int iIndexPut = 0;

        /* Constructeurs */

        public Circ()
        {

        }

        public Circ(int c_iNbCaractere)
        {
            iNbCaractere = c_iNbCaractere + 1;
            if (c_iNbCaractere >= 5 && c_iNbCaractere <= 20)
            {
                strBufferCirculaire = new char[iNbCaractere];
            }
        }

        /* Fonctions */

        public bool Put(char p_cCaractere)
        {
            char c = p_cCaractere;
            if (iIndexPut == iNbCaractere - 1)
            {
                if (iIndexGet == 0)
                {
                    return false;
                    // Buffer Plein
                }
                else
                {
                    iIndexPut = 0;
                    strBufferCirculaire[iIndexPut] = p_cCaractere;
                    return true;
                }
            }
            else
                if (iIndexPut == iIndexGet - 1)
                {
                    return false;
                    // Buffer Plein
                }
                else
                {
                    iIndexPut++;
                    strBufferCirculaire[iIndexPut] = p_cCaractere;
                    return true;
                }
        }

        public char Get()
        {
            char c;
            if(iIndexGet == iIndexPut)
            {
                c = '\0';
                return c;
                // Buffer Vide
            }
            else
            {
                if(iIndexGet == iNbCaractere - 1)
                {
                    iIndexGet = 0;
                    c = strBufferCirculaire[iIndexGet];
                    return c;
                    // Buffer Vide
                }
                else
                {
                    iIndexGet++;
                    c = strBufferCirculaire[iIndexGet];
                    return c;
                }
            }
        }
    }
}