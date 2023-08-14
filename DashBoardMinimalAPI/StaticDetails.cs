namespace DashBoardMinimalAPI
{
    public static class StaticDetails
    {
        public static readonly Dictionary<int, string> RoomsStatus;
        static StaticDetails()
        {
            RoomsStatus = new Dictionary<int, string>();
            for (var i = 1; i <= 20; i++)
            {
                RoomsStatus.Add(i, Renovation);
            }
        }
        public const string Available = "available";
        public const string Busy = "busy";
        public const string Cleaning = "cleaning";
        public const string Renovation = "renovation";

        
      
    }
}
