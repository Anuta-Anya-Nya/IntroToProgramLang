// Сщздаем двумерный массив - рисунок и закрашиваем его

// void PrintArr(int[,] collect)
// {
//     for (int i = 0; i < collect.GetLength(0); i++) //перебор строк
//     {
//         for (int j = 0; j < collect.GetLength(1); j++) //Перебор колонок
//         {
//             Console.Write(collect[i, j]);
//         }
//         Console.WriteLine("");
//     }
// }

void PrintArr(int[,] collect)
{
    for (int i = 0; i < collect.GetLength(0); i++) //перебор строк
    {
        for (int j = 0; j < collect.GetLength(1); j++) //Перебор колонок
        {
            if (collect[i, j] == 0)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write("+");
            }
        }
        Console.WriteLine("");
    }
}
// int[,] pic2 = new int[,]
// {
//     {1, 0, 0, 1, 0},
//     {0, 1, 1, 0, 0},
//     {0, 1, 1, 0, 0},
// };

int[,] pic = new int[10, 20];
pic[0, 9] = 1;
pic[0, 10] = 1;
pic[0, 11] = 1;
pic[1, 8] = 1;
pic[1, 12] = 1;
pic[2, 7] = 1;
pic[2, 13] = 1;
pic[3, 6] = 1;
pic[3, 14] = 1;
pic[4, 5] = 1;
pic[4, 15] = 1;
pic[5, 4] = 1;
pic[5, 16] = 1;
pic[6, 3] = 1;
pic[6, 17] = 1;
pic[7, 2] = 1;
pic[7, 18] = 1;
pic[8, 1] = 1;
pic[8, 19] = 1;
for (int i = 0; i < pic.GetLength(1); i++)
{
    pic[9, i] = 1;
}
void FillImg(int row, int coll)
{
    if (pic[row, coll] == 0)
    {
        pic[row, coll] = 1;
        FillImg(row - 1, coll);
        FillImg(row, coll - 1);
        FillImg(row + 1, coll);
        FillImg(row, coll + 1);
    }
}

PrintArr(pic);
FillImg(7, 7);
PrintArr(pic);