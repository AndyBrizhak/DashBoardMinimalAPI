using DashBoardMinimalAPI.Models;

namespace DashBoardMinimalAPI
{
    public static class SD
    {
        //public static readonly Dictionary<int, string> RoomsStatus;
        //static StaticDetails()
        //{
        //    RoomsStatus = new Dictionary<int, string>();
        //    for (var i = 1; i <= 20; i++)
        //    {
        //        RoomsStatus.Add(i, Renovation);
        //    }
        //}
        public readonly static List<string> State;
        public static List<Room> Rooms;
        public const string Available = "available";
        public const string Busy = "busy";
        public const string Cleaning = "cleaning";
        public const string Renovation = "renovation";

        static SD()
        {
            //State = new List<string>();
            //State.Add(SD.Available);
            //State.Add(SD.Busy);
            //State.Add(SD.Cleaning);
            //State.Add(SD.Renovation);

            Rooms = new List<Room>();
            for (var i = 1; i <= 20; i++)
            {
                var room = new Room();
                room.Id = i;
                room.Name = i.ToString();
                room.Status = SD.Renovation;
                Rooms.Add(room);
            }
        }



    }
}
