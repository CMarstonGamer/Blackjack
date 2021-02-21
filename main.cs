using System;

class MainClass {
 private static int total;
private static int cardA;
private static int cardB;

public static string drawCardA(){
  var randCardA = new Random();
  int rIntA = randCardA.Next(2, 12);
  cardA = rIntA;

return "Your first card is " + cardA;
}
public static string drawCardB(){
  var randCardB = new Random();
  cardB = randCardB.Next(2,12);
  if (cardB + cardA > 21){
   if (cardB == 11){
     cardB = 1;
     total = cardA + cardB;
   } else if (cardA == 11){
     cardA = 1;
     total = cardA + cardB;
   } else {
     Console.WriteLine("Over 21, you lose!");
   }
 }
total = cardA + cardB;
Console.WriteLine("Your second card is " + cardB);
if (total == 21){
  Console.WriteLine("You won!");
}
  return "Your total after adding your first and second cards is = " + total;
}
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  Console.WriteLine(drawCardA());
  Console.WriteLine(drawCardB());
  }
}