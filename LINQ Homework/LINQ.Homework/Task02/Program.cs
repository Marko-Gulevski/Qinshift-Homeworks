using Task02.Enums;
using Task02.Models;

static void PrintCollectionItems(IEnumerable<string> collection)
{
    foreach (var item in collection)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
static void PrintProducts(List<Product> products)
{
    foreach (Product product in products)
    {
        Console.Write($"Displaying Products: \n{product.Title}\n");
    }
    Console.WriteLine();
}

static void PrintCollectionItemsDouble(IEnumerable<double> collection)
{
    foreach (var item in collection)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

List<Product> products = new List<Product>()
{
    new Product(1, "iPhone 9", "An apple mobile which is nothing like apple", 549, 4.69, 94, "Apple", ProductCategory.Smartphones),
    new Product(2, "iPhone X", "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...", 899, 4.44, 34, "Apple", ProductCategory.Smartphones),
    new Product(3, "Samsung Universe 9", "Samsung's new variant which goes beyond Galaxy to the Universe", 1249, 4.09, 36, "Samsung", ProductCategory.Smartphones),
    new Product(4, "OPPOF19", "OPPO F19 is officially announced on April 2021.", 280, 4.3, 123, "OPPO", ProductCategory.Smartphones),
    new Product(5, "Huawei P30", "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.", 499, 4.09, 32, "Huawei", ProductCategory.Smartphones),
    new Product(6, "MacBook Pro", "MacBook Pro 2021 with mini-LED display may launch between September, November", 1749, 4.57, 83, "Apple", ProductCategory.Laptops),
    new Product(7, "Samsung Galaxy Book", "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched", 1499, 4.25, 50, "Samsung", ProductCategory.Laptops),
    new Product(8, "Microsoft Surface Laptop 4", "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.", 1499, 4.43, 68, "Microsoft Surface", ProductCategory.Laptops),
    new Product(9, "Infinix INBOOK", "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty", 1099, 4.54, 96, "Infinix", ProductCategory.Laptops),
    new Product(10, "HP Pavilion 15-DK1056WM", "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10", 1099, 4.43, 89, "HP Pavilion", ProductCategory.Laptops),
    new Product(11, "perfume Oil", "Mega Discount, Impression of Acqua Di Gio by GiorgioArmani concentrated attar perfume Oil", 13, 4.26, 65, "Impression of Acqua Di Gio", ProductCategory.Fragrances),
    new Product(12, "Brown Perfume", "Royal_Mirage Sport Brown Perfume for Men & Women - 120ml", 40, 4, 52, "Royal_Mirage", ProductCategory.Fragrances),
    new Product(13, "Fog Scent Xpressio Perfume", "Product details of Best Fog Scent Xpressio Perfume 100ml For Men cool long lasting perfumes for Men", 13, 4.59, 61, "Fog Scent Xpressio", ProductCategory.Fragrances),
    new Product(14, "Non-Alcoholic Concentrated Perfume Oil", "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil", 120, 4.21, 114, "Al Munakh", ProductCategory.Fragrances),
    new Product(15, "Eau De Perfume Spray", "Genuine  Al-Rehab spray perfume from UAE/Saudi Arabia/Yemen High Quality", 30, 4.7, 105, "Lord - Al-Rehab", ProductCategory.Fragrances),
    new Product(16, "Hyaluronic Acid Serum", "L'OrÃ©al Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid", 19, 4.83, 110, "L'Oreal Paris", ProductCategory.Skincare),
    new Product(17, "Tree Oil 30ml", "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,", 12, 4.52, 78, "Hemani Tea", ProductCategory.Skincare),
    new Product(18, "Oil Free Moisturizer 100ml", "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.", 40, 4.56, 88, "Dermive", ProductCategory.Skincare),
    new Product(19, "Skin Beauty Serum.", "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m", 46, 4.42, 54, "ROREC White Rice", ProductCategory.Skincare),
    new Product(20, "Freckle Treatment Cream- 15gm", "Fair & Clear is Pakistan's only pure Freckle cream which helpsfade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.", 70, 4.06, 140, "Fair & Clear", ProductCategory.Skincare),
    new Product(21, "- Daal Masoor 500 grams", "Fine quality Branded Product Keep in a cool and dry place", 20, 4.44, 133, "Saaf & Khaas", ProductCategory.Groceries),
    new Product(22, "Elbow Macaroni - 400 gm", "Product details of Bake Parlor Big Elbow Macaroni - 400 gm", 14, 4.57, 146, "Bake Parlor Big", ProductCategory.Groceries),
    new Product(23, "Orange Essence Food Flavou", "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item", 14, 4.85, 26, "Baking Food Items", ProductCategory.Groceries)
};

#region
// Retrieve All Products with a price greater than 500
List<Product> priceLargerThan500 = products.Where(product => product.Price > 500).ToList();
PrintProducts(priceLargerThan500);
// Retrieve all skincare products
List<Product> skincareProducts = products.Where(products => products.Category == ProductCategory.Skincare).ToList();
PrintProducts(skincareProducts);
// Retrieve all product titles
List<string> productNames = products.Select(products => products.Title).ToList();
PrintCollectionItems(productNames);
// Select the titles of all products in the Laptops category
List<string> laptopTitles = products.Where(products => products.Category == ProductCategory.Laptops).Select(products => products.Title).ToList();
PrintCollectionItems(laptopTitles);
// Select the descriptions of all products with a stock of less than 50
List<string> productDescLessThan50 = products.Where(products => products.Stock < 50).Select(products => products.Description).ToList();
PrintCollectionItems(productDescLessThan50);
// Retrieve the titles of all products with a rating above 4.5
List<string> ratingAboveFourPointFive = products.Where(products => products.Rating > 4.5).Select(products => products.Title).ToList();
PrintCollectionItems(ratingAboveFourPointFive);
// Select the titles of all product from the Fragrances category with a rating above 4.6
List<string> fragreanceAboveFoutPointSix = products.Where(products => products.Category == ProductCategory.Fragrances && products.Rating > 4.6).Select(products => products.Title).ToList();
PrintCollectionItems(fragreanceAboveFoutPointSix);
// Select the titles of all products with a price between 100 and 200
List<string> productsBetweenHundredAndTwoHundo = products.Where(products => products.Price >= 100 && products.Price <= 200).Select(products => products.Title).ToList();
PrintCollectionItems(productsBetweenHundredAndTwoHundo);
// Retrieve the brands of all products with a price above 1000 dollars
List<string> brandsAboveThousand = products.Where(products => products.Price > 1000).Select(products => products.Brand).ToList();
PrintCollectionItems(brandsAboveThousand);
// Select the titles of all products with the word perfume in the title
List<string> productsWithPerfumeInTitle = products.Where(products => products.Title.ToLower().Contains("perfume")).Select(products => products.Title).ToList();
PrintCollectionItems(productsWithPerfumeInTitle);
// Find the last Grocery product
Product lastGroceryProduct = products.LastOrDefault(product => product.Category == ProductCategory.Groceries);
Console.WriteLine(lastGroceryProduct);
// Find the first product with a price above 1000
Product firstAboveThousand = products.FirstOrDefault(product => product.Price > 1000);
Console.WriteLine(firstAboveThousand);
// Select the titles of all products from the Groceries category with a stock above 150
List<string> groceriesWithStockAbove150 = products.Where(products => products.Stock > 150).Select(products => products.Title).ToList();
PrintCollectionItems(groceriesWithStockAbove150);
// Find the first item from the brand "Hemani Tea"
Product firstHemaniTea = products.FirstOrDefault(products => products.Brand == "Hemani Tea");
Console.WriteLine(firstHemaniTea);
// Retrieve the ratings of all products with a stock between 30 and 50
List<double> ratingsAndStocks = products.Where(products => products.Stock >= 30 && products.Stock <= 50).Select(products => products.Rating).ToList();
PrintCollectionItemsDouble(ratingsAndStocks);

#endregion

#region Bonus
// Find the average price of all products
static double AveragePrice(List<Product> prices)
{
    double pricesOfAll = 0;
    for (int i = 0; i < prices.Count; i++)
    {
        pricesOfAll += prices[i].Price;
    }
    return pricesOfAll / prices.Count;
}
Console.WriteLine(AveragePrice(products));

// Find the total stock of all products

static int AllStocks(List<Product> stocks)
{
    int totalInStock = 0;
    for (int i = 0; i < stocks.Count; i++)
    {
        totalInStock += stocks[i].Stock;
    }
    return totalInStock;
}

Console.WriteLine(AllStocks(products));

// Check if there is any product with price over 2000
static void PrintAbove2000(List<Product> products)
{
    foreach (Product product in products)
    {
        if (product.Price > 2000)
        {
            Console.WriteLine($"Found a product with a price above 2000, it is: {product.Title}");
        }
    }
}

PrintAbove2000(products);

// Find the most expenisve laptop

static void MostExpensiveLaptop(List<Product> products)
{
    Product expensiveLaptop = products[0];
    for (int i = 0; i < products.Count; i++)
    {
        if (products[i].Category == ProductCategory.Laptops && products[i].Price > expensiveLaptop.Price)
        {
            expensiveLaptop = (Product)products[i];
            Console.WriteLine($"The most expensive laptop is {expensiveLaptop.Title}! With a price of {expensiveLaptop.Price} dollars!");
        }
    }
}
MostExpensiveLaptop(products);

// Retrieve the titles and descriptions of all products from the skincare category

static void PrintSkincareItems(List<Product> products)
{
    for (int i = 0; i < products.Count; i++)
    {
        if (products[i].Category == ProductCategory.Skincare)
        {
            Console.WriteLine($"{products[i].Title}: {products[i].Description}\n\n");
        }
    }
}

PrintSkincareItems(products);
#endregion