using MarketCRM;
UsersEntity adam = new Admin()
{
    FullName = "jasdk"
 };
Product product1 = new() { ProductName = "alma",          ProductCount = 5, Price = 1.5, ProductID = 1, CategoryIDProduct = 1 };
Product product2 = new() { ProductName = "dish firchasi", ProductCount = 3, Price = 2.0, ProductID = 2, CategoryIDProduct = 2 };
Product product3 = new() { ProductName = "armud",         ProductCount = 9, Price = 2.2, ProductID = 3, CategoryIDProduct = 1 };
Product product4 = new() { ProductName = "dish macunu",   ProductCount = 4, Price = 2.5, ProductID = 4, CategoryIDProduct = 2 };

Category category1 = new() { CategoryId=1, CategoryName="Meyve"};
Category category2 = new() { CategoryId=2, CategoryName="Shexsi temizlik"};

BaseProductManager userServise = new AdminManager();
BaseProductManager sellerServise = new SellerManager();
BaseProductManager headCashierServise = new HeadCashierManager();


userServise.AddCategory(category1);
userServise.AddCategory(category2);

userServise.Add(product1);
userServise.Add(product2);
userServise.Add(product3);
userServise.Add(product4);

 
sellerServise.Sell("alma", 4);
sellerServise.Sell("dish macunu", 3);
headCashierServise.ReAddSoldProducts("dish macunu", 4);
headCashierServise.GetProductById(1);
userServise.GetProductById(4); 
//userServise.GetProductByCategory("Meyve");
//userServise.GetAllProduct();

//Burada  ReAddSoldProducts metodu düzgün işləmir. Deadline-a görə düzəltməyə çatdıra bilmədim.