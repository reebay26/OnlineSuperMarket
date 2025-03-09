using OnlineSuperMarket.Dbwork;
using OnlineSuperMarket.Models;

namespace OnlineSuperMarket.seeder
{
    public class DatabaseSeeder
    {
        private readonly sqlDb db;
        private readonly IWebHostEnvironment env;

        public DatabaseSeeder(sqlDb db, IWebHostEnvironment env)
        {
            this.db = db;
            this.env = env;
        }

        public void Seed()
        {
            if (!db.category.Any())
            {
                db.category.AddRange(new List<Category>
                {
                    new Category {  category_name = "Electronics", category_desc = "lorem ipsum dolor sit" },
                    new Category {  category_name = "Vegetables", category_desc = "lorem ipsum dolor sit" },
                    new Category {  category_name = "Women_Cloth", category_desc = "lorem ipsum dolor sit" },
                    new Category {  category_name = "Grocery", category_desc = "lorem ipsum dolor sit" },
                    new Category {  category_name = "Fruit", category_desc = "lorem ipsum dolor sit" },
                    new Category {  category_name = "Dairy & Bakery", category_desc = "lorem ipsum dolor sit" },
                    new Category { category_name = "Cosmetics", category_desc = "lorem ipsum dolor sit" },
                    new Category {  category_name = "Snacks", category_desc = "lorem ipsum dolor sit" },
                    new Category {  category_name = "Meat & Sea Food", category_desc = "lorem ipsum dolor sit" },
                    new Category {  category_name = "Stationary", category_desc = "lorem ipsum dolor sit" },
                    new Category {  category_name = "Footwear", category_desc = "lorem ipsum dolor sit" },
                    new Category {  category_name = "Men Cloth", category_desc = "lorem ipsum dolor sit" }
                });

                db.SaveChanges();
            }
            if (!db.tbl_brand.Any())
            {
                db.tbl_brand.AddRange(new List<Brand>
    {
        new Brand { brand_name = "Gul Ahmed", brand_desc = "A famous textile brand known for high-quality fabrics and apparel." },
        new Brand { brand_name = "Khaadi", brand_desc = "A popular fashion brand specializing in ethnic and casual wear." },
        new Brand { brand_name = "Shan Masala", brand_desc= "A popular spice mix brand that enhances the flavor of traditional dishes like biryani, curry, and BBQ." },
        new Brand { brand_name = "Nestle Milkpak", brand_desc = "A rich and creamy UHT milk known for its freshness and long shelf life. Perfect for tea, desserts, and daily use." },
        new Brand { brand_name= "Adam Cheese", brand_desc  = "A popular cheese brand offering a variety of flavors like cheddar and mozzarella, used in sandwiches, pizzas, and snacks." },
        new Brand {brand_name = "Lays Chips", brand_desc  = "A crispy potato chip brand available in various flavors like classic salted, masala, and BBQ. A go-to snack." },
        new Brand {brand_name = "Sapphire", brand_desc = "A well-known clothing brand specializing in trendy and high-quality fabrics." },
        new Brand { brand_name = "Maria B.", brand_desc = "A leading Pakistani fashion brand offering designer wear and luxury pret." }
    });

                db.SaveChanges();
            }


            if (!db.tbl_product.Any())
            {
                db.tbl_product.AddRange(new List<Product_Model>
        {
                    new Product_Model
        {
            ProductName = "Onion",
            ProductPrice = 50,
            ProductQuantity = 400,
            ProductDescription = "A pungent, layered vegetable used in almost every cuisine. It adds flavor to dishes and can be eaten raw or cooked.",
            product_category = 2,
            ProductImage = CopyImage("v4.jpeg")
        },
        new Product_Model
        {
            ProductName = "Corn",
            ProductPrice = 60,
            ProductQuantity = 400,
            ProductDescription = "A sweet and juicy grain eaten boiled, roasted, or as popcorn. It’s rich in fiber and commonly used in salads and snacks.",
            product_category = 2,
            ProductImage = CopyImage("v2.jpeg")
        },
        new Product_Model
        {
            ProductName = "Coriander",
            ProductPrice = 30,
            ProductQuantity = 400,
            ProductDescription = "A fragrant herb with fresh green leaves and citrusy seeds. It enhances the flavor of curries, salads, and soups.",
            product_category = 2,
            ProductImage = CopyImage("v8.jpeg")
        },
        new Product_Model
        {
            ProductName = "Ginger",
            ProductPrice = 40,
            ProductQuantity = 400,
            ProductDescription = "A spicy, aromatic root often used in teas, curries, and stir-fries. It has medicinal properties and aids digestion.",
            product_category = 2,
            ProductImage = CopyImage("v9.jpeg")
        },
        new Product_Model
        {
            ProductName = "Red Chilli",
            ProductPrice = 30,
            ProductQuantity = 450,
            ProductDescription = "A spicy pepper that adds heat to dishes. Used fresh or dried, it is a staple in many spicy cuisines.",
            product_category = 2,
            ProductImage = CopyImage("v10.jpeg")
        },
        new Product_Model
        {
            ProductName = "Cucumber",
            ProductPrice = 70,
            ProductQuantity = 500,
            ProductDescription = "A hydrating, crunchy vegetable mostly eaten raw in salads. It has a mild, refreshing taste and is rich in water content.",
            product_category = 2,
            ProductImage = CopyImage("v6.jpeg")
        },
        new Product_Model
        {
            ProductName = "Cauliflower",
            ProductPrice = 50,
            ProductQuantity = 400,
            ProductDescription = "A white, crunchy vegetable that can be eaten raw, roasted, or cooked in curries. It’s rich in fiber and low in calories, making it a healthy choice.",
            product_category = 2,
            ProductImage = CopyImage("v3.jpeg")
        },
        new Product_Model
        {
            ProductName = "Brinjal (Eggplant)",
            ProductPrice = 50,
            ProductQuantity = 400,
            ProductDescription = "A purple, spongy vegetable used in curries, stir-fries, and grills. It absorbs flavors well and has a soft texture when cooked.",
            product_category = 2,
            ProductImage = CopyImage("v11.jpeg")
        },
        new Product_Model
        {
            ProductName = "Broccoli",
            ProductPrice = 60,
            ProductQuantity = 400,
            ProductDescription = "A green, nutrient-rich vegetable packed with vitamins and antioxidants. Great for steaming, stir-frying, or adding to salads.",
            product_category = 2,
            ProductImage = CopyImage("v1.jpeg")
        },
        new Product_Model
        {
            ProductName = "Banana",
            ProductPrice = 40,
            ProductQuantity = 400,
            ProductDescription = "A soft, sweet fruit rich in potassium and energy. It’s easy to digest and perfect for snacking or smoothies.",
            product_category = 5,
            ProductImage = CopyImage("banana.jpg")
        },
        new Product_Model
        {
            ProductName = "Mango",
            ProductPrice = 80,
            ProductQuantity = 400,
            ProductDescription = "The 'King of Fruits,' known for its sweet, juicy, and tropical flavor. It’s a summer favorite and great for juices and desserts.",
            product_category = 5,
            ProductImage = CopyImage("mango.jpg")
        },
        new Product_Model
        {
            ProductName = "Strawberry",
            ProductPrice = 50,
            ProductQuantity = 450,
            ProductDescription = "A small, red berry with a sweet and slightly tangy taste. It’s packed with Vitamin C and great for desserts.",
            product_category = 5,
            ProductImage = CopyImage("strawberry.jpeg")
        },
        new Product_Model
        {
            ProductName = "Red Apple",
            ProductPrice = 70,
            ProductQuantity = 500,
            ProductDescription = "A crunchy, sweet fruit that’s high in fiber and antioxidants. An apple a day keeps the doctor away.",
            product_category = 5,
            ProductImage = CopyImage("apple.jpg")
        },
        new Product_Model
        {
            ProductName = "Pineapple",
            ProductPrice = 150,
            ProductQuantity = 400,
            ProductDescription = "A tropical fruit with a sweet and tangy flavor. It’s juicy, rich in enzymes, and great for digestion.",
            product_category = 5,
            ProductImage = CopyImage("pineapple.jpeg")
        },
        new Product_Model
        {
            ProductName = "Watermelon",
            ProductPrice = 80,
            ProductQuantity = 400,
            ProductDescription = "A refreshing summer fruit with high water content. It’s sweet, hydrating, and perfect for hot days.",
            product_category = 5,
            ProductImage = CopyImage("watermelon.jpg")
        },
        new Product_Model
        {
            ProductName = "Purple Grapes",
            ProductPrice = 90,
            ProductQuantity = 500,
            ProductDescription = "Small, juicy fruits available in green, red, or black varieties. They are sweet, rich in antioxidants, and great for snacking.",
            product_category = 5,
            ProductImage = CopyImage("grapes.jpg")
        },
        new Product_Model
        {
            ProductName = "Orange",
            ProductPrice = 25,
            ProductQuantity = 550,
            ProductDescription = "A juicy, tangy citrus fruit loaded with Vitamin C. It’s refreshing, boosts immunity, and is great for juices.",
            product_category = 5,
            ProductImage = CopyImage("orange.jpg")
        },
        new Product_Model
        {
            ProductName = "Guava",
            ProductPrice = 40,
            ProductQuantity = 600,
            ProductDescription = "A tropical fruit with a sweet and slightly tangy taste. It’s rich in Vitamin C, fiber, and has a grainy texture with edible seeds.",
            product_category = 5,
            ProductImage = CopyImage("guava.jpg")
        }, new Product_Model
        {
            ProductName = "Filiz Pasta",
            ProductPrice = 890,
            ProductQuantity = 550,
            ProductDescription = "A popular Italian staple made from wheat, available in various shapes. It’s versatile and used in creamy, spicy, or saucy dishes.",
            product_category = 4,
            ProductImage = CopyImage("g7.jpeg")
        },
        new Product_Model
        {
            ProductName = "Maggi",
            ProductPrice = 350,
            ProductQuantity = 400,
            ProductDescription = "Instant noodles that cook in minutes, famous for their masala flavor. A quick and tasty snack loved by all.",
            product_category = 4,
            
            ProductImage = CopyImage("g6.jpeg")
        },
        new Product_Model
        {
            ProductName = "Cooking Oil",
            ProductPrice = 750,
            ProductQuantity = 650,
            ProductDescription = "Used for frying, sautéing, and baking. Available in varieties like olive, sunflower, and mustard oil, each with its own benefits.",
            product_category = 4,
            ProductImage = CopyImage("g10.jpeg")
        },
        new Product_Model
        {
            ProductName = "Prego Pizza Sauce",
            ProductPrice = 890,
            ProductQuantity = 550,
            ProductDescription = "A tangy tomato-based sauce flavored with herbs and garlic. It’s the key ingredient for making delicious pizzas.",
            product_category = 4,
          
            ProductImage = CopyImage("g4.jpeg")
        },
        new Product_Model
        {
            ProductName = "Flour",
            ProductPrice = 850,
            ProductQuantity = 700,
            ProductDescription = "A fine powder made from wheat, used for making bread, rotis, cakes, and other baked goods.",
            product_category = 4,
            ProductImage = CopyImage("g8.jpeg")
        },
        new Product_Model
        {
            ProductName = "Quick Oats",
            ProductPrice = 550,
            ProductQuantity = 650,
            ProductDescription = "A fiber-rich, healthy grain used for breakfast cereals, smoothies, and baking. Great for digestion and weight management.",
            product_category = 4,
            ProductImage = CopyImage("g2.jpeg")
        },
        new Product_Model
        {
            ProductName = "Potato Spice",
            ProductPrice = 420,
            ProductQuantity = 500,
            ProductDescription = "Flavor-enhancing ingredients like turmeric, cumin, and black pepper, used in cooking to add aroma and taste.",
            product_category = 4,
            ProductImage = CopyImage("g3.jpeg")
        },
        new Product_Model
        {
            ProductName = "Grain",
            ProductPrice = 250,
            ProductQuantity = 300,
            ProductDescription = "Essential food staples like rice, wheat, and barley, providing energy and nutrition in daily meals.",
            product_category = 4,
            ProductImage = CopyImage("g1.jpeg")
        },
        new Product_Model
        {
            ProductName = "Shan Korma Masala",
            ProductPrice = 250,
            ProductQuantity = 300,
            ProductDescription = "A popular spice mix brand that enhances the flavor of traditional dishes like biryani, curry, and BBQ.",
            product_category = 4,
            product_brand = 3,
            ProductImage = CopyImage("g11.jpeg")
        },
        new Product_Model
        {
            ProductName = "Chicken Cubes",
            ProductPrice = 150,
            ProductQuantity = 200,
            ProductDescription = "A concentrated seasoning cube made from chicken broth, salt, and spices. It enhances the flavor of soups, curries, and rice dishes.",
            product_category = 4,
            ProductImage = CopyImage("g5.jpeg")
        },
        new Product_Model
        {
            ProductName = "Nestle Magic Cream",
            ProductPrice = 550,
            ProductQuantity = 600,
            ProductDescription = "A rich and creamy UHT milk known for its freshness and long shelf life. Perfect for tea, desserts, and daily use.",
            product_category = 6,
            product_brand =4,
            ProductImage = CopyImage("milk pak dairy cream.jpeg")
        },
        new Product_Model
        {
            ProductName = "Adam Cheese",
            ProductPrice = 890,
            ProductQuantity = 480,
            ProductDescription = "A popular cheese brand offering a variety of flavors like cheddar and mozzarella, used in sandwiches, pizzas, and snacks.",
            product_category = 6,
            product_brand = 5,
            ProductImage = CopyImage("adam's singles cheese.jpeg")
        },
        new Product_Model
        {
            ProductName = "Nido Powdered Milk",
            ProductPrice = 750,
            ProductQuantity = 400,
            ProductDescription = "A powdered milk brand by Nestlé, rich in vitamins and minerals. It’s a great alternative to fresh milk for growing kids and daily nutrition.",
            product_category = 6,
            product_brand = 4,
            ProductImage = CopyImage("nido img.jpeg")
        },
        new Product_Model
        {
            ProductName = "Kraft Cheese",
            ProductPrice = 560,
            ProductQuantity = 650,
            ProductDescription = "A processed cheese brand known for its creamy texture and rich taste, commonly used in burgers, sandwiches, and sauces.",
            product_category = 6,

            ProductImage = CopyImage("kraft light cheese.jpeg")
        },
        new Product_Model
        {
            ProductName = "Nestle Cream",
            ProductPrice = 890,
            ProductQuantity = 750,
            ProductDescription = "A rich and creamy UHT milk known for its freshness and long shelf life. Perfect for tea, desserts, and daily use.",
            product_category = 6,
            product_brand = 4,
            ProductImage = CopyImage("nestle milk pak cream.jpeg")
        },
        new Product_Model
        {
            ProductName = "FarmHouse Milk",
            ProductPrice = 850,
            ProductQuantity = 650,
            ProductDescription = "A nutritious dairy product packed with calcium and protein, essential for strong bones and a healthy diet.",
            product_category = 6,
            ProductImage = CopyImage("farmhouse fresh milk.jpeg")
        },
        new Product_Model
        {
            ProductName = "Adam's Single Cheese",
            ProductPrice = 780,
            ProductQuantity = 650,
            ProductDescription = "A popular cheese brand offering a variety of flavors like cheddar and mozzarella, used in sandwiches, pizzas, and snacks.",
            product_category = 6,
            product_brand = 5,
            ProductImage = CopyImage("adam's single cheese.jpeg")
        },
        new Product_Model
        {
            ProductName = "Mirhan Milk",
            ProductPrice = 550,
            ProductQuantity = 560,
            ProductDescription = "A nutritious dairy product packed with calcium and protein, essential for strong bones and a healthy diet.",
            product_category = 6,
            ProductImage = CopyImage("mihan milk.jpeg")
        },
        new Product_Model
        {
            ProductName = "Whisper Whippy Cream",
            ProductPrice = 890,
            ProductQuantity = 550,
            ProductDescription = "A rich and smooth whipping cream used for decorating cakes, desserts, and beverages. It gives a light, fluffy texture and a delicious creamy taste.",
            product_category = 6,
            ProductImage = CopyImage("whipy whip whipping cream.jpeg")
        },new Product_Model
        {
            ProductName = "Milo Chocobar",
            ProductPrice = 250,
            ProductQuantity = 590,
            ProductDescription = "A chocolate-covered ice cream bar, offering a crunchy and creamy delight in every bite.",
            product_category = 8,
            ProductImage = CopyImage("s10.jpeg")
        },
        new Product_Model
        {
            ProductName = "Milo Ice Cream",
            ProductPrice = 890,
            ProductQuantity = 250,
            ProductDescription = "A creamy and chocolatey ice cream infused with the malty goodness of Milo, perfect for a refreshing treat.",
            product_category = 8,
           
            ProductImage = CopyImage("s12.jpeg")
        },
        new Product_Model
        {
            ProductName = "Lays Chips",
            ProductPrice = 40,
            ProductQuantity = 550,
            ProductDescription = "A crispy potato chip brand available in various flavors like classic salted, masala, and BBQ. A go-to snack.",
            product_category = 8,
            product_brand = 6,
            ProductImage = CopyImage("s7.jpeg")
        },
        new Product_Model
        {
            ProductName = "Cheetose Chips",
            ProductPrice = 50,
            ProductQuantity = 520,
            ProductDescription = "Crunchy or cheesy corn snacks with bold flavors. The spicy Flamin’ Hot version is a fan favorite.",
            product_category = 8,
            ProductImage = CopyImage("s8.jpeg")
        },
        new Product_Model
        {
            ProductName = "Mars Chocolate",
            ProductPrice = 80,
            ProductQuantity = 400,
            ProductDescription = "A chocolate bar with caramel and nougat, offering a perfect balance of sweetness and chewiness.",
            product_category = 8,
            ProductImage = CopyImage("s6.jpeg")
        },
        new Product_Model
        {
            ProductName = "M&M’s",
            ProductPrice = 550,
            ProductQuantity = 740,
            ProductDescription = "Colorful candy-coated chocolates with a crunchy shell and a rich chocolate center. Available in peanut and classic varieties.",
            product_category = 8,
            ProductImage = CopyImage("s2.jpeg")
        },
        new Product_Model
        {
            ProductName = "M&M’s",
            ProductPrice = 850,
            ProductQuantity = 650,
            ProductDescription = "Colorful candy-coated chocolates with a crunchy shell and a rich chocolate center. Available in peanut and classic varieties.",
            product_category = 8,
            ProductImage = CopyImage("s3.jpeg")
        },
        new Product_Model
        {
            ProductName = "Oreo Ice Cream",
            ProductPrice = 580,
            ProductQuantity = 200,
            ProductDescription = "A creamy and chocolatey ice cream infused with the malty goodness of Oreo, perfect for a refreshing treat.",
            product_category = 8,
            ProductImage = CopyImage("s11.jpeg")
        },
        new Product_Model
        {
            ProductName = "Snickers Chocolate",
            ProductPrice = 220,
            ProductQuantity = 450,
            ProductDescription = "A chocolate bar with caramel and nougat, offering a perfect balance of sweetness and chewiness.",
            product_category = 8,
          
            ProductImage = CopyImage("s9.jpeg")
        },
          new Product_Model
        {
            ProductName = "Raw Chicken Leg Piece",
            ProductPrice = 2400,
            ProductQuantity = 450,
            ProductDescription = "Fresh and high-quality chicken leg pieces, perfect for frying, grilling, or making delicious curries.",
            product_category = 9,
            ProductImage = CopyImage("raw_chicken_leg_piece.jpeg")
        },
        new Product_Model
        {
            ProductName = "Fresh Lamb Beefs Cutlets",
            ProductPrice = 1500,
            ProductQuantity = 450,
            ProductDescription = "Tender and juicy lamb beef cutlets, ideal for grilling, roasting, or stewing.",
            product_category = 9,
            ProductImage = CopyImage("fresh_lamb_beefs_cutlets.jpeg")
        },
        new Product_Model
        {
            ProductName = "Raw Meat Cutlets",
            ProductPrice = 890,
            ProductQuantity = 200,
            ProductDescription = "High-quality raw meat cutlets, perfect for preparing kebabs, curries, or barbecues.",
            product_category = 9,
            ProductImage = CopyImage("raw_meat_cutlets.jpeg")
        },
        new Product_Model
        {
            ProductName = "Fresh Sardine Fish",
            ProductPrice = 1500,
            ProductQuantity = 700,
            ProductDescription = "Fresh sardine fish, rich in omega-3 fatty acids, perfect for frying, grilling, or making delicious seafood dishes.",
            product_category = 9,
            ProductImage = CopyImage("fresh_sardine_fish.jpeg")
        },
        new Product_Model
        {
            ProductName = "Fresh Mutton",
            ProductPrice = 2500,
            ProductQuantity = 200,
            ProductDescription = "Premium quality fresh mutton, packed with protein and ideal for various traditional dishes.",
            product_category = 9,
            ProductImage = CopyImage("fresh_mutton.jpeg")
        },
        new Product_Model
        {
            ProductName = "Silver Barb Fish",
            ProductPrice = 890,
            ProductQuantity = 800,
            ProductDescription = "Silver Barb Fish, a delicious and healthy seafood choice, great for frying or making fish curries.",
            product_category = 9,
            ProductImage = CopyImage("silver_barb_fish.jpeg")
        },
        new Product_Model
        {
            ProductName = "Raw Shrimp",
            ProductPrice = 750,
            ProductQuantity = 800,
            ProductDescription = "High-quality raw shrimp, perfect for making shrimp tempura, seafood pasta, or curries.",
            product_category = 9,
            ProductImage = CopyImage("raw_shrimp.jpeg")
        },
        new Product_Model
        {
            ProductName = "Chicken Boneless Piece",
            ProductPrice = 990,
            ProductQuantity = 500,
            ProductDescription = "Fresh boneless chicken pieces, ideal for stir-frying, grilling, or making delicious chicken dishes.",
            product_category = 9,
            ProductImage = CopyImage("chicken_boneless_piece.jpeg")
        },
        new Product_Model
        {
            ProductName = "Raw Beef Piece",
            ProductPrice = 890,
            ProductQuantity = 450,
            ProductDescription = "Fresh raw beef pieces, perfect for making steaks, roasts, and traditional beef dishes.",
            product_category = 9,
            ProductImage = CopyImage("raw_beef_piece.jpeg")
        },new Product_Model
        {
            ProductName = "Purple Girls Sneaker",
            ProductPrice = 2000,
            ProductQuantity = 150,
            ProductDescription = "Stylish and comfortable sneakers designed for casual wear, sports, and everyday activities.",
            product_category = 11,
            ProductImage = CopyImage("purple_girls_sneaker.jpeg")
        },
        new Product_Model
        {
            ProductName = "Pink Girls Sneaker",
            ProductPrice = 1500,
            ProductQuantity = 50,
            ProductDescription = "Trendy pink sneakers offering both comfort and style for girls.",
            product_category = 11,
            ProductImage = CopyImage("pink_girls_sneaker.jpeg")
        },
        new Product_Model
        {
            ProductName = "Girls Pink Shoes",
            ProductPrice = 2000,
            ProductQuantity = 100,
            ProductDescription = "Elegant pink shoes designed for girls, perfect for casual and formal wear.",
            product_category = 11,
            ProductImage = CopyImage("girls_pink_shoes.jpeg")
        },
        new Product_Model
        {
            ProductName = "Soft Clunky Girls Sneakers",
            ProductPrice = 2500,
            ProductQuantity = 250,
            ProductDescription = "Soft and stylish chunky sneakers for girls, great for daily wear and sports.",
            product_category = 11,
            ProductImage = CopyImage("soft_clunky_girls_sneakers.jpeg")
        },
        new Product_Model
        {
            ProductName = "Women Tennis Shoes",
            ProductPrice = 3000,
            ProductQuantity = 80,
            ProductDescription = "Durable and comfortable tennis shoes for women, ideal for sports and outdoor activities.",
            product_category = 11,
            ProductImage = CopyImage("women_tennis_shoes.jpeg")
        },
        new Product_Model
        {
            ProductName = "Women Casual Lace Shoes",
            ProductPrice = 2000,
            ProductQuantity = 100,
            ProductDescription = "Casual lace-up shoes for women, providing comfort and style.",
            product_category = 11,
            ProductImage = CopyImage("women_casual_lace_shoe.jpeg")
        },
        new Product_Model
        {
            ProductName = "Casual Comfy Slipper",
            ProductPrice = 1500,
            ProductQuantity = 200,
            ProductDescription = "Lightweight and comfortable slippers for everyday use.",
            product_category = 11,
            ProductImage = CopyImage("casual_comfy_slipper.jpeg")
        },
        new Product_Model
        {
            ProductName = "Leather Loafers Black",
            ProductPrice = 2500,
            ProductQuantity = 150,
            ProductDescription = "Premium black leather loafers, perfect for a smart and stylish look.",
            product_category = 11,
            ProductImage = CopyImage("leather_loafers_black.jpeg")
        },
        new Product_Model
        {
            ProductName = "Summer Flip Flops Men",
            ProductPrice = 1000,
            ProductQuantity = 500,
            ProductDescription = "Comfortable and stylish flip-flops for men, great for summer and casual outings.",
            product_category = 11,
            ProductImage = CopyImage("summer_flip_flops_men.jpeg")
        },
        new Product_Model
        {
            ProductName = "Women's Heels Pumps",
            ProductPrice = 5000,
            ProductQuantity = 200,
            ProductDescription = "Elegant high-heel pumps for women, perfect for formal and party wear.",
            product_category = 11,
            ProductImage = CopyImage("women_heels_pumps.jpeg")
        },
         new Product_Model
        {
            ProductName = "Spiral Notebook",
            ProductPrice = 550,
            ProductQuantity = 2000,
            ProductDescription = "A collection of blank or ruled pages bound together, ideal for writing, note-taking, or journaling.",
            product_category = 10,
            ProductImage = CopyImage("spiral_notebook.jpeg")
        },
        new Product_Model
        {
            ProductName = "File Folder",
            ProductPrice = 50,
            ProductQuantity = 200,
            ProductDescription = "A sturdy cover used to organize and store important documents safely.",
            product_category = 10,
            ProductImage = CopyImage("file_folder.jpeg")
        },
        new Product_Model
        {
            ProductName = "Art Markers",
            ProductPrice = 450,
            ProductQuantity = 250,
            ProductDescription = "Colorful writing tools with thick ink, perfect for highlighting, drawing, and creative projects.",
            product_category = 10,
            ProductImage = CopyImage("art_markers.jpeg")
        },
        new Product_Model
        {
            ProductName = "A4 Plastic Clipboard",
            ProductPrice = 80,
            ProductQuantity = 100,
            ProductDescription = "A durable and lightweight clipboard, perfect for holding A4 documents securely.",
            product_category = 10,
            ProductImage = CopyImage("a4_plastic_clipboard.jpeg")
        },
        new Product_Model
        {
            ProductName = "Candy Floss Diary",
            ProductPrice = 480,
            ProductQuantity = 200,
            ProductDescription = "A stylish diary with blank or ruled pages, ideal for journaling and personal notes.",
            product_category = 10,
            ProductImage = CopyImage("candy_floss_diary.jpeg")
        },
        new Product_Model
        {
            ProductName = "6pcs Pastel Markers",
            ProductPrice = 580,
            ProductQuantity = 150,
            ProductDescription = "A set of six pastel-colored markers for smooth and vibrant writing.",
            product_category = 10,
            ProductImage = CopyImage("6pcs_pastel_markers.jpeg")
        },
        new Product_Model
        {
            ProductName = "Premium Stapler",
            ProductPrice = 80,
            ProductQuantity = 60,
            ProductDescription = "A high-quality stapler for efficiently binding documents together.",
            product_category = 10,
            ProductImage = CopyImage("premium_stapler.jpeg")
        },
        new Product_Model
        {
            ProductName = "Notebook",
            ProductPrice = 850,
            ProductQuantity = 100,
            ProductDescription = "A high-quality notebook, great for taking notes, journaling, and professional use.",
            product_category = 10,
            ProductImage = CopyImage("notebook.jpeg")
        },
        new Product_Model
        {
            ProductName = "4pcs Wooden Clipboard",
            ProductPrice = 890,
            ProductQuantity = 100,
            ProductDescription = "A set of four sturdy wooden clipboards, perfect for holding documents securely.",
            product_category = 10,
            ProductImage = CopyImage("4pcs_wooden_clipboard.jpeg")
        },
        new Product_Model
        {
            ProductName = "Star Pen Holder",
            ProductPrice = 80,
            ProductQuantity = 200,
            ProductDescription = "A desk organizer designed to keep pens, pencils, and other stationery items neatly arranged.",
            product_category = 10,
            ProductImage = CopyImage("star_pen_holder.jpeg")
        },
        new Product_Model
        {
            ProductName = "Washi Tape Set",
            ProductPrice = 350,
            ProductQuantity = 230,
            ProductDescription = "A collection of decorative and functional adhesive tapes for creative and practical uses.",
            product_category = 10,
            ProductImage = CopyImage("washi_tape_set.jpeg")
        },
        new Product_Model
        {
            ProductName = "Floral Print Shirt",
            ProductPrice = 2000,
            ProductQuantity = 100,
            ProductDescription = "A stylish floral print shirt, perfect for casual and semi-formal occasions. Made from premium cotton fabric.",
            product_category = 12,
            ProductImage = CopyImage("floral_print_shirt.jpeg")
        },
        new Product_Model
        {
            ProductName = "Hawaiian Men's Shirt",
            ProductPrice = 420,
            ProductQuantity = 500,
            ProductDescription = "A trendy Hawaiian-style shirt, lightweight and comfortable for vacations and summer outings.",
            product_category = 12,
            ProductImage = CopyImage("hawaiian_mens_shirt.jpeg")
        },
        new Product_Model
        {
            ProductName = "Typography White T-shirt",
            ProductPrice = 250,
            ProductQuantity = 3400,
            ProductDescription = "A stylish white T-shirt with bold typography prints, made from soft and breathable cotton fabric.",
            product_category = 12,
            ProductImage = CopyImage("typography_white_tshirt.jpeg")
        },
        new Product_Model
        {
            ProductName = "Smile Print T-shirt",
            ProductPrice = 890,
            ProductQuantity = 500,
            ProductDescription = "A trendy and comfortable T-shirt featuring a fun smile print. Ideal for everyday casual wear.",
            product_category = 12,
            ProductImage = CopyImage("smile_print_tshirt.jpeg")
        },
        new Product_Model
        {
            ProductName = "3D Print Men's Shirt",
            ProductPrice = 450,
            ProductQuantity = 250,
            ProductDescription = "A modern 3D print shirt that adds a unique and stylish touch to your wardrobe.",
            product_category = 12,
            ProductImage = CopyImage("3d_print_mens_shirt.jpeg")
        },
        new Product_Model
        {
            ProductName = "Hawaiian Men's Shirt",
            ProductPrice = 1000,
            ProductQuantity = 50,
            ProductDescription = "A premium Hawaiian men's shirt, perfect for a relaxed and fashionable summer look.",
            product_category = 12,
            ProductImage = CopyImage("hawaiian_mens_shirt_2.jpeg")
        },
        new Product_Model
        {
            ProductName = "Maroon Casual Shirt",
            ProductPrice = 1500,
            ProductQuantity = 230,
            ProductDescription = "A maroon-colored casual shirt designed for a stylish and comfortable everyday outfit.",
            product_category = 12,
            ProductImage = CopyImage("maroon_casual_shirt.jpeg")
        },
        new Product_Model
        {
            ProductName = "Long Sleeve Shirt",
            ProductPrice = 1500,
            ProductQuantity = 420,
            ProductDescription = "A versatile long sleeve shirt, ideal for both formal and casual settings.",
            product_category = 12,
            ProductImage = CopyImage("long_sleeve_shirt.jpeg")
        },
        new Product_Model
        {
            ProductName = "Corduroy Long Sleeve Shirt",
            ProductPrice = 2500,
            ProductQuantity = 100,
            ProductDescription = "A premium corduroy long sleeve shirt, adding texture and warmth to your wardrobe.",
            product_category = 12,
            ProductImage = CopyImage("corduroy_long_sleeve_shirt.jpeg")
        },

        new Product_Model
        {
            ProductName = "2 Piece Embroidered Khaddar Suit",
            ProductPrice = 3500,
            ProductQuantity = 200,
            ProductDescription = "A premium-quality embroidered Khaddar suit with elegant and trendy designs, ideal for winter wear.",
            product_category = 3,
            product_brand = 1,
            ProductImage = CopyImage("2_piece_emb_khaddar.jpeg")
        },
        new Product_Model
        {
            ProductName = "Printed Cotton 2 Piece",
            ProductPrice = 2500,
            ProductQuantity = 350,
            ProductDescription = "A soft and comfortable printed cotton suit, perfect for daily wear with stylish patterns.",
            product_category = 3,
            product_brand = 7,
            ProductImage = CopyImage("printed_cotton_2piece.jpeg")
        },
        new Product_Model
        {
            ProductName = "3 Piece Khaddar Suit",
            ProductPrice = 4500,
            ProductQuantity = 500,
            ProductDescription = "A luxurious 3-piece Khaddar suit featuring intricate embroidery and premium fabric quality.",
            product_category = 3,
            product_brand = 8,
            ProductImage = CopyImage("3_piece_khaddar_suit.jpeg")
        },
        new Product_Model
        {
            ProductName = "Lawn Shirt",
            ProductPrice = 2500,
            ProductQuantity = 200,
            ProductDescription = "A lightweight and breathable lawn shirt, designed for casual and semi-formal wear.",
            product_category = 3,
            product_brand = 1,
            ProductImage = CopyImage("lawn_shirt.jpeg")
        },
        new Product_Model
        {
            ProductName = "Zellbury Three Piece Cambric",
            ProductPrice = 3500,
            ProductQuantity = 450,
            ProductDescription = "A stylish Zellbury 3-piece cambric suit, featuring trendy prints and vibrant colors.",
            product_category = 3,
            product_brand = 1,
            ProductImage = CopyImage("zellbury_3piece_cambric.jpeg")
        },
        new Product_Model
        {
            ProductName = "2 Piece Embroidered Suit",
            ProductPrice = 2500,
            ProductQuantity = 200,
            ProductDescription = "A beautifully embroidered 2-piece suit, perfect for formal and semi-formal occasions.",
            product_category = 3,
            product_brand = 2,
            ProductImage = CopyImage("2_piece_emb_suit.jpeg")
        },
        new Product_Model
        {
            ProductName = "Ethnic Shine Printed Suit",
            ProductPrice = 4500,
            ProductQuantity = 200,
            ProductDescription = "An elegant ethnic shine printed suit, made from high-quality fabric with artistic patterns.",
            product_category = 3,
            product_brand = 8,
            ProductImage = CopyImage("ethnic_shine_printed_suit.jpeg")
        },
        new Product_Model
        {
            ProductName = "Floral Print Lawn",
            ProductPrice = 3500,
            ProductQuantity = 200,
            ProductDescription = "A fresh and stylish floral print lawn suit, designed for summer comfort and fashion.",
            product_category = 3,
            product_brand = 7,
            ProductImage = CopyImage("floral_print_lawn.jpeg")
        },
        new Product_Model
        {
            ProductName = "Purple Khaddar Printed Suit",
            ProductPrice = 4200,
            ProductQuantity = 150,
            ProductDescription = "A rich purple Khaddar printed suit, featuring intricate designs and premium fabric quality.",
            product_category = 3,
            product_brand = 1,
            ProductImage = CopyImage("purple_khaddar_suit.jpeg")
        },
        new Product_Model
        {
            ProductName = "Unstitched Khaddar Suit",
            ProductPrice = 3600,
            ProductQuantity = 40,
            ProductDescription = "A high-quality unstitched Khaddar suit, perfect for customizing into a unique outfit.",
            product_category = 3,
            product_brand = 7,
            ProductImage = CopyImage("unstitched_khaddar_suit.jpeg")
        },
        new Product_Model
        {
            ProductName = "Matte Lipstick",
            ProductPrice = 450,
            ProductQuantity = 450,
            ProductDescription = "A long-lasting lipstick with a non-shiny, velvety finish. Available in bold and nude shades.",
            product_category = 7,
      
            ProductImage = CopyImage("mk3.jpeg")
        },
        new Product_Model
        {
            ProductName = "Fair Beauty Cream",
            ProductPrice = 250,
            ProductQuantity = 100,
            ProductDescription = "A skincare product designed to brighten the complexion and provide hydration, often enriched with vitamins.",
            product_category = 7,
         
            ProductImage = CopyImage("mk4.jpeg")
        },
        new Product_Model
        {
            ProductName = "Eye Shadow",
            ProductPrice = 750,
            ProductQuantity = 80,
            ProductDescription = "A makeup product used to enhance the eyes with colors, available in matte, shimmer, and glitter textures.",
            product_category = 7,

            ProductImage = CopyImage("mk2.jpeg")
        },
        new Product_Model
        {
            ProductName = "Nail Polish",
            ProductPrice = 150,
            ProductQuantity = 200,
            ProductDescription = "A liquid cosmetic applied to nails for color and shine. Comes in glossy, matte, and glitter finishes.",
            product_category = 7,
       
            ProductImage = CopyImage("mk8.jpeg")
        },
        new Product_Model
        {
            ProductName = "Lash Mascara",
            ProductPrice = 550,
            ProductQuantity = 250,
            ProductDescription = "A makeup essential used to lengthen, darken, and volumize eyelashes for a bold and dramatic eye look.",
            product_category = 7,
          
            ProductImage = CopyImage("mk10.jpeg")
        },
        new Product_Model
        {
            ProductName = "Foundation",
            ProductPrice = 560,
            ProductQuantity = 600,
            ProductDescription = "A base makeup product that evens out skin tone, providing a smooth and flawless complexion. Available in liquid, powder, and cream forms.",
            product_category = 7,
        
            ProductImage = CopyImage("mk7.jpeg")
        },
        new Product_Model
        {
            ProductName = "Contour",
            ProductPrice = 450,
            ProductQuantity = 350,
            ProductDescription = "A makeup product used to define and sculpt facial features by creating shadows and depth. Available in powder, cream, and stick forms for a chiseled look.",
            product_category = 7,
       
            ProductImage = CopyImage("mk9.jpeg")
        },
        new Product_Model
        {
            ProductName = "BB Cream",
            ProductPrice = 550,
            ProductQuantity = 150,
            ProductDescription = "A skincare product designed to brighten the complexion and provide hydration, often enriched with vitamins.",
            product_category = 7,
          
            ProductImage = CopyImage("mk5.jpeg")
        },
         new Product_Model
        {
            ProductName = "Washing Machine",
            ProductPrice = 5500,
            ProductQuantity = 400,
            ProductDescription = "A home appliance that automatically washes clothes, saving time and effort. Available in top-load and front-load models.",
            product_category = 1,
         
            ProductImage = CopyImage("e2.jpeg")
        },
        new Product_Model
        {
            ProductName = "Toaster",
            ProductPrice = 2000,
            ProductQuantity = 100,
            ProductDescription = "A small appliance that crisps and browns bread slices quickly. Perfect for making breakfast toast or sandwiches.",
            product_category = 1,
         
            ProductImage = CopyImage("e9.jpeg")
        },
        new Product_Model
        {
            ProductName = "Iron",
            ProductPrice = 4500,
            ProductQuantity = 200,
            ProductDescription = "A household appliance used to remove wrinkles from clothes with heat. Available in steam and dry models for smooth and crisp ironing.",
            product_category = 1,
          
            ProductImage = CopyImage("e10.jpeg")
        },
        new Product_Model
        {
            ProductName = "Fridge (Refrigerator)",
            ProductPrice = 5800,
            ProductQuantity = 150,
            ProductDescription = "A cooling appliance used to store food and beverages, keeping them fresh for longer. Available in various sizes and styles.",
            product_category = 1,
           
            ProductImage = CopyImage("e7.jpeg")
        },
        new Product_Model
        {
            ProductName = "Bread Toaster",
            ProductPrice = 2400,
            ProductQuantity = 26,
            ProductDescription = "A small appliance that crisps and browns bread slices quickly. Perfect for making breakfast toast or sandwiches.",
            product_category = 1,
  
            ProductImage = CopyImage("e8.jpeg")
        },
        new Product_Model
        {
            ProductName = "Stand Mixer",
            ProductPrice = 4500,
            ProductQuantity = 200,
            ProductDescription = "A powerful kitchen appliance used for mixing, kneading, and whipping ingredients. Perfect for baking cakes, bread, and cookies.",
            product_category = 1,
           
            ProductImage = CopyImage("e6.jpeg")
        },
        new Product_Model
        {
            ProductName = "Orange Juicer",
            ProductPrice = 5500,
            ProductQuantity = 35,
            ProductDescription = "A handy appliance that extracts fresh juice from oranges effortlessly. Available in manual and electric models for quick and easy juicing.",
            product_category = 1,
          
            ProductImage = CopyImage("e4.jpeg")
        },
        new Product_Model
        {
            ProductName = "Fruit Mixer",
            ProductPrice = 3500,
            ProductQuantity = 50,
            ProductDescription = "A kitchen appliance used to blend fruits into smoothies, shakes, and juices. It’s perfect for making healthy drinks quickly and easily.",
            product_category = 1,
       
            ProductImage = CopyImage("e5.jpeg")
        },
        new Product_Model
        {
            ProductName = "Hand Beater",
            ProductPrice = 2500,
            ProductQuantity = 40,
            ProductDescription = "A lightweight kitchen tool used for beating eggs, whipping cream, and mixing batter. It’s easy to use and perfect for baking.",
            product_category = 1,
         
            ProductImage = CopyImage("e11.jpeg")
        }


        });

                db.SaveChanges();
            }
        }

        private string CopyImage(string fileName)
        {
           
            string sourcePath = Path.Combine(env.WebRootPath, "seedImages", fileName);


         
            string destinationFolder = Path.Combine(env.WebRootPath, "ProductImages");

           
            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }

            string destinationFile = Path.Combine(destinationFolder, fileName);

         
            if (File.Exists(sourcePath) && !File.Exists(destinationFile))
            {
                File.Copy(sourcePath, destinationFile);
            }

            return fileName; 
        }
    }
}
