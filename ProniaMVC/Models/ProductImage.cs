namespace ProniaMVC.Models
{
    public class ProductImage:BaseEntity
    {
        public string Image {  get; set; }
        public bool? IsPrimarey { get; set; }
        public int ProductId { get; set; }

    }
}
