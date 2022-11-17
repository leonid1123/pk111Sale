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
do
{
    //вывод исходной информации
    int cat;
    do
    {
        Console.WriteLine("Какую категорию напечатать? (0)Булочки, (1)Напитки, (2)Молочка");
    } while (!(int.TryParse(Console.ReadLine(), out cat) & cat >= 0 & cat <= 2));

    for (int i = 0; i < 9; i++)
    {
        Console.Write(names[i, cat] + "-");
        Console.WriteLine(price[i, cat] + ",");
    }
    //пора делать скидки!!!
    string sale;
    double saleValue;
    bool uspeh = false;
    do
    {
        Console.WriteLine("Укажите величину скидки");
        sale = Console.ReadLine();
        uspeh = double.TryParse(sale, out saleValue);
    } while (!(uspeh & saleValue > 0 & saleValue < 100));

    do
    {
        Console.WriteLine("Укажите для какой категории применить скидку: (0)Булочки, (1)Напитки, (2)Молочка");
    } while (!(int.TryParse(Console.ReadLine(), out cat) & cat >= 0 & cat <= 2));

    for (int i = 0; i < 9; i++)
    {
        price[i, cat] = price[i, cat] * (1 - saleValue / 100);
        //15% ---- (1-15/100) = 1-0,15 = 0,85
    }
    for (int i = 0; i < 9; i++)
    {
        Console.Write(names[i, cat] + "-");
        Console.WriteLine("{0:F},", price[i, cat]);
    }
    Console.WriteLine("Еще раз? (Д)а/(Н)ет ");
} while (Console.ReadLine()=="Д");
