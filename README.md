# Итоговая работа по первому блоку

Задание на итоговую работу

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма
3. Снабдить репозиторий описанием в README.md
4. Написать программу на C#, решающую задачу
5. Использовать Git


**Основная задача**

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <= 3 символов. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Описание решения**

1. Ключевым в решении является метод *filterArray*. 
2. Поскольку пользоваться коллекциями нельзя и в C# при объявлении массива нужно указывать его длину, делаем первый обход исходного массива для подсчета количества строк с длиной <= 3.
3. Объявляем новый массив с длиной равной количеству найденных в п. 2 элементов и начальный индекс элементов в нём равный 0.
4. Делаем второй обход исходного массива, проверяем каждый элемент на условие "длина <= 3", элементы удовлетворяющие этому условию помещаем в новый массив и увеличиваем индекс текущего элемента в нем.
5. Возвращаем новый массив.

В основой программе реализован ввод количества элементов в исходном массиве, а также поэлементный ввод массива в цикле for.




