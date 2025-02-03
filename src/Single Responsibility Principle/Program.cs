//using Single_Responsibility_Principle.Wrong;

//ProductWrong product = new()
//{
//    Name = "Teclado Mecâncico",
//    Description = "Teclado Mecânico",
//    BuyingPrice = 100.00,
//    SellPrice = 200.00,
//};

//product.Stock = product.BuyingStock(100);

//Console.WriteLine(product.PrintProduct());

//product.Stock = product.SellStock(1);

//Console.WriteLine("\n");

//Console.WriteLine(product.PrintProduct());

using Single_Responsibility_Principle.Correct;

Product product = new Product()
{
    Name = "Teclado Mecâncico",
    Description = "Teclado Mecânico",
    BuyingPrice = 100.00,
    SellPrice = 200.00,
};

BuyProduct buyProduct = new BuyProduct();

buyProduct.BuyingStock(product, 100);

SellProduct sellProduct = new SellProduct();

sellProduct.SellStock(product, 10);

PrintProduct printProduct = new PrintProduct();

Console.WriteLine(printProduct.Print(product));