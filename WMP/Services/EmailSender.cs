using Microsoft.AspNetCore.Identity;

namespace WMP.Services;

public class IdentityMailSender<TUser> : IEmailSender<TUser> where TUser : class
{
    public Task SendEmailAsync(TUser user, string subject, string htmlMessage)
    {
        Console.WriteLine($"Email requested for {user}: {subject}");
        return Task.CompletedTask;
    }

    public Task SendConfirmationLinkAsync(TUser user, string email, string confirmationLink)
    {
        throw new NotImplementedException();
    }

    public Task SendPasswordResetLinkAsync(TUser user, string email, string resetLink)
    {
        throw new NotImplementedException();
    }

    public Task SendPasswordResetCodeAsync(TUser user, string email, string resetCode)
    {
        throw new NotImplementedException();
    }
}