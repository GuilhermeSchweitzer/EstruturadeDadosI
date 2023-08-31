int[,] biNumbers = new int[5,2];

int[,,] triNumbers = new int[5,4,3];

int[,] loadedBiNumbers = new int[,]
{
    
    {  9, 5, 8},
    { 10, -11, 4},
    {101, 45, -9}
};

for(int i = 0; i < loadedBiNumbers.GetLength(0); i++)
{
    for(int j = 0; j < loadedBiNumbers.GetLength(1); j++)
    {
        Console.Write( 
            $"[{loadedBiNumbers[i,j]}]"
        );
    }
    Console.WriteLine("");
}