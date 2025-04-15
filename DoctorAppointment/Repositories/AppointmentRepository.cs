using DoctorAppointment.Models;
using DoctorAppointment.Repositories.Interfaces;

namespace DoctorAppointment.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        public Task AddAppointmentAsync(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAppointmentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Appointment> GetAppointmentByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Appointment>> GetAppointmentsForDoctorAsync(int doctorId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Appointment>> GetAppointmentsForPatientAsync(int patientId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAppointmentAsync(Appointment appointment)
        {
            throw new NotImplementedException();
        }
    }
}
