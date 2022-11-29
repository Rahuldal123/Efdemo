namespace Efdemo.Models
{
    public class ProductCRUD
    {
        private readonly ApplicationDbContext _context; 
        

        public ProductCRUD(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product>GetAllProducts()
        {
            return _context.products.ToList();
        }
        public Product GetProductById(int id)
        {
            var product = _context.products.Where(x => x.Id == id).FirstOrDefault();
            if (product != null)
            {
                return product;
            }
            else
            {
                return null;
            }
        }
        public int  AddProduct(Product prod)
        {
            _context.products.Add(prod);
            int res=_context.SaveChanges();
            return res;
        }
        public int UpdateProduct(Product prod)
        {
            _context.products.Update(prod);
            int res = _context.SaveChanges();
            return res;
        }
        public int DeleteProduct(Product prod)
        {
            int res = 0;
            var product=_context.products.Where(x => x.Id == prod.Id).FirstOrDefault();
            if(product != null)
            {
                _context.products.Remove(product);
                res = _context.SaveChanges();
            }
            return res;
        }

  
    }
}
