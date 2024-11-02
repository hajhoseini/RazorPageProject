using RazorPageProject.Models;
using RazorPageProject.Models.Data;

namespace RazorPageProject.Services
{
    public class ProductService : IProductService
    {
        private readonly DataBaseContext _context;

        public ProductService(DataBaseContext context)
        {
            _context = context;
        }

        public int Add(ProductDTO productDto)
        {
            var entity = new Product
            {
                Name = productDto.Name,
                Price = productDto.Price,
                Description = productDto.Description
            };

            _context.Product.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public int Delete(int id)
        {
            var entity = new Product
            {
                Id = id
            };
            _context.Product.Remove(entity);
            return _context.SaveChanges();
        }

        public ProductDTO Edit(ProductDTO productDto)
        {
            var entity = _context.Product.Find(productDto.Id);

            entity.Name = productDto.Name;
            entity.Price = productDto.Price;
            entity.Description = productDto.Description;

            _context.SaveChanges();
            return productDto;
        }

        public ProductDTO Find(int id)
        {
            var entity = _context.Product.Find(id);
            return new ProductDTO
            {
                Name = entity.Name,
                Price = entity.Price,
                Description = entity.Description
            };
        }

        public List<ProductDTO> List()
        {
            var list = _context.Product
                        .OrderByDescending(p => p.Id).ToList()
                        .Select(p => new ProductDTO
                        {
                            Name = p.Name,
                            Price = p.Price,
                            Description = p.Description
                        }).ToList();
            return list;
        }

        public List<ProductDTO> Search(string name)
        {
            var list = _context.Product
                        .Where(p => p.Name.Contains(name))
                        .OrderByDescending(p => p.Id).ToList()
                        .Select(p => new ProductDTO
                        {
                            Name = p.Name,
                            Price = p.Price,
                            Description = p.Description
                        }).ToList();
            return list;
        }
    }
}
