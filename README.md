# Control_work
//Разбиваем решение на три метода. Один основной и два вспомагательных

//Основной метод принимает на вход созданный массив и его длину, а выводит
//массив, где каждый элемент не превышает 3 символа.
//Он использует количество элементов массива, содержащих 3 символа и меньше
//для записи длины строки будущего массива. 
//Пробегаем все элементы созданного массива, в том случе, если элемент
//содержит 3 символа и меньше, записывем этот элемент в новый массив.
//При выполнении этого условия, увеличиваем специальный счётчик для нового
//масива(j) на 1

//Первый вспомагательный метод принимает на вход длину создаваемого массива.
//Выводит же массив из элементов введенных с клавиатуры. 
//В конце дописывается ещё один элемент массива, который является счетчиком.
//Он представляет собой количество элементов введенных с клавиатуры 
// и содержащих 3 и менее символов.
// Также существует резерная команда отключения(stop), на случай, 
// если по ошибке задано слишком много элементов массива.

//Последний вспомагательный метод принимает на вход массив и выводит его на печать. 
