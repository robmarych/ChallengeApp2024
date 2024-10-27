

int number = 001122334455;
string numberInStriong = number.ToString();
char[] letteres = numberInStriong.ToCharArray();
int[] counter = new int[9];
for (int i = 0; i < counter.Length; i++)
{
    counter[i] = 0;
}

foreach (char letter in letteres)
{
    {
        for (int i = 0; i < counter.Length; i++)
        {
            if (Char.ConvertFromUtf32(letter) == i.ToString())
            {
                counter[i]++;
            }
        }
    }
}

Console.WriteLine("Wynika dla liczy: " + number);
for (int i = 0; i < counter.Length; i++)
{
    Console.WriteLine(i + " => " + counter[i]);
}




