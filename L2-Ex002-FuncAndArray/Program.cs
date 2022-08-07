int[] array = {1, 3, 5, 6, 8, 4, 3, 2};
int find = 2;

int count = array.Length;
int index = 0;
while (index < count)
    {
        if (array[index]==find) 
        {
            Console.WriteLine(index);
            break;
        }
        index++;
    }


