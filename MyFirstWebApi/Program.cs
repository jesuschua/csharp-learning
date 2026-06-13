var builder = WebApplication.CreateBuilder(args);

// Add services (like FastAPI dependencies)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable serving static files (HTML, CSS, JS)
app.UseDefaultFiles();  // Serves index.html by default
app.UseStaticFiles();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();  // Swagger UI at /swagger
}

// Greet endpoint - similar to your console app
// GET /greet/John  ->  { "message": "Hello, John!" }
app.MapGet("/greet/{name?}", (string? name) =>
{
    var greeting = string.IsNullOrWhiteSpace(name) ? "Guest" : name;
    return new { message = $"Hello, {greeting}!" };
});

// Calculator endpoint - similar to your console app
// GET /add/5/3  ->  { "a": 5, "b": 3, "sum": 8 }
app.MapGet("/add/{a}/{b}", (int a, int b) =>
{
    return new { a, b, sum = a + b };
});

// POST endpoint with JSON body (more like FastAPI)
// POST /calculate with body: { "a": 5, "b": 3 }
app.MapPost("/calculate", (CalculateRequest request) =>
{
    return new { 
        a = request.A, 
        b = request.B, 
        sum = request.A + request.B,
        operation = "addition"
    };
});

app.Run();

// Request model (like Pydantic BaseModel in FastAPI)
record CalculateRequest(int A, int B);
