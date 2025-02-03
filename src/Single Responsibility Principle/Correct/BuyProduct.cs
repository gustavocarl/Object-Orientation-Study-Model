namespace Single_Responsibility_Principle.Correct;

public class BuyProduct
{
    public int BuyingStock(Product product, int quantityOfProducts)
    {
        product.Stock = quantityOfProducts;
        return product.Stock;
    }
}