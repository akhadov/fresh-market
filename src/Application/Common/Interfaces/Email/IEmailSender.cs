using Application.Common.Models.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces.Email;

public interface IEmailSender
{
    Task<bool> SendEmail(EmailMessage email);
}
