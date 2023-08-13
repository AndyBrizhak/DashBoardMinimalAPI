namespace DashBoardMinimalAPI
{
    public static class StaticDetails
    {
        static StaticDetails()
        {
            for (var i = 1; i<= 20; i++)
            {
                RoomsAvailability.Add(i, Renovation);
            }
        }
        public const string Available = "available";
        public const string Busy = "busy";
        public const string Cleaning = "cleaning";
        public const string Renovation = "renovation";

        readonly static Dictionary<int, string> RoomsAvailability;
      
    }
}
