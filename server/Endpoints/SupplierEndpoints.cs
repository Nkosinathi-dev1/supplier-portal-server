using server.Dtos;
using server.Interfaces;

namespace server.Endpoints
{
    public static class SupplierEndpoints
    {
        public static void MapSupplierEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapPost("/suppliers", async (
                SupplierDto dto,
                ISupplierService service) =>
            {
                var result = await service.AddSupplierAsync(dto);
                return Results.Created($"/suppliers/{result.CompanyName}", result);
            });

            app.MapGet("/suppliers/{companyName}", async (
                string companyName,
                ISupplierService service) =>
            {
                var phone = await service.GetPhoneNumberByCompanyNameAsync(companyName);
                return phone is not null ? Results.Ok(phone) : Results.NotFound();
            });
        }
    }
}
