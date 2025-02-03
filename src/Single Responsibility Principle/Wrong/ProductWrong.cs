namespace Single_Responsibility_Principle.Wrong;

public class ProductWrong
{
    public string Name { get; set; }

    public string Description { get; set; }

    public double BuyingPrice { get; set; }

    public double SellPrice { get; set; }

    public int Stock { get; set; }

    public int BuyingStock(int quantityOfProducts)
    {
        Stock += quantityOfProducts;
        return Stock;
    }

    public int SellStock(int quantityOfProductsSelling)
    {
        Stock -= quantityOfProductsSelling;
        return Stock;
    }

    public string PrintProduct()
    {
        return $"Nome: {Name} \n" +
            $"Descrição: {Description} \n" +
            $"Preço de Compra: {BuyingPrice} \n" +
            $"Preço de Venda: {SellPrice} \n" +
            $"Estoque: {Stock} ";
    }
}