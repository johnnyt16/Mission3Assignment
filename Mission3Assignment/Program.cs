// See https://aka.ms/new-console-template for more information

using Mission3Assignment;

internal class Program
{
    private static List<FoodItem> inventory = new List<FoodItem>();

    public static void Main(string[] args)
    {
        // Initialize 
        string FoodName = "";
        string FoodCategory = "";
        int FoodQty = 0;
        DateTime ExpirationDate = new DateTime();

        while (true)
        {

            // Give the user options of what to do
            Console.WriteLine("\nIf you would like to view current inventory, type: VIEW");
            Console.WriteLine("If you would like to add food items, type: ADD");
            Console.WriteLine("If you would like to delete food items, type: DELETE");
            Console.WriteLine("If you would like to exit the program, type: EXIT");

            string userChoice = Console.ReadLine()?.ToUpper();

            // Execute the VIEW response
            if (userChoice == "VIEW")
            {
                Console.WriteLine("\n--- Current Inventory ---");
                if (inventory.Count == 0)
                {
                    Console.WriteLine("Inventory is empty.");
                }
                else
                {
                    foreach (var item in inventory)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }

            // Execute the ADD response
            if (userChoice == "ADD")
            {
                Console.WriteLine("\n--- Add Food Item ---");
                // Get input info about item
                Console.WriteLine("Enter food item name: ");
                FoodName = Console.ReadLine();
                Console.WriteLine("Enter food category:");
                FoodCategory = Console.ReadLine();
                Console.WriteLine("Enter food item quantity: ");
                FoodQty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter expiration date (MM/DD/YYYY): ");
                ExpirationDate = DateTime.Parse(Console.ReadLine());

                // Use info to create new Item
                FoodItem newItem = new FoodItem(FoodName, FoodCategory, FoodQty, ExpirationDate);
                
                // Add the new item to the inventory
                inventory.Add(newItem);

                Console.WriteLine("Successfully inputted.");
            }

            if (userChoice == "DELETE")
            {
                Console.WriteLine("\n--- Delete Food Item ---");
                Console.Write("Enter the name of the food item to delete: ");
                string nameToDelete = Console.ReadLine();

                FoodItem itemToDelete =
                    inventory.Find(item => item.Name.Equals(nameToDelete, StringComparison.OrdinalIgnoreCase));

                if (itemToDelete != null)
                {
                    inventory.Remove(itemToDelete);
                    Console.WriteLine("Food item deleted successfully!");
                }
                else
                {
                    Console.WriteLine("Food item not found.");
                }
            }

            if (userChoice == "EXIT")
            {
                Console.WriteLine("Exiting program. Goodbye!");
                return;
            }
            
        }
    }
}
    
        
        
        