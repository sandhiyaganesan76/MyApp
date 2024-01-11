using Microsoft.EntityFrameworkCore;
using bloomApiProject.Data;
using bloomApiProject.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IPasswordHasher<Users>, PasswordHasher<Users>>();

builder.Services.AddSwaggerGen();
builder.Services.AddCors(option=>{
    option.AddPolicy("MyPolicy",builder=>{
        builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });
});

builder.Services.AddDbContext<bloomApiProjectDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAuthentication(x=>{
    x.DefaultAuthenticateScheme=JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme=JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x=>{
    x.RequireHttpsMetadata=false;
    x.SaveToken=true;
    x.TokenValidationParameters=new TokenValidationParameters{
        ValidateIssuerSigningKey=true,
        IssuerSigningKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes("veryverysceret....")),
        ValidateAudience=false,
        ValidateIssuer=false,
        ClockSkew=TimeSpan.Zero
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());


app.UseAuthorization();

app.MapControllers();

app.Run();
