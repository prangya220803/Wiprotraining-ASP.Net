namespace MiniShop.Models
{
    public class BillingViewModel
    {
        public string? UserName { get; set; }
        public List<CartItem> Items { get; set; } = new();
        public decimal Subtotal => Items.Sum(i => i.LineTotal);
        public decimal Tax => Math.Round(Subtotal * 0.18m, 2); // 18% GST example
        public decimal Total => Subtotal + Tax;
        public OrderDetails Details { get; set; } = new();
    }
}
