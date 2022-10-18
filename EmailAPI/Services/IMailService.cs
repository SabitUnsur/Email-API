using EmailAPI.Module;

namespace EmailAPI.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
