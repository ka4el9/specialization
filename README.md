*Задание: Из имеющегося массива строк сформировать массив строк, длина которых меньше или равна 3 символа*

_(данная задача будет решаться на языке программирования C#)_

**Описание решения задачи**

Дан массив строк:
> string [] array = {"Sunday", "2", "rut" ,"Tuersday",
      "Wednesday", "Thirsday", "Friday", "34", "123", "qwe"};

1. Создаем новый массив строк, в котором будем хранить элементы массива длиной символов менее 3;
2. Напишем функцию void PrintArray(string [] arr) для возможности вывода элементов массива существующего и нового:
> void PrintArray(string [] arr){

Console.Write("[");

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine("]");

3. Напишем функцию void InitArray (string [] arr) для формирования нового массива элементами старого массива длиной символов менее 3:
> void InitArray (string [] arr) {

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
4. Функции написаны, после чего запускаем программу в терминале и видим результат:

> Дан массив строк: 
[Sunday,2,rut,Tuersday,Wednesday,Thirsday,Friday,34,123,qwe,]

> Из имеющегося массива срок, длина которых менее 3 символов создаем новый массив и выводим его на экран:
[2,rut,34,123,qwe,,,,,,]

