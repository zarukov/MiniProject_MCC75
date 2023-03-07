using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MiniProject_MCC75.Contexts;
using MiniProject_MCC75.Repositories.Data;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();


// Configure DbContext to Sql Server Database
var connectionString = builder.Configuration.GetConnectionString("Connection");
builder.Services.AddDbContext<MyContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<AccountRepository>();
builder.Services.AddScoped<AccountRoleRepository>();
builder.Services.AddScoped<CustomerRepository>();
builder.Services.AddScoped<EmployeeRepository>();
builder.Services.AddScoped<OfficeRepository>();
builder.Services.AddScoped<OrderRepository>();
builder.Services.AddScoped<OrderProductRepository>();
builder.Services.AddScoped<PaymentRepository>();
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<ProductLineRepository>();
builder.Services.AddScoped<RoleRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{
    x.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Mini Project MCC 75",
        Description = "ASP.NET Core API 6.0"
    });
    x.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme."
    });
    x.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    });
});
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;//tanya
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            //usually, this is app-base url
            ValidateAudience = false,
            /*ValidAudience = builder.Configuration["JWT : Audience"],--> kenapa di comment*/

            //if the JWT was created using web service, then this could be a consumer-base URL
            ValidateIssuer = false,
            /*ValidIssuer = builder.Configuration["JWT : Issuer"],--> kenapa di comment*/

            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"])),
            ValidateLifetime = true,
            ClockSkew = TimeSpan.Zero
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

app.UseAuthorization();

app.MapControllers();

app.Run();
