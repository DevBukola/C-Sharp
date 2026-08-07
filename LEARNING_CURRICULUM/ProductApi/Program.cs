var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();
app.UseCors(policy =>
{
    policy
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// app.UseHttpsRedirection();
app.MapGet("/favoritecolors", () =>
{
    // return "Hello, Oluwabukola!";
    List<string> colors = new List<string>()
    {
        "Pink",
        "White",
        "Green",
    };
    return colors;
});

app.MapGet("/name", () =>
{
    return "I am Oluwabukola!";
});

app.MapGet("/", () =>
{
    return "Welcome to my first API";
});

app.MapGet("/products", (string? search) =>
{
    List<Product> products = new List<Product>
    {
        new Product {Id = 1, Name = "Laptop", Price = 500000},
        new Product {Id = 2, Name = "Phone", Price = 120000},
        new Product {Id = 3, Name = "Car", Price = 10500000},
        new Product {Id = 4, Name = "Keyboard", Price = 14000},
        new Product {Id = 5, Name = "Monitor", Price = 80000},
    };
    // return products;
    // var expensiveProducts = products.Where(product => product.Price >= 100000);
    // return expensiveProducts;

    // return products.OrderBy(product => product.Price);

    if (string.IsNullOrWhiteSpace(search))
    {
        return products;
    }
    return products
    .Where(product => product.Name.Contains(search, StringComparison.OrdinalIgnoreCase))
    .ToList();
});


app.Run();

class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
}
