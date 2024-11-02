namespace RazorPageProject.Services
{
    public interface IProductService
    {
        int Add(ProductDTO productDto);
        int Delete(int id);
        ProductDTO Find(int id);
        List<ProductDTO> List();
        ProductDTO Edit(ProductDTO product);
        List<ProductDTO> Search(string name);
    }
}
