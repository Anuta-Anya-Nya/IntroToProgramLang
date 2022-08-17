// Дан текст. Надо заменить пробелы тире, о на О, а на |
string TextConvert(string text, char oldValue, char newValue)
{
    string newText = String.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldValue)
        {
            newText = newText + newValue;
        }
        else
        {
            newText = newText + text[i];
        }
    }
    return newText;
}

string myText = "Апрп пр опаровро аатата";
string convText = TextConvert(myText, ' ', '-');// чары указываются в одинарных кавычках!!!
Console.WriteLine(convText);
convText = TextConvert(convText, 'о', 'О');
Console.WriteLine(convText);
convText = TextConvert(convText, 'а', '|');
Console.WriteLine(convText);
