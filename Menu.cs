namespace AddToArray
{
    public class Menu
    {
        SodaCrate crate = new SodaCrate();
        public void PrintMenu()
        {
            bool isActive = true;
            while(isActive)
            {
                Console.WriteLine("Välkommen till Läskfabriken!");
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("1. Lägg till läsk i backen");
                Console.WriteLine("2. Visa din back");
                Console.WriteLine("3. Ta bort läsk ur backen.");
                Console.WriteLine("4. Betala");
                Console.WriteLine("5. Avsluta");
                int userInput = Convert.ToInt32(Console.ReadLine());

                switch(userInput)
                {
                    case 1:
                        if(crate.sodas.Count > 23)
                        {
                            Console.WriteLine("Din back är full. Betala och fyll en ny!");
                        }
                        else
                        {
                            AddSodaToCrate();
                        }
                        break;
                    case 2:
                        if(CheckIfEmpty())
                        {
                            Console.WriteLine("Din back är tom!");
                        }
                        else
                        {
                            Console.Clear();
                            crate.PrintCrate();
                        }
                        break;
                    case 3:
                        if(CheckIfEmpty())
                        {
                            Console.WriteLine("Din back är tom!");
                        }
                        else
                        {
                            RemoveFromCrate();
                        }
                        break;
                    case 4:
                        if(CheckIfEmpty())
                        {
                            Console.WriteLine("Din back är tom!");
                        }
                        else
                        {
                            Checkout();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Avslutar...");
                        isActive = false;
                        break;

                    default:
                        Console.WriteLine("Use numbers 1-4!");
                        break;
                }

            }
        }
        public void AddSodaToCrate()
        {
            Console.WriteLine("Choose a soda to add [1-4]");
            Console.WriteLine("1. Cola");
            Console.WriteLine("2. Pepsi");
            Console.WriteLine("3. Fanta");
            Console.WriteLine("4. Sprite");

            int chosenSoda = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hur många vill du ha?");
            int chosenAmount = Convert.ToInt32(Console.ReadLine());
            if(chosenAmount + crate.sodas.Count > 24)
            {
                Console.WriteLine("Det finns bara " + (24 - crate.sodas.Count) + " platser kvar i backen. Du försökte lägga till " + chosenAmount + "st flaskor..");
            }
            else
            {
                switch(chosenSoda)
                {
                    case 1:
                        for(int i = 0; i < chosenAmount; i++)
                        {
                            crate.Add(new Soda("Coke", 8, 50));
                        }
                        Console.WriteLine(chosenAmount + "st Cola har lagts till i varukorgen. Du har nu " + (24 - crate.sodas.Count) + " platser kvar i din back.");
                        break;
                    case 2:
                        for(int i = 0; i < chosenAmount; i++)
                        {
                            crate.Add(new Soda("Pepsi", 8, 30));
                        }
                        Console.WriteLine(chosenAmount + "st Pepsi har lagts till i varukorgen. Du har nu " + (24 - crate.sodas.Count) + " platser kvar i din back.");
                        break;
                    case 3:
                        for(int i = 0; i < chosenAmount; i++)
                        {
                            crate.Add(new Soda("Fanta", 8, 60));
                        }
                        Console.WriteLine(chosenAmount + "st Fanta har lagts till i varukorgen. Du har nu " + (24 - crate.sodas.Count) + " platser kvar i din back.");
                        break;
                    case 4:
                        for(int i = 0; i < chosenAmount; i++)
                        {
                            crate.Add(new Soda("Sprite", 8, 40));
                        }
                        Console.WriteLine(chosenAmount + "st Sprite har lagts till i varukorgen. Du har nu " + (24 - crate.sodas.Count) + " platser kvar i din back.");
                        break;
                    default:
                        Console.WriteLine("You entered a faulty number. Try again with 1-4..");
                        break;
                }
            }
        }
        public void Checkout()
        {
            int total = 0;
            foreach(Soda soda in crate.sodas)
            {
                total += soda.Price;
            }
            bool isActive = true;
            while(isActive)
            {
                Console.WriteLine("Your total: " + total + "kr");
                Console.WriteLine("Enter [1] to pay. Or [0] to cancel and return to menu.");

                string? input = Console.ReadLine();
                
                if(input == "1")
                {
                    Console.WriteLine("You payed " + total + "kr. Thank you for your shopping!");
                    isActive = false;
                }
                else if(input == "0")
                {
                    Console.Clear();
                    isActive = false;
                }
                else
                {
                    Console.WriteLine("You made a faulty choice...");
                }

            }
        }
        public void RemoveFromCrate()
        {
            Console.Clear();
            Console.WriteLine("Välj vilken flaska du vill ta bort.");
            crate.PrintCrate();
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You removed " + crate.sodas[input].Name + " from position " + input);
            try
            {
                crate.sodas.RemoveAt(input);
            }
            catch (System.Exception)
            { 
                throw;
            }
            
        }
        public bool CheckIfEmpty()
        {
            if(crate.sodas.Count < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}