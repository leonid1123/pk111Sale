string[,] names = {
{ "булочка с ветчиной и сыром", "Адренали", "Сгущенка" },
{ "булочка с сосиской", "Добрый кола", "Ряженка" },
{ "булочка с сорделькой", "Аскания", "Тан" },
{ "булочка итальянская", "Квас Очаковский", "Сыр пармезан" },
{ "булочка с маком", "Байкал", "Кумыс" },
{ "булочка с курицей","Рэд бул" , "Сыр косичка" },
{ "булочка с сёмгой", "Святой источник","Творог"  },
{ "Белый хлеб","Тархун" , "Мороженое" },
{ "Черный хлеб","Липтон" ,  "Б.Ю.Александров"}
};
double[,] price = new double[9, 3];
Random rnd = new Random();
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 3; j++)
    {
        price[i, j] = rnd.Next(50, 151);
    }
}
//вывод исходной информации
Console.WriteLine("Какую категорию напечатать? (0)Булочки, (1)Напитки, (2)Молочка");
string userInput = Console.ReadLine();
int cat = int.Parse(userInput);
for (int i = 0; i < 9; i++)
{
    Console.Write(names[i, cat] + "-");
    Console.WriteLine(price[i, cat] + ",");
}
//пора делать скидки!!!
Console.WriteLine("Укажите величину скидки");
string sale = Console.ReadLine();
double saleValue = double.Parse(sale);
Console.WriteLine("Укажите для какой категории применить скидку: (0)Булочки, (1)Напитки, (2)Молочка");
userInput = Console.ReadLine();
cat = int.Parse(userInput);
for (int i = 0; i < 9; i++)
{
    price[i, cat] = price[i,cat]*(1-saleValue/100);
    //15% ---- (1-15/100) = 1-0,15 = 0,85
}
for (int i = 0; i < 9; i++)
{
    Console.Write(names[i, cat] + "-");
    Console.WriteLine("{0:F},",price[i, cat]);
}
