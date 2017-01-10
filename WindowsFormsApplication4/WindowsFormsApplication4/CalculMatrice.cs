using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class CalculMatrice
    {

        #region Operations
        public static int[,] AdditionnerMatrices(int[,] matrice1, int[,] matrice2)
        {
            int[,] matriceResultante = new int[matrice1.GetLongLength(0), matrice1.GetLength(1)];
            for (int x = 0; x < matriceResultante.GetLength(0); x++)
            {
                for (int y = 0; y < matriceResultante.GetLength(1); y++)
                {
                    matriceResultante[x, y] = matrice1[x, y] += matrice2[x, y];
                }
            }
            return matriceResultante;
        }

        public static int[,] SoustraireMatrice(int[,] matrice1, int[,] matrice2)
        {
            int[,] matriceResultante = new int[matrice1.GetLongLength(0), matrice1.GetLength(1)];
            for (int x = 0; x < matriceResultante.GetLength(0); x++)
            {
                for (int y = 0; y < matriceResultante.GetLength(1); y++)
                {
                    matriceResultante[x, y] = matrice1[x, y] -= matrice2[x, y];
                }
            }
            return matriceResultante;
        }

        public static int[,] MultiplierMatrice(int[,] matrice1, int[,] matrice2)
        {
            int[,] matriceResultante = new int[matrice1.GetLongLength(0), matrice2.GetLength(1)];
            for (int x = 0; x < matriceResultante.GetLength(0); x++)
            {
                for (int y = 0; y < matriceResultante.GetLength(1); y++)
                {
                    for (int n = 0; n < matrice2.GetLength(0); n++)
                    {
                        string i = "" + matrice1[x, n];
                        matriceResultante[x, y] += matrice1[x, n] * matrice2[n, y];
                    }
                }

            }
            return matriceResultante;
        }
        #endregion
        #region Opposé et Transposé
        public static int[,] Oppose(int[,] matrice)
        {
            int[,] matriceOppose = new int[matrice.GetLength(0), matrice.GetLength(1)];
            for (int x = 0; x < matriceOppose.GetLength(1); x++)
            {
                for (int y = 0; y < matriceOppose.GetLength(1); y++)
                {
                    matriceOppose[x, y] += matrice[x, y] * -1;
                }
            }
            return matriceOppose;
        }
        public static int[,] Transpose(int[,] matrice)
        {
            int[,] matriceTranspose = new int[matrice.GetLength(1), matrice.GetLength(0)];
            for (int i = 0; i < matriceTranspose.GetLength(0); i++)
            {
                for (int j = 0; j < matriceTranspose.GetLength(1); j++)
                {
                    matriceTranspose[i, j] = matrice[j, i];
                }
            }
            return matriceTranspose;
        }
        #endregion
        #region Inverse

        public static int[,] Inverse2x2(int[,] matrice1)
        {
            int[,] matriceInverse = new int[matrice1.GetLength(0), matrice1.GetLength(1)];
            int determinant = 0;

            for (int x = 0; x < matrice1.GetLength(0); x++)
            {
                for (int y = 0; y < matrice1.GetLength(1); y++)
                {
                    if (x == 0 && y == 0)
                    {
                        determinant = matrice1[x + 1, y + 1];
                    }
                    else if (x == 0 && y == 1)
                    {
                        determinant = matrice1[x + 1, y - 1];
                    }
                    else if (x == 1 && y == 0)
                    {
                        determinant = matrice1[x - 1, y + 1];
                    }
                    else if (x == 1 && y == 1)
                    {
                        determinant = matrice1[x - 1, y - 1];
                    }
                    double i = Math.Pow(-1, (x + y));
                    matriceInverse[x, y] += (int)i * determinant;
                }
            }
            return matriceInverse;
        }
        public static int[,] Inverse3x3(int[,] matrice1)
        {
            int[,] matriceInverse = new int[matrice1.GetLength(0), matrice1.GetLength(1)];
            int determinant = 0;

            for (int x = 0; x < matrice1.GetLength(0); x++)
            {
                for (int y = 0; y < matrice1.GetLength(1); y++)
                {
                    determinant = factDeterminant(x, y, matrice1);
                    double i = Math.Pow(-1, (x + y));
                    matriceInverse[x, y] += (int)i * determinant;
                }
            }
            return matriceInverse;
        }
        private static int factDeterminant(int posX, int PosY, int[,] matrice)
        {
            int[,] matriceResultante = new int[2, 2];
            int id = 0;
            for (int x = 0; x < matrice.GetLength(1); x++)
            {
                for (int y = 0; y < matrice.GetLength(1); y++)
                {
                    if (x != posX && y != PosY)
                    {
                        if (id == 0)
                        {
                            matriceResultante[0, 0] += matrice[x, y];
                        }
                        else if (id == 1)
                        {
                            matriceResultante[1, 0] += matrice[x, y];
                        }
                        else if (id == 2)
                        {
                            matriceResultante[1, 0] += matrice[x, y];
                        }
                        else if (id == 3)
                        {
                            matriceResultante[1, 1] += matrice[x, y];
                        }
                        id++;
                    }
                }
            }
            int determinante = Determinant2x2(matriceResultante);
            return determinante;
        }
        public static int[,] inverse(int determinante, int[,] matrice1)
        {
            int[,] MatriceInverse = new int[matrice1.GetLength(0), matrice1.GetLength(1)];
            for (int x = 0; x < matrice1.GetLength(0); x++)
            {
                for (int y = 0; y < matrice1.GetLength(1); y++)
                {
                    int n = matrice1[x, y];
                    n = n / determinante;
                    MatriceInverse[x, y] += n;
                }
            }
            return MatriceInverse;
        }
        #endregion
        #region Déterminant
        public static int Determinant2x2(int[,] matrice)
        {
            int diagonalePrincipale = 1;
            int diagonalSecondaire = 1;
            int determinanteFinale = 0;
            for (int x = 0; x < matrice.GetLength(0); x++)
            {
                for (int y = 0; y < matrice.GetLength(1); y++)
                {
                    if (x == y)
                    {
                        diagonalePrincipale *= matrice[x, y];
                    }
                }
            }
            for (int x = 0; x < matrice.GetLength(0); x++)
            {
                for (int y = 0; y < matrice.GetLength(1); y++)
                {
                    if (x != y)
                    {
                        diagonalSecondaire *= matrice[x, y];
                    }
                }
            }
            determinanteFinale = diagonalePrincipale - diagonalSecondaire;
            return determinanteFinale;
        }

        public static int Determinante3x3(int[,] matrice)
        {
            int diagonalePrincipale = 0;
            int diagonaleSecondaire = 0;
            int determinanteFinale = 0;
            int DimensionsTest = ((matrice.GetLength(0) * matrice.GetLength(1)) * 2) / 3 -1;
            int[,] Test = new int[matrice.GetLength(0), DimensionsTest];
            for (int x = 0; x < Test.GetLength(1); x++)
			{
			    for (int y = 0; y < Test.GetLength(0); y++)
			    {
			        if (y > matrice.GetLength(0) -1)
	                {
		                Test[x, y] += matrice[x, y - matrice.GetLength(0)];
	                }
                    else
	                {
                        Test[x, y] += matrice[x, y];
	                }
			    }
            }
                    int voltas = 3;
        for (int i = 0; i < voltas; i++)
			{
			 int numero = i;
             int mDiagonale = 1;
             for (int x = 0; x < Test.GetLength(0); x++)
			{
                 for (int y = 0; y < Test.GetLength(1); y++)
			{
			 if (x == y)
	    {
		 string z = "" + Test[x, y + numero];
                 mDiagonale *= Test[x, y + numero];
	    }
			}

            }
			 diagonalePrincipale += mDiagonale;
			}
            for (int i = 0; i < voltas; i++)
			{
			 int numero = i;
             int mDiagonale = 1;
             for (int x = 0; x < Test.GetLength(0); x++)
			{
			 for (int y = Test.GetLength(1) -1; y > 0; y--)
			{
			    if (x == (Test.GetLength(1) - 1) - y) 
			    {
		            string z = "" + Test[x, y -numero];
                    mDiagonale *= Test[x, y - numero];
	            }
            }
	
			}
                diagonaleSecondaire += mDiagonale;
			}
            determinanteFinale = diagonalePrincipale - diagonaleSecondaire;
            return determinanteFinale;
		}
        #endregion

    
    }
    }
