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

            app.MapGet("/suppliers", async (
                string? companyName,
                ISupplierService service) =>
            {
                if (string.IsNullOrWhiteSpace(companyName))
                {
                    return Results.BadRequest("CompanyName query parameter is required.");
                }
                var phone = await service.GetPhoneNumberByCompanyNameAsync(companyName);
                return phone is not null ? Results.Ok(phone) : Results.NotFound("Supplier not found.");
            });

            app.MapGet("/suppliers/multiple", async (
                string ids,
                ISupplierService service) =>
            {
                var idList = ids.Split(',').Select(int.Parse).ToList();
                var suppliers = await service.GetSuppliersByIdsAsync(idList);
                return suppliers.Any() ? Results.Ok(suppliers) : Results.NotFound("Suppliers not found.");
            });


            app.MapGet("/suppliers/{id:int}", async (
            int id,
            ISupplierService service) =>
            {
                var supplier = await service.GetSupplierByIdAsync(id);
                return supplier is not null ? Results.Ok(supplier) : Results.NotFound("Supplier not found.");
            });




            app.MapGet("/suppliers/dropdown", async (
             ISupplierService service,
             int page = 1,
             int pageSize = 10) =>
            {
                var suppliers = await service.GetSuppliersForDropdownPaginatedAsync(page, pageSize);
                return Results.Ok(suppliers);
            });



        }
    }
}
