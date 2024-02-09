using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace TropicSun.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        public int? YachtId { get; set; }
        public DateTime ReservationDate { get; set;}
        public DateTime StartDate { get; set;}
        public DateTime EndDate { get; set;}
        public Location StartLocation { get; set;}
        public Location EndLocation { get; set;}

        public virtual Yacht Yacht { get; set; }

        

    }
}
