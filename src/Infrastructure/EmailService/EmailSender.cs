﻿using Application.Common.Interfaces.Email;
using Application.Common.Models.Email;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Infrastructure.EmailService;

public class EmailSender : IEmailSender
{
    public EmailSettings _emailSettings;
    public EmailSender(IOptions<EmailSettings> emailSettings)
    {
        _emailSettings = emailSettings.Value;
    }
    public async Task<bool> SendEmail(EmailMessage email)
    {
        var client = new SendGridClient(_emailSettings.ApiKey);

        var to = new EmailAddress(email.To);

        var from = new EmailAddress
        {
            Email = _emailSettings.FromAddress,
            Name = _emailSettings.FromName
        };

        var message = MailHelper.CreateSingleEmail(from, to, email.Subject, email.Body, email.Body);

        var response = await client.SendEmailAsync(message);

        return response.IsSuccessStatusCode;
    }
}
