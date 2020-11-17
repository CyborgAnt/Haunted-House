/* Anthony Bonner
    11/1/2020 */


using System;
using System.Text;
using static System.Console;

namespace HouseStory
{
    class FirstFloor
    {
        /*public FirstFloor()
        {
        } */

        public static void entryway()
        {
            Console.WriteLine("You start in a small entryway. There are a couple of small end tables in the entry, with pictures and and flowers on them.");
            Console.WriteLine("There is a closet in the left corner on the entry, with it's door open. Inside are a few coats, jackets, and pairs of dress shoes. Directly ahead of you is a long, narrow hallway.");
            Console.WriteLine("To your left is a door that's closed. To your right, there is a partially opened door that opens onto a large, dimly lit room, possibly a Living Room.");

            Console.WriteLine("What would you like to do? Enter a number: ");
            WriteLine("1. Contine down the Hall, 2. Open the door to the left, 3. Go into the Living Room, 4. Check the Closet, Anything else to Quit");

            var roomChoice = Int32.Parse(ReadLine());

            // need to test the 'switch' and methods with it
            switch (roomChoice)
            {
                case 1:
                    hall();
                    break;
                case 2:
                    dining();
                    break;
                case 3:
                    LivingRoom();
                    break;
                case 4:
                    WriteLine("You see some old clothes and shoes, but nothing else of interest.");
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
            Console.WriteLine("You start down the hallway.\n");
            Console.WriteLine("The hall passes by the Living Room. As you continue down the hall, there are a couple of doors on your left, probably closets or storage areas. A little further ahead, a smaller hallway branches off to the right. The main hallway ends at a T-section.");

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Check the first closet, 2.Check the second closet, 3.Take the smaller hall branch, 4.Continue down the main hallway to the T-section.");

            var hallwayChoice = Int32.Parse(Console.ReadLine());

            switch (hallwayChoice)
            {
                case 1:
                    WriteLine("You check the first closet. There are some magazines, some hats, and other odds and ends on the top shelf. There are some cleaning supplies and a broom on the floor. A few boxes on the floor reveal files, papers, and magazines. Nothing else of interest is found.");
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

            WriteLine("What do you want to do?");
            WriteLine("1. Check the Left branch bedroom, 2. Check the right branch bedroom, 3. Go back to the Entry");
            int hallBranchChoice = Int32.Parse(ReadLine());

            switch (hallBranchChoice)
            {
                case 1:
                    bedroom();
                    break;
                case 2:
                    masterbedroom();
                    break;
                case 3:
                    entryway();
                default:
                    break;
            }

        }
        
        static void dining()
        {
            // code
            Console.WriteLine("You enter the Dining Room.");
            Console.WriteLine("There is a large wooden table in the center of the room. Most of the wooden chairs around the table were overturned. There are some china cabinets in 2 of the corners of the room. Other than a large, draped window, there is nothing else of note visible in the Dining Room.");

            Console.WriteLine("What do you do next?\n");
            Console.WriteLine("1. Go to the Bedroom, 2.Return to the Hallway.");

            var diningRoomChoice = Int32.Parse(ReadLine());
            switch (diningRoomChoice)
            {
                case 1:
                    bedroom();      // need code
                    break;
                case 2:
                    hall();
                    break;
                default:
                    return;         // change?
            }    

        }
                
        static void LivingRoom()
        {
            // code
            WriteLine("You enter the Living Room. If would be a really nice living room, if it didn't look like it had been recently ramsacked.\n");
            WriteLine("A large couch, that once looked like it was up against the left wall, has been pulled out to the center of the room. A loveseat is laying on it's side, next to the couch. \nThere is a mantle piece against the right wall. In front of the Mantle are the remains of what appears to be a coffee table - it looks like it was thrown against the mantle.");
            WriteLine("There is a door on the opposite side of the room from you; the door is damaged, as if someone - or something - kicked it open.");

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Search the Living Room, 2. Check the Mantle, 3. Check the Couch, 4. Check the Loveseat, 5. Head to the Damaged Door, 6. Head back to the Hall.\n");

            var livingRoomChoice = Int32.Parse(Console.ReadLine());

            switch (livingRoomChoice)
            {
                case 1:
                    // search the living room
                    break;
                case 2:
                    // Mantle Search
                    break;
                case 3:
                    // Couch Search
                    break;
                case 4:
                    // Loveseat Search
                    break;
                case 5:
                    smallerHall(); // not typed yet
                    break;    
                case 6:
                    hall();
                    break;
                default:
                    break; // change?
            }
        }

        static void smallerHall()
        {
            WriteLine("You move down the smaller hallway to the right.");
            WriteLine("It's a wider but shorter path, compared to the main hallway. Some simple artwork dot both sides of the hall. On the left side of the hall, there is a broken door that looks in on the kitchen. On the right side, there is another broken door, this one leading into the Living Room. Ahead of you, the hall ends at a door that leads to the outside.");
            WriteLine("What do you do?");

            WriteLine("1. Go into the Kitchen, 2. Go into the Living Room, 3. Go outside, via the Door, 4. Go back to the Main Hall.");
            int smallHallChoice = Int32.Parse(ReadLine());

            switch (smallHallChoice)
            {
                case 1:
                    kitchen();
                    break;
                case 2:
                    LivingRoom();
                    break;
                case 3:
                   //check for locket
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
            Console.WriteLine("You enter the Bedroom.");
            Console.WriteLine("It's a large, nice bedroom, not suffering from the ramsacked appearance of most of the rest of the house. There is a Queen-sized bed, along with a couple of night stands and a dresser. On top of one stand is a small lamp and an alarm clock. There's not much of interest on the other stand. A large mirror is on top of the dresser.\n");
            Console.WriteLine("There are a couple of closets in the bedroom, one to the left of the door, one on the opposite right corner; both closet doors are closed.");
            var bedroom1Search = 0;

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Investigate the Bed, 2.Investigate the Left Closet, 3.Investigate the Right Closet, 4.Investigate the Dresser, 5.Leave the Bedroom.");

            bedroom1Search = Int32.Parse(ReadLine());

            switch (bedroom1Search)
            {
                case 1:
                    // nothing
                    break;
                case 2:
                    // nothing
                    break;
                case 3:
                    // not sure
                    break;
                case 4:
                    // gun in box 
                    break;
                case 5:
                    WriteLine("You leave the bedroom.");
                    // double-check Map
                    break;           
                default:
                    bedroom();
                    break;
            }
        }

        public static void masterBedoom()
        {
            WriteLine("You enter a bedroom that might be as large as some apartments - the Master Bedroom.");
            WriteLine("There is a King-sized bed in the center of the room, with dark blue sheets, a blue and black comforter, and many pillows. Looking from the doorway, there is a large window on the right wall and a floor-to-near ceiling window on the wall opposite from you.");
            WriteLine("There is a large, walk-in closet in the far left corner of the room. There is a large fan-and-light-fixture on the ceiling, above the bed, and a floor lamp next to the door.");
            WriteLine("Next to the window on the right wall, there is a large wardrobe, about 7 feet tall. The doors of the wardrobe are closed but there are scratch marks on them.");
            WriteLine("There are also some odds and ends around the room: some clothes on the floor, a small table next to the wardrobe, and some books on the bed. As you walk around the room, you do notice a faint but foul odor. You cannot tell where the odor is coming from, though.");

            WriteLine("What do you do next?");

            WriteLine("1. Check the Closet, 2. Check the Wardrobe, 3. Check the Bed, 4. leave the Master Bedroom.");
            int masterBedroomChoice = Int32.Parse(ReadLine());

            switch (masterBedroomChoice)
            {
                case 1:
                    // closet
                    WriteLine("You check the walk-in closet. There isn't much in there of interest.");
                    masterBedoom();
                    break;
                case 2:
                    // Wardrobe - BODY
                    
                    break;
                case 3:
                    // bed - BULLETS under bed
                    break;        
                default:
                    break;
            }

        }



        static void kitchen()
        {
            var kitchenChoice = 0;

            WriteLine("You enter the Kitchen.");
            WriteLine("There is an... odd aire about the room: it feels like the room is electrically charged. You see your standard Kitchen equipment: stove, refrigerator, cabinets, and sink. There is nothing special about them, although your eyes keep getting drawn to the stove.\n There is a center island, with a few tall stools around it. There are some odds and ends on the island counter but nothing of particular interest. In the far corner is a small alcove, with stairs that lead down into darkness.");
            WriteLine("As you continue your search, you notice some odd things about the room: there are two spots on the wall, next to the stairs, that seem to be glowing. One is glowing a pale green, the other a pale, sickly yellow; there are no doors at these spots but there has to be some kind of room or rooms that's giving off these glows.");
            WriteLine("Disturbingly, there is also a large, red stain on the floor, in front of the room with the stairs. You are fairly certain that it is blood.");
            Console.WriteLine("You have a lot of choices - what do you do?");

            kitchenChoice = Int32.Parse(Console.ReadLine());
            //loop back to this menu
            Console.WriteLine("1. Investigate the Oven, 2.Investigate the Green glow, 3.Investigate the Yellow glow, 4.Check the room with the Stairs, 5.Check the Island Counter, 6. Leave the kitcken.");
            //switch and cases: herring/descr., gd, bd, avg, flavor

            Searches.KitchenSearch.kitchenSearch(kitchenChoice);

    }

    class Basement
    {
        public static void stairs()
        {
            //Choices: Laundry-Right, Guest Room-Left, Entertainment Room-Ahead
        }
        public static void guestRoom()
        {
            //Pictures of Family; kids not present
        }
        public static void laundryRoom()
        {
            //nothing of importance
        }
        public static void entertainmentRoom()
        {
            //Safe - GUN, code in Yellow Glow Kitchen room
            //Bathroom off to side - flavor text
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
                entry();
        }
    }




}   

    
/*

        
        
        


        }
        public void masterBedoom()
        {
            
        }
        public void study()
        {
            Console.WriteLine("You open the door to the left of the hallway and enter the room. It appears to be a large study or library.\n There are shelves and shelves of books, books of every size and bindings. There is a very large window that looks out on the neighborhood, to the left.");
            Console.WriteLine("There are very comfortable-looking chairs throughout the room, as well as benches along the walls.");
            Console.WriteLine("Do you search the room? ");

            Console.WriteLine("1. Yes.\n
                            2.No - Leave the Study.\n");
            var int studySearch = Console.ReadLine();

            switch (studySearch)
            {
                case 1:
                // code
                case 2:
                    {
                        Console.WriteLine("The room is nice, cozy, almost inviting you to sit for a spell... but you resist. You return to the Entry.");
                        entry();
                        // maybe code this to return to the Entry Decision, instead
                    }

            }
        }
    }


    }
    */