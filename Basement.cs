using System;
using System.Text;
using static System.Console;
using HouseStory;
using System.Collections.Generic;


public class Basement
{
    public static void stairs()
    {	
        WriteLine("You enter the small room with the stairs; there's nothing of interest in the room, so you descend the stairs.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();
        
        WriteLine("The stairs end at a concrete landing. Through an archway, you see a 2nd smaller room. There are doors to the left, right, and straight ahead. The door ahead is wider and taller, but nothing else really differentiates the doors.");
        WriteLine("What would you like to do?");

        WriteLine("1. Check the Left door\n2. Check the right door\n3. Check the door Ahead\n4. Go Back up the stairs\nAnything Else: Quit the Program.");
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
        Console.Clear();
        WriteLine("You choose the door on the right.");
        WriteLine("The door opens up on a Den… but it’s not what you expected to see in that type of room. There is a soft, light-brown-colored carpet on the floor. There is a long, thick wooden table, running the length of the room, loaded with books, papers, different pens and pencils, chalks, and many small-to-medium containers filled with everything from coins to paperclips to what looks like coffee grounds.");
        WriteLine("There are some cushioned benches against each wall, along with a couple on each side of the table. There is a small window, high up on the far wall, that’s letting in a decent amount of light.\nThere are also some loaded bookcases against the wall.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();
        
        WriteLine("What would you like to do in the Den?");

        WriteLine("1. Check the Table\n2. Check the bookcases\n3. Leave the Den\nAnything Else: Quit the Program.");
        int denChoice = Int32.Parse(ReadLine());

        switch(denChoice)
        {
            case 1:
                // tableSearch
                WriteLine("You look at the items that are on the table. In addition to what you saw before, you also see equipment used for making… potions. You, however, do not know how to use the equipment, so you leave it alone. There is nothing else on the table that you decide to investigate, so you turn your attention back to the Den.");

                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                den();
                break;
            case 2:
            {
                // bookcases
                WriteLine("You check one of the bookcases. This bookcase has a variety of non-fiction and reference books, magazines, journals, and other scholarly-theme reading materials.");
                WriteLine("You thumb through the titles and pick out a handful that really catch your eye: Press 'Enter' to continue.");
                Console.ReadLine();

                bookcaseDictionary();
                break;
            }
            case 3:
                WriteLine("You decide to leave the Den and return to the Stairs.");
                stairs();
                break;
            default:
                WriteLine("You have exited the program.");
                return;
        }
    }

    public static void bookcaseDictionary()     // this should return something
    {
        var books = new Dictionary<string, string>()
        {
            {"1 Anthony Brennen","Demon Summoning"}, 
            {"2 Josie Chaldera","Glyphs, Issue 3: 'Protection Glyphs'"},
            {"3 Taryn Lee","The Power of the Full and New Moons"},
            {"4 John Peterson","Silver"}
        };

        foreach(var kvp in books)
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine(); 

        WriteLine("Type in the number in front of the author name to choose a book: ");
        var author = Int32.Parse(Console.ReadLine());

        switch(author)
        {
            case 1:
            {
                WriteLine("You chose 'Demon Summoning' by Anthony Brennen.");
                WriteLine("It is a journal-sized book, maybe 20 pages. As you skim through it, you see that it mainly deals with the details of summoning. Of particular interest are passages that deal with 2 dangers of failed summons.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                WriteLine("To summarize: 1. If the demon refuses to respond, it can cast a Curse back at the summoner, causing them to become a human-monster hybrid. 2. The demon can also attempt to possess, or outright kill, the summoner, if the summoner is weak of mind or will.");
                WriteLine("You return this disturbing book back to the shelf and leave the bookcase.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                den();
                break;
            }    
            case 2:
                WriteLine("You choose 'Protection Glyphs' by Josie Chaldera.");
                WriteLine("This is a magazine - who publishes magazines like this? - about using Glyphs as shields and containments, how to draw them, and what materials to use when drawing them.\nOne of the glyphs described is of a triangle. At each point of the triangle, a circle is drawn around then. Surrounding the whole figure is a larger circle. This Glyph is used to hold a spirit, demon, or creature within a certain area.");
                WriteLine("You take a mental note of that glyph and put the book back.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                den();
                break;
            case 3:
                WriteLine("The book by Taryn Lee details the known - and unknown - powers of the different phases of the moon. The Full Moon and various shapeshifters - like Werewolves - are listed in the 'known powers' section. But there is a mention of something called a 'Loup-Garou'. It is basically described as a demonic version of a 'super werewolf'?!?");
                WriteLine("As your blood freezes, you shove that book back onto the shelf.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                den();
                break;
            case 4:
                WriteLine("John Peterson's book, 'Silver', is more of a scientific article than a book.");
                WriteLine("It describes the power of silver, especially when involving the supernatural. It can be used in weapons, shields, and even potions to ward one's spirit.");
                WriteLine("A short but interesting article. You place it back on the bookcase.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                den();
                break;
            default:
                WriteLine("You have exited the program.");
                return;    
        }      
    }

    public static void laundryRoom()
    {
        WriteLine("You choose the door on the left.");
        WriteLine("It opens onto a Laundry Room. There is a Washer, Dryer, and a table, against the wall opposite the door. There is another table against the wall to the left of the door; that table has a small radio on it, as well as bottles of detergent and fabric softener.");
        WriteLine("You do not notice anything else of importance, leave the room, and return to the stairs landing.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();
        stairs();
    }

    public static void entertainmentRoom()
    {
        WriteLine("Through the big door is what, at first glance, appears to be a combination Entertainment Area/Bar. It is a wide room. Looking to your left, there is a bar, with 6 stools in front of it; 3 of the stools have been overturned. Next to the bar, in the wall, is a Safe with a Keypad.");
        WriteLine("Near the center of the room is a Pool Table, although it’s seen better days: the felt surface was ripped and there are multiple scratches on the table’s wooden sides and legs.");
        WriteLine("On the right side of the room, there is – WAS – a game table and chairs but said table is now in pieces; the chairs have been thrown here and there. There is a door on the far side of the right wall, and another door across the room from you. THAT door appears to be steel, iron, or some other kind of metal. Between the metal door and the door on the right wall, there are a couple of holes in the wall and more than a couple of grooves near the holes.");
        WriteLine("What would you like to do?");

        WriteLine("1. Check the Metal Door\n2. Check behind the Bar\n3. Check the door on the right wall\n4. Check the Safe\n5. Go Back to the Stairs.");
        int entRoomChoice = Int32.Parse(ReadLine());
        
        Searches.EntertainmentRoom.entRoomSearch(entRoomChoice);
        
    }
}


