using Dependency_Inversion_Principle;

ISendMessage sendSms = new SendSMS() { PhoneNumber = "(16) 99760-5799" };

ISendMessage sendEmail = new SendEmail() { Email = "gustavo_carl@hotmail.com" };

NotificationService smsService = new(sendSms);
NotificationService emailService = new(sendEmail);

smsService.Notify();
Console.WriteLine("\n");
emailService.Notify();