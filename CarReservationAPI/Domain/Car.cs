using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarReservationAPI.Domain
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string CustomId  => "C<" + Id + ">";
        public ICollection<Reservation> Reservations { get; set; }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
            Reservations = new List<Reservation>();
        }

        public Car(string make, string model, ICollection<Reservation> reservations)
        {
            Make = make;
            Model = model;
            Reservations = reservations;
        }
    }
}
