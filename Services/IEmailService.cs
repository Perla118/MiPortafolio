using MiPortafolio.Models;
namespace MiPortafolio.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailDTO request);
    }
}
