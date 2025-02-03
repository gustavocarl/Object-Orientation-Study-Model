namespace Single_Responsibility_Principle.Correct;

public class SellProduct
{
    public int SellStock(Product product, int quantityOfProducts)
    {
        product.Stock -= quantityOfProducts;
        return product.Stock;
    }
}