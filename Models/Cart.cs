namespace Eshopper.Models
{
    public class CartLine
    {
        public int CartLineID {set; get;}
        public Product Product {set; get;} = new();
        public int Quantity {set; get;}
    }
    public class Cart
    {
        public List<CartLine> Lines {get; set;} = new List<CartLine>();
        public void AddItem(Product product, int quantity)
        {
            CartLine? line = Lines.Where(p => p.Product.ProductId == product.ProductId)
            .FirstOrDefault();
            if(line == null)
            {
                Lines.Add(new CartLine{
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public void RemoveLine(Product product)=>
        Lines.RemoveAll(l => l.Product.ProductId == product.ProductId);
        public decimal ComputeTotalValue() =>
        (decimal)Lines.Sum(e => e.Product?.ProductPrice *(1 - e.Product.ProductDiscount) * e.Quantity);
        public void Clear() => Lines.Clear();
    }
}