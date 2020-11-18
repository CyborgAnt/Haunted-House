using System;
using System.Text;
using static System.Console;
using HouseStory;

public class Basement
{
    public static void stairs()
    {	
        WriteLine("The stairs end at a concrete landing. Through an archway, you see a 2nd smaller room. There are doors to the left, right, and straight ahead. The door ahead is wider and taller, but nothing else really differentiates the doors.");
        WriteLine("What would you like to do?");

        WriteLine("1. Check the Left door, 2. Check the right door, 3. Check the door Ahead, 4. Go Back up the stairs");
        int stairsChoice = Int32.Parse(ReadLine());

        switch(stairsChoice)
        {
            case 1:
                laundryRoom();
                break;
            case 2:
                den();
                break;
            case 3:
                entertainmentRoom();
                break;
            case 4:
                WriteLine("You change your mind and head back up the stairs and re-enter the kitchen.");
                FirstFloor.kitchen();		// have to check this
                break;
            default:
                break;
        }
    }

    public static void den()
    {
        WriteLine("You choose the door on the right.");
        WriteLine("The door opens up on a Den… but it’s not what you expected to see in that type of room. There is a soft, light-brown-colored carpet on the floor. There is a long, thick wooden table, running the length of the room, loaded with books, papers, different pens and pencils, chalks, and many small-to-medium containers filled with everything from coins to paperclips to what looks like coffee grounds.");
        WriteLine("There are some cushioned benches against each wall, along with a couple on each side of the table. There is a small window, high up on the far wall, that’s letting in a decent amount of light. There are also some loaded bookcases against the wall.");
        WriteLine("What would you like to do in the Den?");

        WriteLine("1. Check the Table, 2. Check the bookcases, 3. Leave the Den.");
        int denChoice = Int32.Parse(ReadLine());

        switch(denChoice)
        {
            case 1:
                // tableSearch
                WriteLine("You look at the items that are on the table. In addition to what you saw before, you also see equipment used for making… potions. You, however, do not know how to use the equipment, so you leave it alone. There is nothing else on the table that you decide to investigate.");
                break;
            case 2:
                // bookcases
                WriteLine("You find -USE DICTIONARY- ");
                break;
            case 3:
                WriteLine("You decide to leave the Den and return to the Stairs.");
                stairs();
                break;
            default:
                break;
        }
    }

    public static void laundryRoom()
    {
        WriteLine("You choose the door on the left.");
        WriteLine("It opens onto a Laundry Room. There is a Washer, Dryer, and a table, against the wall opposite the door. There is another table against the wall to the left of the door; that table has a small radio on it, as well as bottles of detergent and fabric softener.");
        /* WriteLine("Oddly, there is a set of numbers written on -- : ‘7520’. You make a note of that.");  put this in the Den */
        WriteLine("You do not notice anything else of importance and leave the room.");
        stairs();
    }

    public static void entertainmentRoom()
    {
        WriteLine("Through the big door is what, at first glance, appears to be a combination Entertainment Area/Bar. It is a wide room. Looking to your left, there is a bar, with 6 stools in front of it; 3 of the stools have been overturned. Next to the bar, in the wall, is a Safe with a Keypad.");
        WriteLine("Near the center of the room is a Pool Table, although it’s seen better days: the felt surface was ripped and there are multiple scratches on the table’s wooden sides and legs.");
        WriteLine("On the right side of the room, there is – WAS – a game table and chairs but said table is now in pieces; the chairs have been thrown here and there. There is a door on the far side of the right wall, and another door across the room from you. THAT door appears to be steel, iron, or some other kind of metal. Between the metal door and the door on the right wall, there are a couple of holes in the wall and more than a couple of grooves near the holes.");
        WriteLine("What would you like to do?");

        WriteLine("1. Check the Metal Door, 2. Check behind the Bar, 3. Check the door on the right wall, 4. Check the Safe, 5. Go Back to the Stairs.");
        int entRoomChoice = Int32.Parse(ReadLine());
        
        Searches.EntertainmentRoom.entRoomSearch(entRoomChoice);
        
    }
}


