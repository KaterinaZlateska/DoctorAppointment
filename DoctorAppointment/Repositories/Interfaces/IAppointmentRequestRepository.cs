using DoctorAppointment.Models;

namespace DoctorAppointment.Repositories.Interfaces
{
    public interface IAppointmentRequestRepository
    {
        Task<AppointmentRequest> GetAppointmentRequestByIdAsync(int id);
        Task<IEnumerable<AppointmentRequest>> GetAppointmentsForDoctorAsync(int doctorId);
        Task<IEnumerable<AppointmentRequest>> GetAppointmentsForPatientAsync(int patientId);
        Task AddAppointmentRequestAsync(AppointmentRequest appointmentRequest);
        Task UpdateAppointmentRequestAsync(AppointmentRequest appointmentRequest);
        Task DeleteAppointmentRequestAsync(int id);
    }
}
