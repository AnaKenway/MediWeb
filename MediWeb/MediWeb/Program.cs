using DataLayer;
using MediWeb.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Add services from Services project
builder.Services.AddScoped<AdminService>();
builder.Services.AddScoped<AppointmentService>();
builder.Services.AddScoped<AppointmentSlotService>();
builder.Services.AddScoped<ClinicService>();
builder.Services.AddScoped<DoctorService>();
builder.Services.AddScoped<DoctorWorksAtClinicService>();
builder.Services.AddScoped<MedicalStaffService>();
builder.Services.AddScoped<PatientService>();
builder.Services.AddScoped<SpecializationService>();
builder.Services.AddScoped<UserAccountService>();

builder.Services.AddRazorComponents();

//Add DBContext
builder.Services.AddDbContext<MediWebContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnectionString")));

//Add Unit of Work
builder.Services.AddScoped<UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
