using Application.Common.Models.Email;

namespace Application.Common.Interfaces.Email;

public interface IEmailSender
{
    Task<bool> SendEmail(EmailMessage email);
}
