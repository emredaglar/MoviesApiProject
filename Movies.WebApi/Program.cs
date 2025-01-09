using Movies.BusinessLayer.Abstract;
using Movies.BusinessLayer.Concrete;
using Movies.DataAccessLayer.Abstract;
using Movies.DataAccessLayer.Concrete;
using Movies.DataAccessLayer.EntityFreamwork;
using Movies.DataAccessLayer.Repositories;
using Movies.EntityLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICategoryService,CategoryManager>();
builder.Services.AddScoped<ICategoryDal,EfCategoryDal>();

builder.Services.AddScoped<IMovieService,MovieManager>();
builder.Services.AddScoped<IMovieDal,EfMovieDal>();

builder.Services.AddScoped<IGenericDal<Category>, GenericRepository<Category>>();
builder.Services.AddScoped<IGenericService<Category>, GenericManager<Category>>();

builder.Services.AddScoped<IGenericService<Movie>, GenericManager<Movie>>();
builder.Services.AddScoped<IGenericDal<Movie>, GenericRepository<Movie>>();

builder.Services.AddScoped<IGenericService<Serie>, GenericManager<Serie>>();
builder.Services.AddScoped<IGenericDal<Serie>, GenericRepository<Serie>>();
builder.Services.AddScoped<ISerieService, SerieManager>();
builder.Services.AddScoped<ISerieDal, EfSerieDal>();

builder.Services.AddDbContext<ApiContext>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
