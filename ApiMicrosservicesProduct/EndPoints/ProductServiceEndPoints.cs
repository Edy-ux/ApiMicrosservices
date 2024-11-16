using ApiMicrosservicesProduct.Dtos;

using ApiMicrosservicesProduct.Services.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace ApiMicrosservicesProduct.Endpoints;

public static class ProductServiceEndpoint
{


    public static void MapProductServiceEndpoint(this WebApplication app)
    {

        var apiGroup = app.MapGroup("/api/v1/products");

        apiGroup.MapGet("/" , async (
            [FromServices] IProductService service
         ) =>
        {

            var products = await service.GetItemsAsync();

            if (products == null || !products.Any()) return Results.NotFound("No products found.");

            return Results.Ok(products);


        });

        apiGroup.MapGet("/{id}", async(
           [FromServices] IProductService service, int? id) 
           =>
        {
            var producById = await service.GetByIdAsync(id);
            if (producById == null) return Results.NotFound("Product  Not Found");
            return Results.Ok(producById);
        });

       // app.MapGet()
       
    }
}
