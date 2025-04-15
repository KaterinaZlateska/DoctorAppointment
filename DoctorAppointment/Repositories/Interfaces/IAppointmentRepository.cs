using DoctorAppointment.Models;

namespace DoctorAppointment.Repositories.Interfaces
{
    public interface IAppointmentRepository
    {
        Task<Appointment> GetAppointmentByIdAsync(int id);
        Task<IEnumerable<Appointment>> GetAppointmentsForDoctorAsync(int doctorId);
        Task<IEnumerable<Appointment>> GetAppointmentsForPatientAsync(int patientId);
        Task AddAppointmentAsync(Appointment appointment);
        Task UpdateAppointmentAsync(Appointment appointment);
        Task DeleteAppointmentAsync(int id);
    }
}
