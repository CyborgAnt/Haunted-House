// Pseudocode for Room and Item Searches
namespace Searches
{
    public class LivingRoomSearch
    {
        public void livingRoom()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Search the Living Room.\n
                            2. Check the Mantle.\n
                            3. Check the Couch.\n
                            4. Check the Loveseat.\n
                            5. Head to the Damaged Door.\n
                            6. Head back to the Hall.\n");

            var livingRoomChoice = Console.ReadLine();
            switch(livingRoomChoice)
            {
                case 1:
                    // code
                case 2:
                {

                }   
                case 3:
                {

                } 
                case 4:
                {

                }
                case 5:
                {

                }
                default:
                    // code
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