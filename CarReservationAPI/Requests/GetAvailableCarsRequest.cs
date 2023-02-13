namespace CarReservationAPI.Requests
{
    public class GetAvailableCarsRequest
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
