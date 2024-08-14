namespace ProniaMVC.Models.Base
{
    public class Category
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; } 
    }
}
