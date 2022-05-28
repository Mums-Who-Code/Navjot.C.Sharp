Random random= new Random();
int[] player = new int[5];
player[0] = random.Next(1, 5);
player[1] = random.Next(1, 5);
player[2] = random.Next(1, 5);
player[3] = random.Next(1, 5);
player[4] = random.Next(1, 5);


for (int i = 0; i< player.Length;)

{
    player[i] = random.Next(1, 5);
    //Console.WriteLine(player[i]);
    {
        for (int j = i ; j < player.Length;)
        {
            if (j == i)
            {
                Console.WriteLine("you move to the next level" + player[i]);
            }
            else
            {
                Console.WriteLine("you lose" + player[i]);
            }
            j++;
            i++;
            
        }
        //j++;
        //i++;
    }
   
}

