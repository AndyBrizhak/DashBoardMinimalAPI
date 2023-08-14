namespace DashBoardMinimalAPI.Models
{
    public class Rooms
    {
        public Dictionary<int, string> Status;

        public Rooms()
        {
            Status = new Dictionary<int, string>();
            for (var i = 1; i <= 20; i++)
            {
                Status.Add(i, value: StaticDetails.Renovation);
            }
        }
        //Rooms()
        //{

        //    Status = new Dictionary<int, string>();
        //    for (var i = 1; i <= 20; i++)
        //    {
        //        Status.Add(i, Renovation);
        //    }

        //}
    }
}
