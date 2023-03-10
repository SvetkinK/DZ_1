int n;
//n = 5;
n = 8;
int[] array = new int[n];
int index;

for (index = 0; index <= n - 1; index++)
{
  array[index] = index + 1;
}
int even;

for (index = 0; index <= n - 1; index++)
{
  if (array[index] % 2 == 0)
  {
    even = array[index];
    Console.Write(even);
    Console.Write(" ");
  }
}
