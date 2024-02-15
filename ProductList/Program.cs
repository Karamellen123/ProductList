using System.Text.RegularExpressions;

List<string> ProductLists = new List<string>();

MainMenu();

void printList()
{
    Console.WriteLine("Printing list");
    for (int i = 0; i < ProductLists.Count; i++)
        Console.WriteLine(i + ") " + ProductLists[i]);
}

void AddProduct()
{
    Console.WriteLine("What product would you like to add? ");
    string temp = Console.ReadLine();

    //if (temp.Contains("exit"))
    Regex exitRegex = new Regex(@"\b(exit|quit|end)\b", RegexOptions.IgnoreCase);

    // Check if the input matches the pattern
    if (exitRegex.IsMatch(temp))
        printList();
    else
    {
        ProductLists.Add(temp);
        Console.WriteLine("You have added: " + temp + " to your product list");
        MainMenu();
    }
}

void MainMenu()
{
    AddProduct();
}