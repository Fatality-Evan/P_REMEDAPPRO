using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bataille_naval_Evan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // le nombre minimum que l'on peut mettre pour les lignes et les colonnes
            const byte NB_ROW_MIN = 10;
            const byte NB_COL_MIN = 10;
            // Nombre maximum que l'on peut mettre pour les lignes et colonnes
            const byte NB_ROW_MAX = 50;
            const byte NB_COL_MAX = 26;
            // Nombre choisi par le joueur
            int nRow = 0;
            int nCol = 0;
            //variable qui permet de changer le mot dans la méthode ask_row_col
            string row = "lignes";
            string col = "colonnes";
            //nb min et max des bateau sur le jeu
            const byte NB_BOAT_MIN = 1;
            const byte NB_BOAT_MAX = 2;

            string boat1 = "torpilleur";
            string boat2 = "porte avion";
            string boat3 = "sous marin";
            string boat4 = "croiseur";

            byte nbBoat1 = 0;
            byte nbBoat2 = 0;
            byte nbBoat3 = 0;
            byte nbBoat4 = 0;
            

            // titre du jeu
            Title();

            nRow = Ask_row_col(row, NB_ROW_MAX, NB_ROW_MIN);
            nCol = Ask_row_col(col, NB_COL_MAX, NB_COL_MIN);
            BattleBoat(NB_BOAT_MAX, NB_BOAT_MIN);
            BattleBoat(NB_BOAT_MAX, NB_BOAT_MIN);
            BattleBoat(NB_BOAT_MAX, NB_BOAT_MIN);
            BattleBoat(NB_BOAT_MAX, NB_BOAT_MIN);

            int[,] grille = new int[nRow, nCol];

            // torpilleur
            grille[2,4] = 1;
            grille[2,5] = 1;
            grille[2,6] = 1;

            Console.WriteLine("\nBien, vous aurez donc un tableau de jeu de " + nRow + "*" + nCol);
            Console.WriteLine();
            Console.WriteLine("Bon, je vais vous laissez joueur à la bataille naval :)");
            Console.ReadLine();

            Console.Clear();


            Title();//affiche le titre du jeu

            Grid(nRow, nCol); //affiche le plateau de jeu

            Rules(); //affiche les règle du jeu + le nb de bateau restant

            Console.Read();
        }
        static void Title()
        {
            // Titre de la bataille naval
            Console.CursorLeft = 35;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(35, 1);
            Console.WriteLine("║            Bienvenue dans la bataille naval            ║");
            Console.SetCursorPosition(35, 2);
            Console.WriteLine("║        Réalisé par Evan Gusarov le 07.02.25 ETML       ║");
            Console.SetCursorPosition(35, 3);
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Grid (int nRow, int nCol)
        {
            // affichage du plateau de jeu bataille naval
            
            Console.Write("\t╔");
            for (int k = 0; k < nCol; k++)      //met la première ligne du plateau de jeu
            {
                Console.Write("══");
            }
            Console.Write("═╗");


            for (int k = 1; k < nRow +1; k++)
            {
                Console.Write("\n " + k + "\t");
                Console.Write("║ ");
                for ( int l = 0; l < nCol ; l++)
                {
                    Console.Write("· ");
                }
                Console.Write("║");
            }
            Console.Write("\n\t╚");
            for (int k = 0; k < nCol; k++)      //met la dernière ligne du plateau de jeu
            {
                Console.Write("══");
            }
            Console.Write("═╝");
        }
        static void Rules()
        {
            Console.SetCursorPosition(65, 9);
            Console.WriteLine("Mode d'utilisation");
            Console.SetCursorPosition(65, 10);
            Console.WriteLine("-------------------");
            Console.SetCursorPosition(68, 11);
            Console.WriteLine("Déplacement\t Touches directionnelles");
            Console.SetCursorPosition(68, 12);
            Console.WriteLine("Tir\t\t Spacebar ou Enter");
            Console.SetCursorPosition(68, 13);
            Console.WriteLine("Quitter\t Escape");
            Console.SetCursorPosition(65, 20);
            Console.WriteLine("Nombre de Bateau restant");
            Console.SetCursorPosition(65, 21);
            Console.WriteLine("-------------------------");
            Console.SetCursorPosition(68, 22);
            Console.WriteLine("Torpilleur\t ");
            Console.SetCursorPosition(68, 24);
            Console.WriteLine("Porte Avion\t ");
            Console.SetCursorPosition(68, 26);
            Console.WriteLine("Sous Marin");
            Console.SetCursorPosition(68, 28);
            Console.WriteLine("Croiseur\t ");
            Console.SetCursorPosition(68, 32);
            Console.WriteLine("Nombre de tir effectué : ");
        }
        static int Ask_row_col(string row_col, int max, int min)
        {
            int nRow=0;
            
            Console.WriteLine("je vous prie de bien vouloir choisir le nombre de " + row_col);
            Console.Write("la valeur que vous choisissez doit être plus grande que ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(min);
            Console.ResetColor();
            Console.Write(" et doit être plus petit que ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(max);
            Console.ResetColor();



            // demande la valeur des lignes pour le jeu
            do
            {
                Console.Write("entrez votre valeur : ");
                try
                {
                    nRow = Convert.ToInt32(Console.ReadLine());
                    if (nRow < min || nRow > max)
                    {
                        // dit au joueur qu'il a mit des lignes trop petites ou trop grandes
                        Console.WriteLine("Je pense qu'il faudrait acheter des lunettes à ce stade");
                    }
                }
                catch (Exception e) // donne le message d'une erreur
                {
                    Console.WriteLine("Je pense qu'il vous faut un RDV chez l'opticien pour une erreur comme ça...");
                    Console.WriteLine(e.Message);
                }
            } while (nRow < min || nRow > max);
            return nRow;
            
        }
        static int BattleBoat(int max, int min)
        {
            int boat = 0;

            Console.WriteLine("Maintenant je vais vous demandez de choisir le nombre de bateau que vous voulez");
            Console.Write("chaque bateau dois avoir minimum ");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.Write("1 ");
            Console.ResetColor();
            Console.Write("et un maximum de ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2 ");
            Console.ResetColor();

            //demande le nombre de bateau que veux le joueur
            do
            {
                Console.Write("entrez votre valeur");
                try
                {
                    boat = Convert.ToInt32(Console.ReadLine());
                    if (boat < min || boat > max)
                    {
                        Console.WriteLine("vous avez trop ou pas assez de bateaux");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("mais pourquoi vous mettez ça...");
                    Console.WriteLine(e.Message);
                }
            }
            while (boat < min || boat > max);
            return boat;
        }
        static void byeTitle()
        {
            //titre d'aideu au joueur
            Console.SetCursorPosition(35, 35);
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(35, 1);
            Console.WriteLine("║           au revoir et à bientot sur mon jeu           ║");
            Console.SetCursorPosition(35, 2);
            Console.WriteLine("║        Réalisé par Evan Gusarov le 07.02.25 ETML       ║");
            Console.SetCursorPosition(35, 3);
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
        }
    }
}
