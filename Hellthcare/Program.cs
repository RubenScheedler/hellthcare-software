using System.Reflection;
using Hellthcare.Core.Confirmation;
using Hellthcare.Core.Confirmation.PublicInterface;
using Hellthcare.Core.Location.PublicInterface;
using Hellthcare.Core.Meeting.PublicInterface;
using Hellthcare.Core.Patient.PublicInterface;
using Hellthcare.Infrastructure;
using Hellthcare.Infrastructure.Communication;
using Hellthcare.Infrastructure.Persistance;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddSingleton<PatientService>();
builder.Services.AddSingleton<IPatientRepository, PatientRepository>();

builder.Services.AddSingleton<ILocationService, LocationService>();
builder.Services.AddSingleton<ILocationRepository, LocationRepository>();

builder.Services.AddSingleton<IMeetingRepository, MeetingRepository>();
builder.Services.AddSingleton<PlanMeetingPolicy>();

builder.Services.AddSingleton<IEmailSender, EmailService>();
builder.Services.AddSingleton<ITextSender, TextService>();
builder.Services.AddSingleton<SendMeetingConfirmationPolicy>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseRouting();
app.MapControllers();
app.Run();