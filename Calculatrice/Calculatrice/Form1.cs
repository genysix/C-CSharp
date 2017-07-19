using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        private class EvaluationExpr
        {
            private string Chaine;
            private int i = 0;
            public bool Erreur;
            public double Resultat;

            public void Calcul(string EntreeCalcul)
            {

                Chaine = EntreeCalcul;
                
                Resultat = expression();
            }

            private double expression()
            {
                double o = 0;
                bool testexpr = true;
                o = terme();
                while (i < Chaine.Length && testexpr == true)
                {
                    testexpr = false;
                    if (i < Chaine.Length && Chaine[i] == '+')
                    {
                        i++;
                        testexpr = true;
                        o = o + terme();
                    }
                    if (i < Chaine.Length && Chaine[i] == '-')
                    {
                        i++;
                        testexpr = true;
                        o = o - terme();
                    }
                }
                return o;
            }
            private double terme()
            {
                double m=0;
                bool test = true;
                m = operande();
                while (i < Chaine.Length && test==true)
                {
                    test = false;
                    if (i < Chaine.Length && Chaine[i] == '*')
                    {
                        i++;
                        test = true;
                        m = m * operande();
                    }
                    if (i < Chaine.Length && Chaine[i] == '/')
                    {
                        i++;
                        test = true;
                        m = m / operande();
                    }
                }
                return m;
            }
            private double operande()
            {
                double n = 0;

                if (i < Chaine.Length && Chaine[i] == '(')
                {
                    i++;
                    n = n + expression();
                    i++;
                }else
                {
                    n = nombre();
                }

                

                return n;
            }
            private double nombre()
            {
                double n = 0;
                if (i < Chaine.Length)
                {
                    int debut = i; do
                    {
                        i++;
                    } while (i < Chaine.Length && Chaine[i] >= '0' && Chaine[i] <= '9');
                    if (i < Chaine.Length && Chaine[i] == '.') i++;
                    while (i < Chaine.Length && Chaine[i] >= '0' && Chaine[i] <= '9') i++;
                    n = double.Parse(Chaine.Substring(debut, i - debut));
                }
                return (n);
            }
        }

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {

            EvaluationExpr Test = new EvaluationExpr();

            Test.Calcul(tbCalcul.Text);

            if (Test.Erreur == true)
            {
                MessageBox.Show("Une erreur a été detecté dans le calcul. vérifier que vous n'avez pas ajouter une lettre", "Erreur d'entrée", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                lblReponse.Text = Test.Resultat.ToString();
            }
        }

        
    }
}