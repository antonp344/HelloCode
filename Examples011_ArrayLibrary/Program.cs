
//   имя метода  аргумент и название
void FillArray(int[] collection)
{
    int length = collection.Length; //длина массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); //Обращение к аргументу коллектион и положить в него новое целове число из диапазона 1, 10
        index++;
    }    
}

void PrintArray(int[] col) // метод void который будет печатать массив
{
    int count = col.Length; // количество элементов
    int position = 0; // текущая позиция (не через индекс решили а через позишн)
    while (position < count) // пока текущая позиция меньше count
    {
        Console.WriteLine(col[position]); // будем выводить на экран значение текущего элемента
        position++;
        // void - вид метода который ничего не возвращает, соответственно не используем оператор return
    }
}

int indexOf(int[] collection, int find) // адаптация под предыдущую задачу
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создай новый массив, в котором будет 10 элементов (первоначально будут нули, поэтому след действие) 

FillArray(array);  //тестирование метода, в качестве аргумента передаем имя нашего массива, он ЗАПОЛНЯЕТ НАШ МАССИВ
PrintArray(array); // вызываем метод, который РАСПЕЧАТЫВАЕТ НАШ МАССИВ
Console.WriteLine(); // выводим пустую строчку чтобы быть уверенным в чтом, что не является частью вывода массива

int pos = indexOf(array, 45); // определиние переменную поз и в нее положим результат метода indexof.  
Console.WriteLine(pos); // после отработки метода покажем на экране pos
