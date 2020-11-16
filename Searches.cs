using System;
using System.Text;
using static System.Console;
using HouseStory;

// Pseudocode for Room and Item Searches
namespace Searches
{
    public class LivingRoomSearch
    {
        public void livingRoom()
        {
            WriteLine("What would you like to do?");
            WriteLine("1. Search the Living Room, 2. Check the Mantle, 3. Check the Couch, 4. Check the Loveseat, 5. Head to the Damaged Door, 6. Head back to the Hall.");

            var livingRoomChoice = Int32.Parse(Console.ReadLine());
            switch(livingRoomChoice)
            {
                case 1:
                {    
                    WriteLine("You do a search of the Living Room but find nothing of interest.");
                    break;
                }
                case 2:
                {
                    
                    break;
                }   
                case 3:
                {

                    break;
                } 
                case 4:
                {
                    WriteLine("You search the Loveseat. You find nothing under the cushions or in the back of the seat.");
                    break;
                }
                case 5:
                {

                    break;
                }
                case 6:
                {
                    WriteLine("You decide to head back to the Hallway.");
                    FirstFloor.mainHall();
                    break;
                }
                default:
                    // code
                    break;
            }
        }






    }
    public class MasterBedroomSearch
    {
        /* ClosetLeftSearch()
            ClosetRightSearch()
            BedSearch()
            DresserSearch()
            Other?
        */
    }
    public class BedroomSearch
    {
        /* ClosetOneSearch()
            ClosetTwoSearch()
            Bookcase() - 'puzzle'?
            BedSearch()
        */    
    }
    public class KitchenSearch
    {
        /* CabinetSearch()
            OpenWallSpot
            RoomSearchK() - floor Dr
            More
        */    
    }

}