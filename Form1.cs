/*
 * This in an application that simulates the Casino game of craps
 * Author Chris Burkhead
 * CS311-ON
 * Fall 2022
 * Bellarmine University
 * Version 1.0
 */

namespace CS311_Project2_CMB
{
    public partial class frmCraps : Form
    {
        //instance variables
        int point = 0;
        double bank = 100.00;
        double bet;

        //constructor
        public frmCraps()
        {
            InitializeComponent();

        }//end constructor

        // Form1_Load() sets a standard format for the lblBank and sets it equal to the variable bank
        private void Form1_Load(object sender, EventArgs e)
        {
            lblBank.Text = "$" + bank.ToString("0.00");
            Console.WriteLine(lblBank);

        }//end Form1_Load


        /* btnRoll_Click() checks to ensure that a bet has been placed and then ensures that 
         * enough funds exist in the bank to cover the bet. If both conditions are met then 
         * the calculate_score() is called. Otherwise MessageBoxes pop up informaing the player what changes 
         * they must make in order to keep playing. 
        */

        private void btnRoll_Click(object sender, EventArgs e)
        {
           /* If structure checks to ensure that txtBet isn't empty, if it is it throws a message box
            * informing the player to place a bet and then exits the method. Otherwise if a bet has been placed
            * it sets the variable bet equal to the amount entered by the player.
            */
            if (txtBet.Text == "")
            {
                MessageBox.Show("You must enter a Bet to play");
                return;

            }//end if

            else if (txtBet.Text !="")
            {
                bet = float.Parse(txtBet.Text);
            }//end else if
            
            
            /* If structure checks three conditions, 1st if checks to see if the bank is greater or equal 
             *  to the bet placed, if true it calls the calculate_score() and game play proceeds. 
             *  2nd else if checks to see if the bank is empty, if this is true then play halts.
             *  3rd else if checks to see if the bet made is greater then whats in the bank, if this is true
             *  it directs the player to make a smaller bet
             */
            if (bank >= bet)
            { 
                calculate_score();
            }//end if

            else if (bank == 0)
            {
                MessageBox.Show("Sorry, your bank is empty, please play again");
            }// end else if

            else if (bank < bet)
            {
                MessageBox.Show("You do not have enough in the bank to make this bet, please bet again");

            }//end else if
           
        }//end btnRoll_Click

        /* calculate_score() runs the main simulation of the game using if and switch structures.
         * It generates two random numbers between 1-6 that represent dice. It then finds the sum of 
         * those dice and uses two switch structures to evaulate the sum of those dice against the conditions
         * of the game.
         */
        private void calculate_score()
        {
            //resetting all lbl's to blank before each roll
            lblDice1.Text = "";
            lblDice2.Text = "";
            lblWinLosePoint.Text = "";
            
           //genertating random numbers between 1-6 storing those values into variables and then finding their sum
            Random d1 = new Random();
            Random d2 = new Random();
            int dice1 = d1.Next(1, 7);
            int dice2 = d2.Next(1, 7);
            int diceSum = dice1 + dice2;

            //writing the value of the dice to the screen
            lblDice1.Text = dice1.ToString();
            lblDice2.Text = dice2.ToString();
            Console.WriteLine(lblDice1);
            Console.WriteLine(lblDice2);


            /* This if structure has three conditions which execute the rules of the game. 
             * The 1st if statement checks to see if the variable point is Zero, if this is true 
             * that means this is the first roll of the game which specific conditions apply and 
             * are evaluated by a switch statement. The switch statement evaluates if the case is a winning, 
             * losing or default case and then prints the result to the screen. It also adjusts the value of the 
             * bank based on if the roll was a winning or losing roll. This game uses a standard 1:1 return on bets
             * in a craps game. It also resets the point variable to 0 if it was a winning or losing case. If it is
             * a default case then the variable point gets set to the value of the variable diceSum as it determines 
             * the execution of the next two else if statements. 
             */
            if (point == 0)
            {
                switch (diceSum)
                {
                    case 7:
                        lblWinLosePoint.Text = ("You Win!");
                        Console.WriteLine(lblWinLosePoint.Text);
                        bank = bank + bet;
                        lblBank.Text = "$" + bank.ToString("0.00"); 
                        Console.Write(lblBank);
                        point = 0;
                        break;

                    case 11:
                        lblWinLosePoint.Text = ("You Win!");
                        Console.WriteLine(lblWinLosePoint.Text);
                        bank = bank + bet;
                        lblBank.Text = "$" + bank.ToString("0.00");
                        Console.Write(lblBank);
                        point = 0;
                        break;

                    case 2:
                        lblWinLosePoint.Text = ("You Lose!");
                        Console.WriteLine(lblWinLosePoint.Text);
                        bank = bank - bet;
                        lblBank.Text = "$" + bank.ToString("0.00");
                        Console.Write(lblBank);
                        point = 0;
                        break;

                    case 3:
                        lblWinLosePoint.Text = ("You Lose!");
                        Console.WriteLine(lblWinLosePoint.Text);
                        bank = bank - bet;
                        lblBank.Text = "$" + bank.ToString("0.00");
                        Console.Write(lblBank);
                        point = 0;
                        break;

                    case 12:
                        lblWinLosePoint.Text = ("You Lose!");
                        Console.WriteLine(lblWinLosePoint.Text);
                        bank = bank - bet;
                        lblBank.Text = "$" + bank.ToString("0.00");
                        Console.Write(lblBank);
                        point = 0;
                        break;

                    default:
                        point = diceSum;
                        lblWinLosePoint.Text = "Point is " + point;
                        Console.WriteLine(lblWinLosePoint.Text);
                        break;
                }//end switch

            }//end if

            /* This else if statement is checking to see if a winning condition has been met 
             * after the inital roll. It does this by ensuring that point does not equal 0 and it is also equal
             * to the new diceSum. This ensures that it is atleast the second roll of a game where a winning or 
             * losing condition was not met in the previous switch structure. And diceSum is the value of 
             * the new roll. If point and diceSum are equal then the player wins. It then prints the 
             * results to the screen. And resets point to 0 so a new game can start.
             */
            else if ((point != 0) && (point == diceSum))
            {
                lblWinLosePoint.Text = ("You Win!");
                Console.WriteLine(lblWinLosePoint.Text);
                bank = bank + bet;
                lblBank.Text = "$" + bank.ToString("0.00");
                Console.Write(lblBank);
                point = 0;
            }// end else if

            /*The last else if statement only executes if this is at least the second roll of the game by ensuring
             * variable point is not equal to zero. It then uses a switch structure consisting of one case and
             * one default statement. The case is checking to see if the new roll is equal to 7, because after the
             * first roll 7 now becomes a losing condition and it executes exactly how the other losing conditions 
             * operate. The default case executes if the losing condition was not meet and reprints the
             * current point to the screen, which prompts the player to roll again.  
             */
            else if (point != 0)
            { 
                switch (diceSum)
                {
                    case 7:
                        lblWinLosePoint.Text = ("You Lose!");
                        Console.WriteLine(lblWinLosePoint.Text);
                        bank = bank - bet;
                        lblBank.Text = "$" + bank.ToString("0.00");
                        Console.Write(lblBank);
                        point = 0;
                        break;

                    default:
                        lblWinLosePoint.Text = "Point is " + point;
                        Console.WriteLine(lblWinLosePoint.Text);
                        break;
                }//end switch

            }// end else if
           
        }//end calculate_score
  
    }//end class

}//end namespace