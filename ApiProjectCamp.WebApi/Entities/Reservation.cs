namespace ApiProjectCamp.WebApi.Entities
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public string ReservationNameSurname { get; set; }
        public string ReservationEmail { get; set; }
        public string ReservationPhoneNumber { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ReservationTime { get; set; }
        public int ReservationCountofPeople { get; set; }
        public string ReservationMessage { get; set; }
        public string ReservationStatus { get; set; }
    }
}
