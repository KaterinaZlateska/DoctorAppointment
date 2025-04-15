using DoctorAppointment.Models;
using DoctorAppointment.Repositories.Interfaces;

namespace DoctorAppointment.Repositories
{
    public class AppointmentRequestRepository : IAppointmentRequestRepository
    {
        public Task AddAppointmentRequestAsync(AppointmentRequest appointmentRequest)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAppointmentRequestAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AppointmentRequest> GetAppointmentRequestByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AppointmentRequest>> GetAppointmentsForDoctorAsync(int doctorId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AppointmentRequest>> GetAppointmentsForPatientAsync(int patientId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAppointmentRequestAsync(AppointmentRequest appointmentRequest)
        {
            throw new NotImplementedException();
        }
    }
}
