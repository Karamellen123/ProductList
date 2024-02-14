// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<string> ProductLists = new List<string>();

MainMenu();

void printList()
{
    Console.WriteLine("Printing list");
    for (int i = 0; i < ProductLists.Count; i++)
    {
        Console.WriteLine("Item: " + ProductLists[i]);
    }  
}

void AddProduct()
{
    Console.WriteLine("What product would you like to add? ");
    string temp = Console.ReadLine();

    if (temp == "exit")
        printList();
    else
    {
        ProductLists.Add(temp);
        MainMenu();
    }
}

void MainMenu()
{
    AddProduct();
}