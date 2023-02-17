// По номеру четверти диапазон значений (2 вариант)
Console.Write("Введите номер четверти: ");
int a = int.Parse(Console.ReadLine());
switch (a)
{
    case 1:
        {
            Console.WriteLine("x > 0; y > 0");
            break;
        }
    case 2:
        {
            Console.WriteLine("x < 0; y > 0");
            break;
        }
    case 3:
        {
            Console.WriteLine("x < 0; y < 0");
            break;
        }
    case 4:
        {
            Console.WriteLine("x > 0; y < 0");
            break;
        }
    default:
        {
            Console.WriteLine("Введены некорректные данные. Введите число от 1 до 4");
            return;
        }
}