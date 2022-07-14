Console.WriteLine("Task 13 ");

Console.Write("Put Number: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("ThirdDigit -> " + anyNumberText[2]);
}
else {
  Console.WriteLine(" NoThirdDigit-> ");
}
