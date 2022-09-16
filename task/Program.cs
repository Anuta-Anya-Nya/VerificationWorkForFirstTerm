string[] array = {"mama", "papa", "ann", "^-)"};
int count=0;
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
    if(array[i].Length<=3)
    {
        count++;
    }
}
string[] newArray = new string[count];
count=0;
for (int i = 0; i < array.Length; i++)
{    
    if(array[i].Length<=3)
    {
        newArray[count]=array[i];
        count++;        
    }    
}
Console.WriteLine();
for (int i = 0; i < newArray.Length; i++)
{
    Console.WriteLine(newArray[i]);
}