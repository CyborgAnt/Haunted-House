// Main Story
class FirstFloor
{
    
    public void entry()
    {
        Console.WriteLine("You enter the house, starting in a small entryway. There are a couple of small end tables in the entry, with pictures and and flowers on them.");
        Console.WriteLine("There is a closet in the left corner on the entry, with it's door open. Inside are a few coats, jackets, and pairs of dress shoes. Directly ahead of you is a nalong, narrow hallway.");
        Console.WriteLine("To your left is a door that's closed. To your right, there is a partially opened door that opens onto a large, dimly lit room, possibly a Lving Room.");

        var roomChoice = 0
        Console.WriteLine("\nWyhat would you like to do?");
        roomChoice = Console.ReadLine();
        Console.WriteLine("1. Contine down the Hall.\n
                            2. Open the door to the left.\n
                            3. Go into the Living Room.\n
                            4. Check the Closet.\n
                            Anything else to Quit");
        // need to test the 'switch' and methods with it
        switch (roomChoice)
        {
            case 1: hallway();
            case 2: library();
            case 3: livingRoom();
            case 4: closet();   // put under Generic Search   
            default:
                Console.WriteLine("You have exited the program.");
        }


    }
    public void study()
    {
        Console.WriteLine("You open the door to the left of the hallway and enter the room. It appears to be a large study and library.\n There are shelves and shelves of books, books of every size and bindings. There is a very large window that looks out on the neighborhood, to the left.");
        Console.WriteLine("There are very comfortable-looking chairs throughout the room, as well as benches along the walls.")
        //continue later
    }
    public void hallway()
    {
        Console.WriteLine("You start down the hallway.\n");
        Console.WriteLine("The hall passes the Living Room. On the left, there are a couple of doors, probably closets or storage areas. A little further ahead, a smaller hallway branches off to the left.\n The main hallway ends at a T-section, but there are doors ahead, on either side of the hall.");

        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Check the first closet.\n
                            2. Check the second closet.\n
                            3. Take the smaller hall branch.\n
                            4. Continue down the main hallway.");

        var hallwayChoice = Console.ReadLine();

        switch(hallwayChoice)
        {
            case 1: closetOneSearch(); // use for other choices
            case 2: closetTwoSearch(); // encounter
            case 3: smallerHall();
            case 4: hall2();
        }
    }
    public void livingRoom()
    {
        Console.WriteLine("You enter the Living Room. If would be a really nice living room, if it didn't look like it had been recently ramsacked.\n")
        Console.WriteLine("A large couch, that once looked like it was up against the left wall, has been pulled out to the center of the room. A loveseat is laying on it's side, next to the couch. \nThere is a mantle piece against the right wall. In front of the Mantle are the remains of what appears to be a coffee table - it looks like it was thrown against the mantle.");
        Console.WriteLine("There is a door on the opposite side of the room from you; the door is damaged, as if someone - or something - kicked it open.");

        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Search the Living Room.\n
                            2. Check the Mantle.\n
                            3. Check the Couch.\n
                            4. Check the Loveseat.\n
                            5. Head to the Damaged Door.\n
                            6. Head back to the Hall.\n");

        var livingRoomChoice = Console.ReadLine();
        // use 'switch' and 'case'
        // Noth, Flavor, Locket, Noth, ?, Hall


    }
    public void diningRoom()
    {
        Console.WriteLine("You enter the Dining Room.");
        Console.WriteLine("There is a large wooden table in the center of the room. Most of the chairs around the table were overturned. There are some china cabinets in 2 of the corners of the room. Other than a large, draped window, there is nothing of note in the Dining Room.");

        var diningRoomChoice = 0;
        Console.WriteLine("What do you do next?\n");
        Console.WriteLine("1. Return to Bedroom.\n
                            2. Return to Hallway.\n
        
        // switch and cases

    }
    public void kitchen()
    {
        kitchenPortalSkull = 0;
        var kitchenChoice = 0;
        
        Console.WriteLine("You enter the Kitchen.");
        Console.WriteLine("There is an... odd aire about the room: it feels like the room is electrically charged. You see your standard Kitchen equipment: stove, refrigerator, cabintes, and dishes. There is nothing special about them, although you keep getting drawn to the stove.\n There is a center island, with a few tall stools around it. There are some odds and ends on the island counter. There is also a small room-within-a-room, in the far corner; there appear to be stairs that lead down into darkness.");
        Console.WriteLine("As you continue your search, you notice some odd things about the room: there are two spots on the wall, next to the stairs, that seem to be glowing. One is glowing a pale green, the other a pale, sickly yellow. There is also a large, red stain on the floor, in front of the room with the stairs.");
        Console.WriteLine("You have a lot of choices - what do you do?");

        kitchenChoice = Console.ReadLine();
        //loop back to this menu
        Console.WriteLine("1. Investigate the Red Stain. \n
                            2. Investigate the Green glow.\n
                            3. Investigate the Yellow glow.\n
                            4. Check the room with the Stairs.\n
                            5. Check the Island Counter.\n
                            6. Leave the kitcken.");
        //switch and cases: herring/descr., gd, bd, avg, flavor
        


    }
    public void bedroom1()
    {

    }
    public void masterBedoom()
    {

    }

}