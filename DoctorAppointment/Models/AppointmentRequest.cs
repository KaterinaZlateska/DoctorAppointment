using DoctorAppointment.Enums;
using System.ComponentModel.DataAnnotations;

namespace DoctorAppointment.Models
{
    public class AppointmentRequest
    {
        [Required]
        public int AppointmentRequestId { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required]
        public Patient Patient { get; set; } = null!;

        [Required]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } = null!;

        [Required]
        public DateTime RequestedTime { get; set; }

        [Required]
        public AppointmentStatus Status { get; set; } 
    }
}
