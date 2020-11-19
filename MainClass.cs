/* Anthony Bonner
    11/1/2020 */


using System;
using System.Text;
using static System.Console;

namespace HouseStory
{
    class FirstFloor
    {
        public static void entryway()
        {
            Console.WriteLine("You begin in a small entryway. There are a couple of small end tables in the entry, with pictures and and flowers on them.");
            Console.WriteLine("There is a closet in the left corner on the entry, with it's door open. Inside are a few coats, jackets, and pairs of dress shoes. Directly ahead of you is a long, narrow hallway.");
            Console.WriteLine("To your left is a door that's closed. To your right, there is a partially opened door that opens onto a large, dimly lit room, possibly a Living Room.");

            Console.WriteLine("What would you like to do? Enter a number: ");
            WriteLine("1. Contine down the Hall, 2. Open the door to the left, 3. Go into the Living Room, 4. Check the Closet, Anything else to Quit");

            var roomChoice = Int32.Parse(ReadLine());

            Console.Clear();        //will use this method to keep the console clutter to a minimum
            switch (roomChoice)
            {
                case 1:
                    hall();
                    break;
                case 2:
                    dining();
                    break;
                case 3:
                    livingRoom();
                    break;
                case 4:
                    WriteLine("You see some old clothes and shoes, but nothing else of interest. You return to the Entry.\n");
                    entryway();
                    break;
                default:
                    WriteLine("You have exited the program.");
                    return;
            }
        }

        public static void hall()
        {
            // code
            Console.WriteLine("You enter the hallway.\n");
            Console.WriteLine("The hall passes by the Living Room. As you continue down the hall, there are a couple of doors on your left, probably closets or storage areas. A little further ahead, a smaller hallway branches off to the right. The main hallway ends at a T-section.");

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Check the first closet, 2.Check the second closet, 3.Take the smaller hall branch, 4.Continue down the main hallway to the T-section.");

            var hallwayChoice = Int32.Parse(Console.ReadLine());

            Console.Clear();
            switch (hallwayChoice)
            {
                case 1:
                    WriteLine("You check the first closet. There are some magazines, some hats, and other odds and ends on the top shelf. There are some cleaning supplies and a broom on the floor. A few boxes on the floor reveal files, papers, and magazines. Nothing else of interest is found.");
                    hall();
                    break;
                case 2:
                    var closet = new Haunts();                    
                    closet.trappedCloset(); // encounter
                    break;
                case 3:
                    smallerHall();
                    break;
                case 4:
                    hallContinue();
                    break;
            }
        }

