namespace Single_Responsibility_Principle.Correct;

public class PrintProduct
{
    public string Print(Product product)
    {
        return $"Nome: {product.Name} \n" +
            $"Descrição: {product.Description} \n" +
            $"Preço de Compra: {product.BuyingPrice} \n" +
            $"Preço de Venda: {product.SellPrice} \n" +
            $"Estoque: {product.Stock} ";
    }
}