namespace bicycleConsole1;

class Program
{
    static void Main(string[] args)
    {
        // task 1
        Console.WriteLine("task 1");
        string input;
        string[] data;
        
        do
        {
            Console.WriteLine("Enter fullname, age, address, phone number, weight\nSeparated by \";\"(semicolon)");
            input = Console.ReadLine().Trim();
        
            data = input.Split(";");
        
            if (data.Length != 5)
            {
                Console.WriteLine("---------");
                Console.WriteLine("try again");
                Console.WriteLine("---------");
            }
            else
            {
                break;
            }
        } while(true);
        
        // remove whitespaces
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = data[i].Trim();
        }
        
        string name = data[0];
        int age = int.Parse(data[1]);
        string address = data[2];
        string phoneNumber = data[3];
        float weight = float.Parse(data[4].Replace('.', ','));
        
        Console.WriteLine("---------");
        
        string result = "You entered: ";
        
        // я хотел бы сделать функцию для этого, но не знаю как(
        result += "\"" + name + "\"" + $", it's type is - {name.GetType()}\n";
        result += "\"" + age + "\"" + $", it's type is - {age.GetType()}\n";
        result += "\"" + address + "\"" + $", it's type is - {address.GetType()}\n";
        result += "\"" + phoneNumber + "\"" + $", it's type is - {phoneNumber.GetType()}\n";
        result += "\"" + weight + "\"" + $", it's type is - {weight.GetType()}";
        
        Console.WriteLine(result);
        
        Console.WriteLine("---------");

        Console.WriteLine("Press enter to start task 2");
        Console.ReadLine();
        Console.Clear();

        // task 2 
        Console.WriteLine("task 2");
        Console.WriteLine("Making new product (there must be an emoji)");

        Console.WriteLine("Enter the name of the product");
        string inputName = Console.ReadLine().ToUpper().Trim();
        
        float inputQuantity;
        string inputType;
        do
        {
            Console.WriteLine("Enter the quantity of the product");
            inputQuantity = float.Parse(Console.ReadLine().Trim().Replace('.', ','));

            Console.WriteLine("Enter the type of units of the product");
            Console.WriteLine("things, kg, tons, litres, etc");
            inputType = Console.ReadLine().ToLower().Trim();

            if (inputType == "things" && inputQuantity % 1 != 0)
            {
                Console.WriteLine("\"Things\" must be integer");
                Console.WriteLine("Try again\n\n");
            }
            else
            {
                break;
            }
        } while(true);

        Console.WriteLine("Add price");
        float inputPrice = float.Parse(Console.ReadLine().Trim().Replace('.', ','));
        
        Console.Clear();

        Console.WriteLine("New product created");
        Console.WriteLine("Product data:");

        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine($"| Name: {inputName}\n| Quantity: {inputQuantity}\n| Type: {inputType}\n| Price: {inputPrice}");
        Console.WriteLine("-----------------------------------------------");
    }
}