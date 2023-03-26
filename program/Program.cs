/*
Задача
Из имеющегося массива строк сформировать массив строк, длина которых меньше или равна 3 символа
*/



string [] array = {"Sunday", "2", "rut" ,"Tuersday",
      "Wednesday", "Thirsday", "Friday", "34", "123", "qwe"};

int N = 10;
string [] new_array = new string [N];

void PrintArray(string [] arr) {
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + ",");
}
Console.WriteLine("]");
}


void InitArray (string [] arr) {

int j = 0;

    for (int i = 0; i < arr.Length; i++)
    {    
        if (arr[i].Length <= 3)
        {
            new_array[j] = array[i];
            j++;       
        }   
    }
}


Console.WriteLine("Дан массив строк: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Из имеющегося массива срок, длина которых менее 3 символов создаем новый массив и выводим его на экран:");
InitArray(array);
PrintArray(new_array);