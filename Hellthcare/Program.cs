using System.Reflection;
using Domain.Location;
using Domain.Location.PublicInterface;
using Domain.Meeting;
using Domain.Meeting.PublicInterface;
using Hellthcare.Application;
using Hellthcare.Application.Abstraction;
using Hellthcare.Domain.Location;
using Hellthcare.Domain.Meeting;
using Hellthcare.Domain.Notification;
using Hellthcare.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddSingleton<DbContext>();
builder.Services.AddSingleton<PatientService>();
builder.Services.AddSingleton<IPatientRepository, PatientRepository>();

builder.Services.AddSingleton<ILocationService, LocationService>();
builder.Services.AddSingleton<ILocationRepository, LocationRepository>();

builder.Services.AddSingleton<IMeetingRepository, MeetingRepository>();
builder.Services.AddSingleton<PlanMeetingPolicy>();

builder.Services.AddSingleton<IEmailSender, EmailService>();
builder.Services.AddSingleton<ITextSender, TextService>();
builder.Services.AddSingleton<SendMeetingNotificationPolicy>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseRouting();
app.MapControllers();
app.Run();