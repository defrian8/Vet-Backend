using System;
using System.Collections.Generic;

namespace Vet.Models
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public string? PetName { get; set; }
        public string? OwnerName { get; set; }
        public string? Contact { get; set; }
        public DateTime? DateAppointment { get; set; }
    }
}
