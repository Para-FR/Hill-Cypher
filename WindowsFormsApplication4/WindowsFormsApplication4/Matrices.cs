using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Matrices : Form
    {
        private TextBox[,] Matrice1;
        private TextBox[,] Matrice2;
        private TextBox[,] MatriceResultante;
        private TextBox[,] Mot;
        private int determinante;

        int ligne1, colonne1;
        int ligne2, colonne2;
        public Matrices()
        {
            InitializeComponent();

        }
        #region    CreerMatrice
        private void btnCreerMatrice_Click_1(object sender, EventArgs e)
        {
            groupBoxMatrice1.Controls.Clear();
            if (!int.TryParse(textBox1.Text, out ligne1))
            {
                MessageBox.Show("La ligne de la matrice 1 est nulle", "Erreur");
                return;
            }
            if (!int.TryParse(textBox3.Text, out colonne1))
            {
                MessageBox.Show("La colonne de la matrice 1 est nulle", "Erreur");
                return;
            }

            Matrice1 = new TextBox[ligne1, colonne1];
            int Dimensions = groupBoxMatrice1.Width / colonne1;
            for (int x = 0; x < Matrice1.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice1.GetLength(1); y++)
                {
                    Matrice1[x, y] = new TextBox();
                    Matrice1[x, y].Text = "0";
                    Matrice1[x, y].Top = (x * Matrice1[x, y].Height) + 20;
                    Matrice1[x, y].Left = y * Dimensions + 6;
                    Matrice1[x, y].Width = Dimensions;
                    groupBoxMatrice1.Controls.Add(Matrice1[x, y]);
                }
            }
        }

        private void btnCreerMatrice2_Click_1(object sender, EventArgs e)
        {
            groupBoxMatrice2.Controls.Clear();
            if (!int.TryParse(textBox2.Text, out ligne2))
            {
                MessageBox.Show("La ligne de la matrice 2 est nulle", "Erreur");
                return;
            }
            if (!int.TryParse(textBox4.Text, out colonne2))
            {
                MessageBox.Show("La colonne de la matrice 2 est nulle", "Erreur");
                return;
            }

            Matrice2 = new TextBox[ligne2, colonne2];
            int Dimensions = groupBoxMatrice2.Width / colonne2;
            for (int x = 0; x < Matrice2.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice2.GetLength(1); y++)
                {
                    Matrice2[x, y] = new TextBox();
                    Matrice2[x, y].Text = "0";
                    Matrice2[x, y].Top = (x * Matrice2[x, y].Height) + 20;
                    Matrice2[x, y].Left = y * Dimensions + 6;
                    Matrice2[x, y].Width = Dimensions;
                    groupBoxMatrice2.Controls.Add(Matrice2[x, y]);
                }
            }
        }
        #endregion
        #region Operations entre matrices
        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (Matrice1 == null || Matrice2 == null)
            {
                MessageBox.Show("Matrice(s) nulle(s) !", "Erreur - Matrice(s)");
                return;
            }
            int[,] tempMatrice1 = new int[Matrice1.GetLength(0), Matrice1.GetLength(1)];
            int[,] tempMatrice2 = new int[Matrice2.GetLength(0), Matrice2.GetLength(1)];
            if (tempMatrice1.GetLength(0) != tempMatrice2.GetLength(0) || tempMatrice1.GetLength(1) != tempMatrice2.GetLength(1))
            {
                MessageBox.Show("Vous ne pouvez pas additionner deux matrices de tailles différentes", "Erreur de Dimensions");
                return;
            }
            for (int x = 0; x < Matrice1.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice1.GetLength(1); y++)
                {
                    int n = 0;
                    int.TryParse(Matrice1[x, y].Text, out n);
                    tempMatrice1[x, y] = n;
                }
            }
            for (int x = 0; x < Matrice2.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice2.GetLength(1); y++)
                {
                    int n = 0;
                    int.TryParse(Matrice2[x, y].Text, out n);
                    tempMatrice2[x, y] = n;
                }
            }

            int[,] tempMatriceResultante = CalculMatrice.AdditionnerMatrices(tempMatrice1, tempMatrice2);
            MatriceResultante = new TextBox[tempMatriceResultante.GetLength(0), tempMatriceResultante.GetLength(1)];
            int Dimensions = groupBoxMatriceResultante.Width / MatriceResultante.GetLength(1);
            groupBoxMatriceResultante.Controls.Clear();
            for (int x = 0; x < MatriceResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatriceResultante.GetLength(1); y++)
                {
                    MatriceResultante[x, y] = new TextBox();
                    MatriceResultante[x, y].Text = tempMatriceResultante[x, y].ToString();
                    MatriceResultante[x, y].Top = (x * MatriceResultante[x, y].Height) + 20;
                    MatriceResultante[x, y].Left = y * Dimensions + 6;
                    MatriceResultante[x, y].Width = Dimensions;
                    groupBoxMatriceResultante.Controls.Add(MatriceResultante[x, y]);
                }
            }
        }
        private void btnSoustraction_Click(object sender, EventArgs e)
        {
            if (Matrice1 == null || Matrice2 == null)
            {
                MessageBox.Show("Matrice(s) nulle(s) !", "Erreur - Matrice(s)");
                return;
            }
            int[,] tempMatrice1 = new int[Matrice1.GetLength(0), Matrice1.GetLength(1)];
            int[,] tempMatrice2 = new int[Matrice2.GetLength(0), Matrice2.GetLength(1)];
            if (tempMatrice1.GetLength(0) != tempMatrice2.GetLength(0) || tempMatrice1.GetLength(1) != tempMatrice2.GetLength(1))
            {
                MessageBox.Show("Vous ne pouvez pas soustraire deux matrices de tailles différentes", "Erreur de Dimensions");
                return;
            }
            for (int x = 0; x < Matrice1.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice1.GetLength(1); y++)
                {
                    int n = 0;
                    int.TryParse(Matrice1[x, y].Text, out n);
                    tempMatrice1[x, y] = n;
                }
            }
            for (int x = 0; x < Matrice2.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice2.GetLength(1); y++)
                {
                    int n = 0;
                    int.TryParse(Matrice2[x, y].Text, out n);
                    tempMatrice2[x, y] = n;
                }
            }
            int[,] tempMatriceResultante = CalculMatrice.SoustraireMatrice(tempMatrice1, tempMatrice2);
            MatriceResultante = new TextBox[tempMatriceResultante.GetLength(0), tempMatriceResultante.GetLength(1)];
            int Dimensions = groupBoxMatriceResultante.Width / MatriceResultante.GetLength(1);
            groupBoxMatriceResultante.Controls.Clear();
            for (int x = 0; x < MatriceResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatriceResultante.GetLength(1); y++)
                {
                    MatriceResultante[x, y] = new TextBox();
                    MatriceResultante[x, y].Text = tempMatriceResultante[x, y].ToString();
                    MatriceResultante[x, y].Top = (x * MatriceResultante[x, y].Height) + 20;
                    MatriceResultante[x, y].Left = y * Dimensions + 6;
                    MatriceResultante[x, y].Width = Dimensions;
                    groupBoxMatriceResultante.Controls.Add(MatriceResultante[x, y]);
                }
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (Matrice1 == null || Matrice2 == null)
            {
                MessageBox.Show("Matrice(s) nulle(s) !", "Erreur - Matrice(s)");
                return;
            }
            int[,] tempMatrice1 = new int[Matrice1.GetLength(0), Matrice1.GetLength(1)];
            int[,] tempMatrice2 = new int[Matrice2.GetLength(0), Matrice2.GetLength(1)];

            if (tempMatrice1.GetLength(1) != tempMatrice2.GetLength(0))
            {
                MessageBox.Show("Le nombre de colonne de la Matrice 1 doit être égal au nombre de lignes de la matrice 2", "Erreur de Dimensions");
                return;
            }

            for (int x = 0; x < Matrice1.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice1.GetLength(1); y++)
                {
                    int n = 0;
                    int.TryParse(Matrice1[x, y].Text, out n);
                    tempMatrice1[x, y] = n;
                }
            }
            for (int x = 0; x < Matrice2.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice2.GetLength(1); y++)
                {
                    int n = 0;
                    int.TryParse(Matrice2[x, y].Text, out n);
                    tempMatrice2[x, y] = n;
                }
            }

            int[,] tempMatriceResultante = CalculMatrice.MultiplierMatrice(tempMatrice1, tempMatrice2);
            MatriceResultante = new TextBox[tempMatriceResultante.GetLength(0), tempMatriceResultante.GetLength(1)];
            int Dimensions = groupBoxMatriceResultante.Width / MatriceResultante.GetLength(1);
            groupBoxMatriceResultante.Controls.Clear();
            for (int x = 0; x < MatriceResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatriceResultante.GetLength(1); y++)
                {
                    MatriceResultante[x, y] = new TextBox();
                    MatriceResultante[x, y].Text = tempMatriceResultante[x, y].ToString();
                    MatriceResultante[x, y].Top = (x * MatriceResultante[x, y].Height) + 20;
                    MatriceResultante[x, y].Left = y * Dimensions + 6;
                    MatriceResultante[x, y].Width = Dimensions;
                    groupBoxMatriceResultante.Controls.Add(MatriceResultante[x, y]);
                }
            }
        }
        #endregion
        #region Calcul Option Matrice1
        private void btnOpposeM1_Click(object sender, EventArgs e)
        {
            if (Matrice1 == null)
            {
                MessageBox.Show("Matrice Nulle", "Erreur");
                return;
            }
            int[,] tempResultante = new int[Matrice1.GetLength(0), Matrice1.GetLength(1)];
            for (int x = 0; x < Matrice1.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice1.GetLength(1); y++)
                {
                    int n = 0;
                    int.TryParse(Matrice1[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            int[,] tempMatrice1 = CalculMatrice.Oppose(tempResultante);
            int Dimensions = groupBoxMatrice1.Width / Matrice1.GetLength(1);
            for (int x = 0; x < Matrice1.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice1.GetLength(1); y++)
                {
                    Matrice1[x, y].Text = tempMatrice1[x, y].ToString();
                }
            }
        }
        private void btnTransposeM1_Click(object sender, EventArgs e)
        {
            if (Matrice1 == null)
            {
                MessageBox.Show("Matrice Nulle", "Erreur");
                return;
            }
            int[,] tempResultante = new int[Matrice1.GetLength(0), Matrice1.GetLength(1)];

            for (int x = 0; x < Matrice1.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice1.GetLength(1); y++)
                {
                    int n = 0;
                    int.TryParse(Matrice1[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }
            int[,] tempMatriceResultante = CalculMatrice.Transpose(tempResultante);

            int Dimensions = groupBoxMatrice1.Width / Matrice1.GetLength(1);
            Matrice1 = new TextBox[tempMatriceResultante.GetLength(0), tempMatriceResultante.GetLength(1)];
            groupBoxMatrice1.Controls.Clear();

            for (int x = 0; x < Matrice1.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice1.GetLength(1); y++)
                {
                    Matrice1[x, y] = new TextBox();
                    Matrice1[x, y].Text = tempMatriceResultante[x, y].ToString();
                    Matrice1[x, y].Top = x * Matrice1[x, y].Height + 20;
                    Matrice1[x, y].Left = y * Dimensions + 6;
                    Matrice1[x, y].Width = Dimensions;
                    groupBoxMatrice1.Controls.Add(Matrice1[x, y]);
                }
            }
        }
        private void btnGerarInversaM1_Click(object sender, EventArgs e)
        {
            if (Matrice1 == null)
            {
                MessageBox.Show("Matrice Nulle", "Erreur Matrice");
                return;
            }
            int[,] tempResultante = new int[Matrice1.GetLength(0), Matrice1.GetLength(1)];
            int[,] matriceTest = new int[Matrice1.GetLength(0), Matrice1.GetLength(1)];
            int[,] matriceTest2 = new int[Matrice1.GetLength(0), Matrice1.GetLength(1)];
            int determinante = 0;
            if (tempResultante.GetLength(0) != 2 || tempResultante.GetLength(1) != 2)
            {
                if (tempResultante.GetLength(0) != 3 && tempResultante.GetLength(1) != 3)
                {
                    MessageBox.Show("Matrice Invalide", "Erreur de Matrice");
                    return;
                }
            }
            for (int x = 0; x < Matrice1.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice1.GetLength(1); y++)
                {
                    int n = 0;
                    int.TryParse(Matrice1[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                matriceTest2 = CalculMatrice.Inverse2x2(tempResultante);
                matriceTest = CalculMatrice.Transpose(matriceTest2);
                determinante = CalculMatrice.Determinant2x2(tempResultante);
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                matriceTest2 = CalculMatrice.Inverse3x3(tempResultante);
                matriceTest = CalculMatrice.Transpose(matriceTest2);
                determinante = CalculMatrice.Determinant2x2(tempResultante);
            }
            else
            {
                MessageBox.Show("Matrice Invalide", "Erreur de Matrice");
                return;
            }
            if (determinante == 0)
            {
                MessageBox.Show("Matrice invalide, determinant égal 0", "Erreur de Matrice");
                return;
            }
            int[,] tempMatriceResultante = CalculMatrice.inverse(determinante, matriceTest);
            int Dimensions = groupBoxMatrice1.Width / Matrice1.GetLength(1);
            for (int x = 0; x < Matrice1.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice1.GetLength(1); y++)
                {
                    Matrice1[x, y].Text = tempMatriceResultante[x, y].ToString();
                }
            }
        }
        private void btnGerarDeterminanteM1_Click(object sender, EventArgs e)
        {
            if (Matrice1 == null)
            {
                MessageBox.Show("Matrice Nulle", "Erreur Matrice");
                return;
            }
            int[,] tempResultante = new int[Matrice1.GetLength(0), Matrice1.GetLength(1)];

            for (int x = 0; x < Matrice1.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice1.GetLength(1); y++)
                {
                    int n = 0;
                    int.TryParse(Matrice1[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }
            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                determinante = CalculMatrice.Determinant2x2(tempResultante);
                MessageBox.Show("" + determinante, "Determinant");
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                determinante = CalculMatrice.Determinante3x3(tempResultante);
                MessageBox.Show("" + determinante, "Derterminant");
            }
            else
            {
                MessageBox.Show("Impossible de définir le déterminant", "Erreur Matrice Invalide");
            }
        }


        #endregion
        #region Calcul Option Matrice2
        //Opposée de la Matrice 2
        private void btnOpposeM2_Click(object sender, EventArgs e)
        {
            if (Matrice2 == null)
            {
                MessageBox.Show("Matrice Nulle", "Erreur");
            }
            int[,] tempResultante = new int[Matrice2.GetLength(0), Matrice2.GetLength(1)];
            for (int x = 0; x < Matrice2.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice2.GetLength(1); y++)
                {
                    int n = 0;
                    int.TryParse(Matrice2[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            int[,] tempMatrice2 = CalculMatrice.Oppose(tempResultante);
            int Dimensions = groupBoxMatrice2.Width / Matrice2.GetLength(1);
            for (int x = 0; x < Matrice2.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice2.GetLength(1); y++)
                {
                    Matrice2[x, y].Text = tempMatrice2[x, y].ToString();
                }
            }
        }
        //Transposée de la Matrice 2
        private void btnTransposeM2_Click(object sender, EventArgs e)
        {
            if (Matrice2 == null)
            {
                MessageBox.Show("Matrice Nulle", "Erreur");
                return;
            }
            int[,] tempResultante = new int[Matrice2.GetLength(0), Matrice2.GetLength(1)];

            for (int x = 0; x < Matrice2.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice2.GetLength(1); y++)
                {
                    int n = 0;
                    int.TryParse(Matrice2[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }
            int[,] tempMatriceResultante = CalculMatrice.Transpose(tempResultante);

            int Dimensions = groupBoxMatrice2.Width / Matrice2.GetLength(1);
            Matrice2 = new TextBox[tempMatriceResultante.GetLength(0), tempMatriceResultante.GetLength(1)];
            groupBoxMatrice2.Controls.Clear();

            for (int x = 0; x < Matrice2.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice2.GetLength(1); y++)
                {
                    Matrice2[x, y] = new TextBox();
                    Matrice2[x, y].Text = tempMatriceResultante[x, y].ToString();
                    Matrice2[x, y].Top = x * Matrice2[x, y].Height + 20;
                    Matrice2[x, y].Left = y * Dimensions + 6;
                    Matrice2[x, y].Width = Dimensions;
                    groupBoxMatrice2.Controls.Add(Matrice2[x, y]);
                }
            }
        }
        // Inverse de la Matrice 2
        private void btnInverseM2_Click(object sender, EventArgs e)
        {
            if (Matrice2 == null)
            {
                MessageBox.Show("Matrice Nulle", "Erreur Matrice");
                return;
            }
            int[,] tempResultante = new int[Matrice2.GetLength(0), Matrice2.GetLength(1)];
            int[,] matriceTest = new int[Matrice2.GetLength(0), Matrice2.GetLength(1)];
            int[,] matriceTest2 = new int[Matrice2.GetLength(0), Matrice2.GetLength(1)];
            int determinante = 0;
            if (tempResultante.GetLength(0) != 2 || tempResultante.GetLength(1) != 2)
            {
                if (tempResultante.GetLength(0) != 3 && tempResultante.GetLength(1) != 3)
                {
                    MessageBox.Show("Matrice Invalide", "Erreur de Matrice");
                    return;
                }
            }
            for (int x = 0; x < Matrice2.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice2.GetLength(1); y++)
                {
                    int n = 0;
                    int.TryParse(Matrice2[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                matriceTest2 = CalculMatrice.Inverse2x2(tempResultante);
                matriceTest = CalculMatrice.Transpose(matriceTest2);
                determinante = CalculMatrice.Determinant2x2(tempResultante);
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                matriceTest2 = CalculMatrice.Inverse3x3(tempResultante);
                matriceTest = CalculMatrice.Transpose(matriceTest2);
                determinante = CalculMatrice.Determinant2x2(tempResultante);
            }
            else
            {
                MessageBox.Show("Matrice Invalide", "Erreur de Matrice");
                return;
            }
            if (determinante == 0)
            {
                MessageBox.Show("Matrice invalide, determinant égal 0", "Erreur de Matrice");
                return;
            }
            int[,] tempMatriceResultante = CalculMatrice.inverse(determinante, matriceTest);
            int Dimensions = groupBoxMatrice2.Width / Matrice2.GetLength(1);
            for (int x = 0; x < Matrice2.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice2.GetLength(1); y++)
                {
                    Matrice2[x, y].Text = tempMatriceResultante[x, y].ToString();
                }
            }
        }
        //Determinant de la Matrice 2
        private void btnDeterminantM2_Click(object sender, EventArgs e)
        {
            if (Matrice2 == null)
            {
                MessageBox.Show("Matrice Nulle", "Erreur Matrice");
                return;
            }
            int[,] tempResultante = new int[Matrice2.GetLength(0), Matrice2.GetLength(1)];

            for (int x = 0; x < Matrice2.GetLength(0); x++)
            {
                for (int y = 0; y < Matrice2.GetLength(1); y++)
                {
                    int n = 0;
                    int.TryParse(Matrice2[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }
            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                determinante = CalculMatrice.Determinant2x2(tempResultante);
                MessageBox.Show("" + determinante, "Determinant");
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                determinante = CalculMatrice.Determinante3x3(tempResultante);
                MessageBox.Show("" + determinante, "Derterminant");
            }
            else
            {
                MessageBox.Show("Impossible de définir le déterminant", "Erreur Matrice Invalide");
            }
        }
        #endregion
        #region Calcul Options Résultat
        //Opposé Matrice Résultante
        private void btnOpposeResult_Click(object sender, EventArgs e)
        {
            if (MatriceResultante == null)
            {
                MessageBox.Show("Matrice Nulle", "Erreur");
                return;
            }
            int[,] tempResultante = new int[MatriceResultante.GetLength(0), MatriceResultante.GetLength(1)];
            for (int x = 0; x < MatriceResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatriceResultante.GetLength(1); y++)
                {
                    int n = 0;
                    int.TryParse(MatriceResultante[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            int[,] tempMatriceResultante = CalculMatrice.Oppose(tempResultante);
            int Dimensions = groupBoxMatriceResultante.Width / MatriceResultante.GetLength(1);
            for (int x = 0; x < MatriceResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatriceResultante.GetLength(1); y++)
                {
                    MatriceResultante[x, y].Text = tempMatriceResultante[x, y].ToString();
                }
            }
        }
        //Transposé Matrice résultante
        private void btnTransposeResultat_Click(object sender, EventArgs e)
        {
            if (MatriceResultante == null)
            {
                MessageBox.Show("Matrice Nulle", "Erreur");
                return;
            }
            int[,] tempResultante = new int[MatriceResultante.GetLength(0), MatriceResultante.GetLength(1)];

            for (int x = 0; x < MatriceResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatriceResultante.GetLength(1); y++)
                {
                    int n = 0;
                    int.TryParse(MatriceResultante[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }
            int[,] tempMatriceResultante = CalculMatrice.Transpose(tempResultante);

            int Dimensions = groupBoxMatriceResultante.Width / MatriceResultante.GetLength(1);
            MatriceResultante = new TextBox[tempMatriceResultante.GetLength(0), tempMatriceResultante.GetLength(1)];
            groupBoxMatriceResultante.Controls.Clear();

            for (int x = 0; x < MatriceResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatriceResultante.GetLength(1); y++)
                {
                    MatriceResultante[x, y] = new TextBox();
                    MatriceResultante[x, y].Text = tempMatriceResultante[x, y].ToString();
                    MatriceResultante[x, y].Top = x * MatriceResultante[x, y].Height + 20;
                    MatriceResultante[x, y].Left = y * Dimensions + 6;
                    MatriceResultante[x, y].Width = Dimensions;
                    groupBoxMatriceResultante.Controls.Add(MatriceResultante[x, y]);
                }
            }
        }
        // Inverse Matrice Résultante
        private void button8_Click(object sender, EventArgs e)
        {
            if (MatriceResultante == null)
            {
                MessageBox.Show("Matrice Nulle", "Erreur Matrice");
                return;
            }
            int[,] tempResultante = new int[MatriceResultante.GetLength(0), MatriceResultante.GetLength(1)];
            int[,] matriceTest = new int[MatriceResultante.GetLength(0), MatriceResultante.GetLength(1)];
            int[,] matriceTest2 = new int[MatriceResultante.GetLength(0), MatriceResultante.GetLength(1)];
            int determinante = 0;
            if (tempResultante.GetLength(0) != 2 || tempResultante.GetLength(1) != 2)
            {
                if (tempResultante.GetLength(0) != 3 && tempResultante.GetLength(1) != 3)
                {
                    MessageBox.Show("Matrice Invalide", "Erreur de Matrice");
                    return;
                }
            }
            for (int x = 0; x < MatriceResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatriceResultante.GetLength(1); y++)
                {
                    int n = 0;
                    int.TryParse(MatriceResultante[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                matriceTest2 = CalculMatrice.Inverse2x2(tempResultante);
                matriceTest = CalculMatrice.Transpose(matriceTest2);
                determinante = CalculMatrice.Determinant2x2(tempResultante);
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                matriceTest2 = CalculMatrice.Inverse3x3(tempResultante);
                matriceTest = CalculMatrice.Transpose(matriceTest2);
                determinante = CalculMatrice.Determinant2x2(tempResultante);
            }
            else
            {
                MessageBox.Show("Matrice Invalide", "Erreur de Matrice");
                return;
            }
            if (determinante == 0)
            {
                MessageBox.Show("Matrice invalide, determinant égal 0", "Erreur de Matrice");
                return;
            }
            int[,] tempMatriceResultante = CalculMatrice.inverse(determinante, matriceTest);
            int Dimensions = groupBoxMatriceResultante.Width / MatriceResultante.GetLength(1);
            for (int x = 0; x < MatriceResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatriceResultante.GetLength(1); y++)
                {
                    MatriceResultante[x, y].Text = tempMatriceResultante[x, y].ToString();
                }
            }
        }
        // Determinant Matrice Résultante
        private void button2_Click(object sender, EventArgs e)
        {
            if (MatriceResultante == null)
            {
                MessageBox.Show("Matrice Nulle", "Erreur Matrice");
                return;
            }
            int[,] tempResultante = new int[MatriceResultante.GetLength(0), MatriceResultante.GetLength(1)];

            for (int x = 0; x < MatriceResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatriceResultante.GetLength(1); y++)
                {
                    int n = 0;
                    int.TryParse(MatriceResultante[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }
            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                determinante = CalculMatrice.Determinant2x2(tempResultante);
                MessageBox.Show("" + determinante, "Determinant");
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                determinante = CalculMatrice.Determinante3x3(tempResultante);
                MessageBox.Show("" + determinante, "Derterminant");
            }
            else
            {
                MessageBox.Show("Impossible de définir le déterminant", "Erreur Matrice Invalide");
            }
        }


        #endregion
        #region Cryptage de Hill
        private void btnEncrypter_Click(object sender, EventArgs e)
        {
            //Suppression des espaces 
            var test = txtACoder.Text.Replace(" " ,string.Empty);
            //var test1 = txtACoder.Text.Replace(txtACoder, string.Text.Normalize);

            txtChiffre.Text= TraitementCryptage(txtACoder.Text,true);
        }


        /// <summary>
        /// Fonction Encryptage / Decryptage Hill
        /// </summary>
        /// <param name="message">message à crypter</param>
        /// <param name="mode">true = encryptage false décryptage</param>
        /// <returns>message décrypté ou encrypté</returns>
        private string TraitementCryptage(string message, bool mode)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int[,] matrice = new int[2, 2];

            if (string.IsNullOrWhiteSpace(txt1.Text) || string.IsNullOrWhiteSpace(txt2.Text) || string.IsNullOrWhiteSpace(txt3.Text) || string.IsNullOrWhiteSpace(txt4.Text))
            {
                MessageBox.Show("Une ou plusieurs cases sont vides", "Erreur Matrice de Cryptage");
            }
            else
            {
                matrice[0, 0] = int.Parse(txt1.Text);
                matrice[0, 1] = int.Parse(txt2.Text);
                matrice[1, 0] = int.Parse(txt3.Text);
                matrice[1, 1] = int.Parse(txt4.Text);
            }

            if (!mode)
            {

                MessageBox.Show("Disponible Prochainement", "Erreur Décryptage non disponible");
                //matrice = CalculMatrice.Inverse2x2(matrice);
            }

            int pos = 0, charPosition;
            string substring, result = "";
            int tailleMatrice = matrice.GetLength(0);
          
           

            while (pos < message.Length)
            {
                substring = message.Substring(pos, tailleMatrice);
                pos += tailleMatrice;
                int[,] matriceResultante = new int[2, 1];

             
                int[,] matrice2 = new int[2, 1];

                matrice2[0, 0] = alphabet.IndexOf(substring[0]);
                matrice2[1, 0] = alphabet.IndexOf(substring[1]);     

                matriceResultante = CalculMatrice.MultiplierMatrice(matrice, matrice2);
                    
                result += alphabet.Substring(matriceResultante[0, 0] % 26,1) + alphabet.Substring(matriceResultante[1, 0] % 26,1);
                
            }

            return result;
        }

        private void btnDecrypter_Click(object sender, EventArgs e)
        {
            txtACoder.Text = TraitementCryptage(txtChiffre.Text, false);
        }
        #endregion






    }






    }
