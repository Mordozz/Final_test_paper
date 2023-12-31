# Итоговая контрольная работа
---
__Задачи:__

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных)

__Задание:__
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

__Решение задачи:__
```
Начинаем с инициализации исходного массива строк

Затем инициализируем новый список строк. Мы используем список, потому что в начале мы не знаем, сколько строк из исходного массива удовлетворят условию (длина строки меньше или равна 3).

Далее мы проходим по каждой строке в исходном массиве с помощью цикла for.

Внутри цикла мы проверяем, удовлетворяет ли текущая строка условию (её длина меньше или равна 3). Если условие выполняется, мы добавляем эту строку в новый список.

После завершения цикла мы преобразуем список обратно в массив. Это делается для соответствия требованию задачи использовать исключительно массивы.

Наконец, мы выводим каждую строку из нового массива с помощью еще одного цикла for.
```
В результате мы получаем новый массив строк, каждая из которых имеет длину не более 3 символов.

__Блок схема:__

![Блок-схема](diagram(c).png)