﻿Console.Clear();
Console.Write("Введите номнр дня недели недели: ");
int numberDayOfWeek=int.Parse(Console.ReadLine());
//
if(numberDayOfWeek < 1 || numberDayOfWeek > 7)// && ==    !    '5'    <    '17'
{
    Console.WriteLine("Введен неверный номер");
    return;
}
if(numberDayOfWeek==1){
    Console.WriteLine("Понедельник");
}if(numberDayOfWeek==2){
    Console.WriteLine("Вторник");
}if(numberDayOfWeek==3){
    Console.WriteLine("Cреда");
}if(numberDayOfWeek==4){
    Console.WriteLine("Четверг");
}if(numberDayOfWeek==5){
    Console.WriteLine("Пятница");
}if(numberDayOfWeek==6){
    Console.WriteLine("Суббота");
}if(numberDayOfWeek==7)
{
    Console.WriteLine("Воскресение");
}    
