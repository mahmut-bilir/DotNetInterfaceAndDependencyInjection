

using Microsoft.Extensions.DependencyInjection;

IEmployee sofwareDeveloper = new SoftwareDeveloper();
IEmployee accountant = new Accountant();
sofwareDeveloper.Work();
accountant.Work();

IVehicle motorcycle = new Motorcycle();
IVehicle car = new Car();

motorcycle.Drive();
car.Drive();

IMessageSender email = new EmailSender();
IMessageSender sms = new SmsSender();

NotificationService emailService = new NotificationService(email);
NotificationService smsService = new NotificationService(sms);

emailService.NotificationSender("Hi Email!");
smsService.NotificationSender("Hi Sms!");



var service = new ServiceCollection();

service.AddTransient<IMessageSender, EmailSender>();

var provider = service.BuildServiceProvider();
var messageService = provider.GetService<IMessageSender>();
messageService?.Send("Message sent with DI!");