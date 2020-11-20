using System;
using System.Text;
using static System.Console;
using static System.Math;

// Fight with Loup-Garou
// set up HP, weapons, and choices
// need locket AND gun; can survive with gun only

namespace FinalBoss
{
    public class BossEncounter
    {
        /* public static void chamberBoss()
        {
            
        } */

        public static void battleNoLocket()
        {
            WriteLine("You realize that you have a weapon – the Gun – but not much protection. Nevertheless, you vow to not let this monstrosity leave this room alive.");
            WriteLine("As the Loup-Garou turns around to face you, you draw the Gun….");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();

            // setting up variables for the encounter
            int healthLoupGarou = 60; 	// or higher; adjust, if time
            int playerHealth = 40; 	// or higher
            int armorLoupGarou = 14;
            int armorPlayer = 10;
            int armorWithLocket = 18;
            

            // loop for the fight
            // the player and LG ‘roll’ a d20 to hit; if they connect, they do damage
            // the player ‘rolls a d8’ to damage, the LG rolls a d12; critical hits occur at the max value – double damage

            while((healthLoupGarou > 0) || (playerHealth > 0))
            { 
                if(playerHealth <= 0)
                    playerEnd();
                if(healthLoupGarou <= 0)
                    loupGarouEnd();     
                
                Console.WriteLine("You have {0} Hit Points, while the Loup-Garou has {1} Hit Points.", playerHealth, healthLoupGarou);
                
                Console.WriteLine("You take a shot…");
                
                // for the player
                Random rd = new Random();
                int roll = rd.Next(1, 21);      // simulating a 20-sided die roll
                Random dmg = new Random();
                int damage = dmg.Next(1,9);     // 1-8 points of damage per shot

                if(roll >= armorLoupGarou)
                {		
                    WriteLine("Hit! You do {0} points of damage!", damage);
                    healthLoupGarou -= damage;
                    WriteLine("It now has {0} Hit Points", healthLoupGarou);
                }
                else
                {
                    WriteLine("Miss!");
                }
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();

                WriteLine("The Loup-Garou attacks…");

                // for the Loup-Garou
                Random rl = new Random();
                int rollLG = rl.Next(1, 21);
                Random dmgg = new Random();
                int damageLG = dmgg.Next(1,13);     // 1-12 points of damage per attack

                if(roll >= armorPlayer)
                {
                    WriteLine("Hit! It does {0} points of damage!", damageLG);
                    playerHealth -= damageLG;
                    WriteLine("You now have {0} Hit Points", playerHealth);
                }
                else
                {
                    WriteLine("Miss!");
                }
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
            }
        }

        public static void battleNoGunOrNeitherItem()
        {
            WriteLine("You realize that you don’t have a weapon to deal with this monster. You also are just wearing ‘normal’ clothes – not much protection. As you realize this, the door into the room closes shut.");
            WriteLine("You are now trapped in the room with the Loup-Garou. The Loup-Garou also realizes this, and starts to advance towards you, mal-intent in its eyes. It suddenly lunges at you, impossibly fast, with claws outstretched, impossibly strong. You feel an impact… and then there’s blackness, as you are literally torn in half.");
            //    System.Windows.Forms.Application.Exit( );
        }
            
        public static void battleFull ()
        {
            // test the ‘No Locket’ code, adjust for here
        }
            
        public static void playerEnd()
        {
            WriteLine("Your gun shots seem to slow the Loup-Garou… but not enough. You, however, have been slowed a lot by its counterattacks. You’ve lost a lot of blood, via claw and bites. You raise the Gun to take another shot…");
            WriteLine("… and you never get the shot off. The Loup-Garou streaks by you, claws reaching. You body remains upright for a few moments but your head bounces away. The Loup-Garou will feast well on your remains, tonight.");
            System.Environment.Exit(0);
        }
            
        public static void loupGarouEnd()
        {
            WriteLine("The Loup-Garou, despite its impressive resilience, speed, and strength, is looking very wounded and very ticked off. It crouches down, snarling and growling, ready to pounce. You take a deep breath to steady yourself, aim the Gun, and fire, as the Loup-Garou leaps…");
            WriteLine("Your shot lands true.");
            WriteLine("The shot hits the Loup-Garou in the upper forehead, knocking it off-course. it lands with a VERY heavy ‘thud’, rolling towards the iron door. The body starts to… change. It shrinks in height, the grey fur starts to recede, the face starts to shrink… what’s left is the body of a woman, at least 6 feet tall, with long red hair. And there is the strangest sight: the woman looks… content?");
            // clear
            WriteLine("You identify the woman as [name], the seemingly-immortal owner of the house. You report back to the group that sent you, bringing the Gun and other items you might have found. The group is pleased with your work.");
        }

    }
}

