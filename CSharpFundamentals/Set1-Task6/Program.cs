Random random = new Random(); 
int[] player1Coin = new int[5] { random.Next(1, 10), random.Next(1, 10), random.Next(1, 10), random.Next(1, 10), random.Next(1, 10) };
int[] player2Coin = new int[5] { random.Next(1, 10), random.Next(1, 10), random.Next(1, 10) ,random.Next(1, 10), random.Next(1, 10) };
double player1TotalScore = 0;
double player2TotalScore = 0;

for (int i = 0; i < player1Coin.Length;)
    for (int j = 0; j < player2Coin.Length;)
    {
        if (player1Coin[i] > player2Coin[j])
        {
            player1TotalScore += 1;
            Console.WriteLine("\n player one coin is : = " + player1Coin[i]);
            Console.WriteLine(" player two coin is : = " + player2Coin[i]);
            Console.WriteLine(" player one is the winner.");
            Console.WriteLine("===========================");
        }
        else if (player1Coin[i] < player2Coin[j])
        {
            player2TotalScore += 1;
            Console.WriteLine("\n player one coin is : = " + player1Coin[i]);
            Console.WriteLine(" player two coin is : = " + player2Coin[i]);
            Console.WriteLine(" player two is the winner.");
            Console.WriteLine("===========================");
        }
        else
        {
            player1TotalScore += 0.5;
            player2TotalScore += 0.5;
            Console.WriteLine("\n player one coin is : = " + player1Coin[i]);
            Console.WriteLine(" player two coin is : = " + player2Coin[i]);
            Console.WriteLine(" Both player  are the winners.");
            Console.WriteLine("===========================");
        }
        i++;
        j++;
    }

if (player1TotalScore > player2TotalScore)
{
    Console.WriteLine("\t\n.*******The winner of this game is Player1 with Score of := ." + player1TotalScore + ".*******");
}
else if (player1TotalScore < player2TotalScore)
{
    Console.WriteLine("\t\n*******The winner of this game is Player2 with Score of := ." + player2TotalScore + ".*******");
}
else
{
    Console.WriteLine("\t\n.*******The game is tie *******");
}
Console.ReadLine();