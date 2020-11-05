/* Anthony Bonner
    11/1/2020 */

/* Can you survive the Haunted House?
 * You choose your path through the various rooms of the 2-story house,
 * trying to find - and survive - the source of the haunting. */

 // Pseudocode
 /* Classes:
    FirstFloor
    SecondFloor
    Chamber
    */

// Main
using System;

namespace HauntedHouseApp

static void Main(string[] args)
{
    Console.Writeline("Welcome to The Dark House, a Choose-Your-Own-Adventure story!");
    Console.Writeline("You are investigating reports of strange sounds and happenings at ");
    Console.Writeline("the abandoned Bonner Mansion, known as The Dark House.")

    Console.Writeline("To start the story, type 'c'.\n ");
    Console.Writeline("To quit, type 'q'.")

    var pageTurn = Console.Readline();

    while (pageTurn != 'c' || pageTurn != 'C' || pageTurn == 'q' || pageTurn == 'Q')
    {
        if(pageTurn == 'c') or if(pageTurn == 'C'){
            // begin the search
            houseFirstFloor();
        } else if(pageTurn == 'q') or if(pageTurn == 'Q'){
            // end the program
            break;
        }
        else
        {
            Console.Writeline("Please enter a valid selection.");
        }
    }
}

