using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// ETML
/// Evan Gusarov
/// 24.01.2025
/// Bataille navale

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

            //nom des bateaux de guerre
            string boat1 = "Torpilleur";
            string boat2 = "Porte Avion";
            string boat3 = "Sous Marin";
            string boat4 = "Croiseur";

            //variable qui permet d'appeler la méthode BattleBoat
            byte nBoat1 = 0;
            byte nBoat2 = 0;
            byte nBoat3 = 0;
            byte nBoat4 = 0;

            //position du joueur
            int axeX = 0; //colonne
            int axeY = 0; //ligne

            //fait le tableau à 2 dimensions du jeu
            int[,] tabGames = new int[nRow, nCol];




            // titre du jeu
            Title();

            //permet de choisir le nombre de lignes et de colonnes dans le jeu
            nRow = Ask_row_col(row, NB_ROW_MAX, NB_ROW_MIN);
            nCol = Ask_row_col(col, NB_COL_MAX, NB_COL_MIN);

            //permet de choisir le nombre de bateau que le joueur veut
            nBoat1 = BattleBoat(boat1, NB_BOAT_MAX, NB_BOAT_MIN);
            nBoat2 = BattleBoat(boat2, NB_BOAT_MAX, NB_BOAT_MIN);
            nBoat3 = BattleBoat(boat3, NB_BOAT_MAX, NB_BOAT_MIN);
            nBoat4 = BattleBoat(boat4, NB_BOAT_MAX, NB_BOAT_MIN);

            //message qui dit au joueur ce qu'il a choisi pour le jeu
            Console.WriteLine("\nBien, vous aurez donc un tableau de jeu de " + nRow + "*" + nCol);
            Console.WriteLine("et vous aurez aussi " + nBoat1 + " " + boat1 + ", " + nBoat2 + " " + boat2 + ", " + nBoat3 + " " + boat3 + " et " + nBoat4 + " " + boat4);
            Console.WriteLine("Bon, je vais vous laissez joueur à la bataille naval :)");
            Console.ReadLine();

            //efface l'écran pour que le joueur puisse jouer
            Console.Clear();


            Title();//affiche le titre du jeu
            Grid(nRow, nCol, tabGames); //affiche le plateau de jeu
            Rules(nBoat1, nBoat2, nBoat3, nBoat4); //affiche les règle du jeu + le nb de bateau restant
            MoveInGrid(nRow, nCol); //permet de déplacer le joueur sur le plateau de jeu
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
        static void Grid(int nRow, int nCol, int[,] tabGames)
        {
            // affichage du plateau de jeu bataille naval

            //génération des lettres de A à Z pour les colonnes
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Console.Write("\n\t ");//met un espace pour que les lettres soient bien alignées

            //met les lettres de A à Z au dessus du plateau de jeu
            for (int i = 0; i < nCol; i++)
            {
                Console.Write(" " + alphabet[i]);
            }

            Console.Write("\n\t╔");
            for (int k = 0; k < nCol; k++) //met la première ligne du plateau de jeu
            {
                Console.Write("══");
            }
            Console.Write("═╗");


            for (int k = 1; k < nRow + 1; k++)
            {
                Console.Write("\n " + k + "\t");
                Console.Write("║ ");
                for (int l = 0; l < nCol; l++)
                {
                    Console.Write("· ");
                }
                Console.Write("║");
            }
            Console.Write("\n\t╚");
            for (int k = 0; k < nCol; k++) //met la dernière ligne du plateau de jeu
            {
                Console.Write("══");
            }
            Console.Write("═╝");
        }
        static void Rules(byte nBoat1, byte nBoat2, byte nBoat3, byte nBoat4)
        {
            // affiche les règles du jeu
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
            Console.WriteLine("Torpilleur\t " + nBoat1);
            Console.SetCursorPosition(68, 24);
            Console.WriteLine("Porte Avion\t " + nBoat2);
            Console.SetCursorPosition(68, 26);
            Console.WriteLine("Sous Marin\t " + nBoat3);
            Console.SetCursorPosition(68, 28);
            Console.WriteLine("Croiseur\t " + nBoat4);
            Console.SetCursorPosition(68, 32);
            Console.WriteLine("Nombre de tir restant : ");
        }
        static int Ask_row_col(string row_col, int max, int min)
        {
            int nRow = 0;//variable que le joueur choisit pour les lignes et les colonnes

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
        static byte BattleBoat(string nameboat, int max, int min)
        {
            byte boat = 0;

            Console.WriteLine("Maintenant je vais vous demandez de choisir le nombre de " + nameboat + " que vous voulez");
            Console.Write("chaque bateau dois avoir minimum ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(min);
            Console.ResetColor();
            Console.Write(" et un maximum de ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(max);
            Console.ResetColor();

            //demande le nombre de bateau que veux le joueur
            do
            {
                Console.Write("entrez votre valeur : ");
                try
                {
                    boat = Convert.ToByte(Console.ReadLine());
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
        static void MoveInGrid(int nRow, int nCol)
        {
            //tableau a 2 dimensions qui représente le plateau de jeu
            int[,] tabGames = new int[nRow, nCol];

            //position du joueur
            int axeX = 0; //colonne
            int axeY = 0; //ligne
            int nbShootMax = 150; //nombre de tir maximum que le joueur peut faire


            //permet de déplacer le joueur sur le plateau de jeu
            ConsoleKey key;
            do
            {

                key = Console.ReadKey().Key; //récupère la touche que le joueur appuie sans qu'il la voit sur le plateau de jeu

                Console.SetCursorPosition(axeX * 2 + 10, axeY + 9);

                switch (key)
                {
                    case ConsoleKey.UpArrow://déplacement vers le haut
                        if (axeY > 0)
                        {
                            axeY--;
                        }
                        break;
                    case ConsoleKey.DownArrow://déplacement vers le bas
                        if (axeY < nRow - 1)
                        {
                            axeY++;
                        }
                        break;
                    case ConsoleKey.LeftArrow://déplacement vers la gauche
                        if (axeX > 0)
                        {
                            axeX--;
                        }
                        break;
                    case ConsoleKey.RightArrow://déplacement vers la droite
                        if (axeX < nCol - 1)
                        {
                            axeX++;
                        }
                        break;
                    case ConsoleKey.Enter://tirer et poser les bateaux
                        if (nbShootMax > 0)
                        {
                            Console.SetCursorPosition(axeX * 2 + 10, axeY + 9);
                            if (Touched(tabGames, axeX, axeY))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;//met une croix rouge si un bateau est touché
                                Console.Write('X');
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;//met un carré bleu si c'est l'eau qui est touché
                                Console.Write('■');
                            }
                            Console.ResetColor();
                            nbShootMax--;

                            Console.SetCursorPosition(92, 32);
                            Console.WriteLine(nbShootMax);
                        }
                        else
                        {
                            Console.SetCursorPosition(68, 32);
                            Console.WriteLine("Vous n'avez plus de tir");
                            showBoat(nRow, nCol, tabGames, axeX, axeY);
                        }

                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        byeTitle();
                        break;
                }
            }
            while (key != ConsoleKey.Escape);//tant que le joueur n'appuie pas sur la touche escape, le jeu continue
            

        }
        static bool Touched(int[,] tabGames, int nRow, int nCol)
        {
            bool shoot = false;
            if (tabGames[nCol, nRow] == 1)
            {
                shoot = true;
            }
            return shoot;
        }
        static void byeTitle()
        {
            // Titre d'adieu de la bataille navale
            Console.CursorLeft = 35;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(35, 1);
            Console.WriteLine("║                au plaisir de vous revoir :)            ║");
            Console.SetCursorPosition(35, 2);
            Console.WriteLine("║        Réalisé par Evan Gusarov le 07.02.25 ETML       ║");
            Console.SetCursorPosition(35, 3);
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
        }
        static void showBoat(int nRow, int nCol, int[,] tabGames, int axeX, int axeY)
        {
            Console.Clear();
            Grid(nRow, nCol, tabGames);
            for (int i = 0; i < nCol; i++)
            {
                for (int y = 0; y < nRow; y++)
                {
                    Console.SetCursorPosition(i * 2 + 10, y + 3);
                    if (tabGames[y, i] != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write('X');
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write('■');
                    }
                }
            }
        }
    }
}