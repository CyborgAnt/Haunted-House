using System;

// encounters
public class encounters
{
    public int trappedCloset()
    {
        // initializing variables for the encounter
        var int playerRoll = 0;

        Console.WriteLine("As you open the closet door, you see a ghostly hand reach for you!");
        Console.WriteLine("Pick a number between 1 and 20, to see if you dodge this hand...: ");
        playerRoll = Console.ReadLine();
        int closetRoll = random.Next(1, 21);       // SHOULD generate a random number between 1 and 20

        if(playerRoll >= closetRoll)
        {
            handSurvived();
        } else if((playerRoll - closetRoll) <= -5) {
            handDeath();
        } else {
            handPassedThrough();
        }

    }

    public void handDeath()
    {
        Console.WriteLine("You try to dodge the hand but it is too quick. It latches onto your face. Black, smoky tendrils erupt from the hand and wrap around your head. You sink to the ground as your life essence is drained away. You hear a deep, sinister laughter accompanying you into darkness....");
        // need a 'Break'?
    }
    public void handPassedThrough()
    {
        Console.WriteLine("The hand reaches for your chest... and passes through it. There was no physical effects but you are pretty frightened afterwards. You hear, in the distance, a low, ominous chuckle. You continue on.\n");
        // need a Break?
    }
    public void handSurvived()
    {
        Console.WriteLine("The hand reaches for you... but you manage to dodge to one side. It passes through the wall of the hallway, and disappears. You hear a short but low chuckle from... somewhere. You decide what to do next: ");
        hallway();
        // test this decision
    }





}