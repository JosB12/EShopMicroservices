using BuildingBlocks.CQRS;
using Catalog.API.Models;
using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, string Description, string ImageFile, decimal Price, List<string> Category)
        : ICommand<CreateProductResult>;
    
    public record CreateProductResult(Guid Id);

    internal class CreateProductCommandHandler 
        : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            // create Product entity from command object
            
            var product = new Product
            {
                Name = command.Name,
                Description = command.Description,
                Category = command.Category,
                Price = command.Price,
                ImageFile = command.ImageFile,
            };
            //save to database


            //return CreateProductResult result
            return new CreateProductResult(Guid.NewGuid());

            throw new NotImplementedException();
        }
    }
}
