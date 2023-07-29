int m=3, n=4;
double[,] array =new double[m,n];
Random rand = new Random();
for (int i=0; i< m; i++)
{
for (int j = 0; j < n; j++)
{
    array[i,j] = (double)rand.Next(-100,100)/10;
    Console.Write(array[i,j] + "  ");
}
Console.WriteLine();
}