        public static void hallContinue()
        {
            WriteLine("At the end of the hall, you come upon another hall, running perpendicular to the Main Hall. On the left branch, there is a door on the right side; on the right branch, there is a door on the left side. These are likely bedrooms.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            WriteLine("What do you want to do?");
            WriteLine("1. Check the Left branch bedroom, 2. Check the right branch bedroom, 3. Go back to the Entry");
            int hallBranchChoice = Int32.Parse(ReadLine());

            Console.Clear();
            switch (hallBranchChoice)
            {
                case 1:
                    bedroom();
                    break;
                case 2:
                    masterBedroom();
                    break;
                case 3:
                    entryway();
                    break;
                default:
                    break;
            }

        }
        
        static void dining()
        {
            // code
            Console.WriteLine("You open the door and enter the Dining Room.");
            Console.WriteLine("There is a large wooden table in the center of the room. Most of the wooden chairs around the table were overturned. There are some china cabinets in 2 of the corners of the room. Other than a large, draped window, there is nothing else of note visible in the Dining Room. There is also an open archway that opens onto the Kitchen.");

            Console.WriteLine("What do you do next?\n");
            Console.WriteLine("1. Go to the kitchen, 2.Return to the Hallway.");

            var diningRoomChoice = Int32.Parse(ReadLine());
            Console.Clear();
            switch (diningRoomChoice)
            {
                case 1:
                    kitchen();
                    break;
                case 2:
                    hall();
                    break;
                default:
                    return;         // change?
            }    

        }
                
        static void livingRoom()
        {
            Console.Clear();
            WriteLine("You enter the Living Room. If would be a really nice living room, if it didn't look like it had been recently ramsacked.\n");
            WriteLine("A large couch, that once looked like it was up against the left wall, has been pulled out to the center of the room. A loveseat is laying on its side, next to the couch. \nThere is a mantle piece against the right wall. In front of the Mantle are the remains of what appears to be a coffee table - it looks like it was thrown against the mantle.");
            WriteLine("There is a door on the opposite side of the room from you; the door is damaged, as if someone - or something - kicked it open.");

            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Search the Living Room, 2. Check the Mantle, 3. Check the Couch, 4. Check the Loveseat, 5. Head to the Damaged Door, 6. Head back to the Hall.\n");

            var livingRoomChoice = Int32.Parse(ReadLine());

            Console.Clear();
            switch(livingRoomChoice)
            {
                case 1:
                {    
                    WriteLine("You do a search of the Living Room but find nothing of interest.");
                    break;
                }
                case 2:
                {
                    WriteLine("On the Mantle, you find a pamphlet: 'Reverse the Curse!'. There is a lot of occult information and drawings about various curses, their causes, and if they are reverseable.");
                    WriteLine("One passage particularly catches your attention, as most of it is highlighted:");
                    string[] lines = System.IO.File.ReadAllLines(@"pamphlet.txt");

                    System.Console.WriteLine("Contents of WriteLines2.txt = ");
                    foreach (string line in lines)
                    {
                        Console.WriteLine("\t" + line);
                    }

                    // Keep the console window open in debug mode.
                    Console.WriteLine("Press any key to exit.");
                    System.Console.ReadKey();

                    WriteLine("You pocket the disturbing pamphlet - it might be of use, later. You continue in the Living Room.");
                    livingRoom();
                    break;
                }   
                case 3:
                {
                    WriteLine("You search the Couch. There's nothing on the Couch but you see a silver-grey glint in between two of the cushions. Removing the cushions, you find a LOCKET. \nOpening it, you see a photograph of a tall man and an equally tall woman. \nOn the back of the Locket is an inscription: 'May you always be protected by love and family.'");
                    WriteLine("You also notice that the Locket felt... warm... when you opened it. As you close the Locket, it goes back to a normal temperature. You slip the Locket around your neck and leave the Living Room.");
                    bool protection = true;     // use in Final Battle
                    FirstFloor.hall();
                    break;
                } 
                case 4:
                {
                    WriteLine("You search the Loveseat. You find nothing under the cushions or in the back of the seat.");
                    break;
                }
                case 5:
                {
                    WriteLine("You force the Damaged Door open enough to squeeze through, and up in a small hallway.");
                    FirstFloor.smallerHall();    
                    break;
                }
                case 6:
                {
                    WriteLine("You decide to head back to the Hallway.");
                    FirstFloor.hall();
                    break;
                }
                default:
                    // code
                    break;
            }
        }

        public static void smallerHall()
        {
            WriteLine("You move down the smaller hallway to the right.");
            WriteLine("It's a wider but shorter path, compared to the main hallway. Some simple artwork dot both sides of the hall. On the left side of the hall, there is a broken door that looks in on the kitchen. On the right side, there is another broken door, this one leading into the Living Room. Ahead of you, the hall ends at a door that leads to the outside.");
            WriteLine("What do you do?");

            WriteLine("1. Go into the Kitchen, 2. Go into the Living Room, 3. Go outside, via the Door, 4. Go back to the Main Hall.");
            int smallHallChoice = Int32.Parse(ReadLine());

            Console.Clear();
            switch (smallHallChoice)
            {
                case 1:
                    kitchen();
                    break;
                case 2:
                    livingRoom();
                    break;
                case 3:
                    WriteLine("You open the door and look outside. The full moon is bright, the night is cool and still, pretty peaceful. Nevertheless, you go back inside, shut the outdoor, and go back to the main Hall.");
                    hall();
                    break;

                case 4:
                    WriteLine("You decide to skip the doors in this hall and return to the Main Hall.");
                    hall();
                    break; 
                default:
                    break;
            }

        }

        static void bedroom()
        {
            Console.WriteLine("You enter a Bedroom.");
            Console.WriteLine("It's a large, nice bedroom, not suffering from the ramsacked appearance of most of the rest of the house. There is a Queen-sized bed, along with a couple of night stands and a dresser. On top of one stand is a small lamp and an alarm clock. There's not much of interest on the other stand. A large mirror is on top of the dresser.\n");
            Console.WriteLine("There are a couple of closets in the bedroom, one to the left of the door, one on the opposite right corner; both closet doors are closed.");
            var bedroom1Search = 0;

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Investigate the Left Closet, 2.Investigate the Right Closet, 3.Investigate the Dresser, 4.Leave the Bedroom.");

            bedroom1Search = Int32.Parse(ReadLine());

            Console.Clear();
            switch (bedroom1Search)
            {
                case 1:
                    // nothing
                    WriteLine("You find nothing of interest in the closet.");
                    bedroom();
                    break;
                case 2:
                    // nothing
                    WriteLine("There are some coats, jackets, and an assortment of miscellaneous clothes. You find nothing else of interest in this closet.");
                    bedroom();
                    break;
                case 3:
                    // not sure
                    WriteLine("You don't find anything on top of the dresser. As you check the top drawer, you find a picture frame. The picture inside is of a auburn-haired woman, of average build but tall-appearing, sitting in a chair, with a warm smile on her face. Standing behind the chair is a dark haired, tall, thin man, grinning at the camera. A word and a date are written below:");
                    WriteLine("Before, 7/5/20");
                    WriteLine("You take the picture frame.");
                    bedroom();
                    break;
                case 4:
                    WriteLine("You leave the bedroom.");
                    // double-check Map
                    break;         
                default:
                    bedroom();
                    break;
            }
        }

        public static void masterBedroom()
        {
            WriteLine("You enter a bedroom that might be as large as some apartments - the Master Bedroom.");
            WriteLine("There is a King-sized bed in the center of the room, with dark blue sheets, a blue and black comforter, and many pillows. \nLooking from the doorway, there is a large window on the right wall and a floor-to-near ceiling window on the wall opposite from you.");
            WriteLine("There is a large, walk-in closet in the far left corner of the room. \nThere is a large fan-and-light-fixture on the ceiling, above the bed, and a floor lamp next to the door. \nNext to the window on the right wall, there is a large wardrobe, about 7 feet tall. The doors of the wardrobe are closed but there are scratch marks on the front of them.");
            WriteLine("There are also some odds and ends around the room: some clothes on the floor, a small table next to the wardrobe, and some books on the bed. \nAs you walk around the room, you do notice a faint but foul odor. You cannot tell where the odor is coming from, though.");

            WriteLine("What do you do next?");

            WriteLine("1. Check the Closet, 2. Check the Wardrobe, 3. Check the Bed, 4. Leave the Master Bedroom.");
            int masterBedroomChoice = Int32.Parse(ReadLine());

            Console.Clear();
            switch (masterBedroomChoice)
            {
                case 1:
                    // closet
                    WriteLine("You check the walk-in closet. There isn't much in there of interest.");
                    masterBedroom();
                    break;
                case 2:
                    // Wardrobe - BODY
                    WriteLine("As you move towards the Wardrobe, that odor gets stronger. You grab the handles, open the door...");
                    WriteLine("... and a body tumbles out!!");
                    WriteLine("\nIt appears to be a man, at least 6 and half feet tall, with long, salt-and-pepper hair. His lower body seems fine - wearing gray slacks - but his upper body is a mess. Deep slashes cover his chest and mid-section. There is a deep gash between his left shoulder and neck - possibly a bite mark?. His face is frozen in a mix of fright and... recognition?");
                    WriteLine("This is a very disturbing site! Do you stay in the Master Bedroom?");

                    WriteLine("1. Yes, 2. No");
                    int wardrobeChoice = Int32.Parse(ReadLine());

                    if(wardrobeChoice != 1)
                        FirstFloor.hallContinue();
                    else
                        FirstFloor.masterBedroom();    
                    break;
                case 3:
                    // bed - BULLETS under bed
                    WriteLine("There is nothing remarkable about the bed. \nHowever, as you take a glance UNDER the bed, you find a small box. Pulling out the box, you find SILVER BULLETS. You dump the bullets into your pants pockets; you might need these later.");
                    masterBedroom();
                    break;        
                default:
                    break;
            }

        }

        public static void kitchen()
        {
            var kitchenChoice = 0;

            WriteLine("You enter the Kitchen.");
            WriteLine("There is an... odd aire about the room: it feels like the room is electrically charged. You see your standard Kitchen equipment: stove, refrigerator, cabinets, and sink. There is nothing special about them, although your eyes keep getting drawn to the stove.\n There is a center island, with a few tall stools around it. There are some odds and ends on the island counter but nothing of particular interest. In the far corner is a small alcove, with stairs that lead down into darkness.");
            WriteLine("As you continue your search, you notice some odd things about the room: there are two spots on the wall, next to the stairs, that seem to be glowing. One is glowing a pale green, the other a pale, sickly yellow; there are no doors at these spots but there has to be some kind of room or rooms that's giving off these glows.");
            WriteLine("Disturbingly, there is also a large, red stain on the floor, in front of the room with the stairs. You are fairly certain that it is blood.");
            Console.WriteLine("You have a lot of choices - what do you do?");

            //loop back to this menu
            Console.WriteLine("1. Investigate the Oven, 2.Investigate the Green glow, 3.Investigate the Yellow glow, 4.Check the room with the Stairs, 5.Check the Island Counter, 6. Leave the kitcken.");
            //switch and cases: herring/descr., gd, bd, avg, flavor
            kitchenChoice = Int32.Parse(ReadLine());

            Console.Clear();
            Searches.KitchenSearch.kitchenSearch(kitchenChoice);
        }
    }
    
    class MainClass
    {
        public static void Main(string[] args)
        {
            WriteLine("Welcome to The Dark House, a Choose-Your-Own-Adventure Story!");
            WriteLine("You are investigating rumors of strange sights and sounds coming from an old house.");
            WriteLine("Will you find out the source of the problems? Will you survive the night? it all depends on what choices you make!");
            WriteLine("Press '1' to continue, '0' to quit:");

            var playerChoice = Int32.Parse(ReadLine());     // should convert input to an integer
            // var entryHall = new FirstFloor();

            if (playerChoice != 1)
                return;
            else
                FirstFloor.entryway();
        }
    } 
}    
