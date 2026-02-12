var builder = WebApplication.CreateBuilder(args);

// --- CONFIGURAÇÃO DE CORS PARA PRODUÇÃO ---
builder.Services.AddCors(options =>
{
    options.AddPolicy("LiberarReact", policy =>
    {
        // AllowAnyOrigin permite que seu site no Netlify acesse a API
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});
// ------------------------------------------

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// --- ATIVAÇÃO DO CORS ---
app.UseCors("LiberarReact");
// ------------------------

app.UseAuthorization();
app.MapControllers();

app.Run();



// using Microsoft.EntityFrameworkCore;


// var builder = WebApplication.CreateBuilder(args);

// // Adiciona controllers
// builder.Services.AddControllers();



// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();


// builder.Services.AddCors(options =>
// {
    // options.AddPolicy("AllowReactApp",
        // policy =>
        // {
            // policy.WithOrigins("http://localhost:3000", "http://localhost:3001")
                  // .AllowAnyHeader()
                  // .AllowAnyMethod();
        // });
// });

// var app = builder.Build();

// // Configura o pipeline HTTP
// if (app.Environment.IsDevelopment())
// {
    // app.UseSwagger();
    // app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// // Ativa o CORS
// app.UseCors("AllowReactApp");

// app.UseAuthorization();

// app.MapControllers();

// app.Run();
