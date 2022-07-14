Console.WriteLine("Задача 15 ");

Console.Write("Put dayNumber: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(FreeDay) -> Yes");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Not WeekDay");
  }
  else Console.WriteLine("( Not FreeDay) -> No");
}

CheckingTheDayOfTheWeek(dayNumber);
