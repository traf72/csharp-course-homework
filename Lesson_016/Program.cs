﻿/***********************************************************************************************************************************
    1. Вам дана строка "A journey of a thousand miles begins with a single step." Выполните задания ниже.
       Все манипуляции проводите, не изменяя исходную строку, то есть, не переприсваивая исходную переменную.
         1.1.  Выведите в консоль её длину.
         1.2.  Выведите в консоль первый символ.
         1.3.  Выведите в консоль 16-й символ.
         1.4.  Выведите в консоль последний символ (несколькими способами).
         1.5.  Выведите в консоль пятый символ с конца (несколькими способами).
         1.6.  Найдите индекс первого вхождения слова "begins" (существует специальный метод).
               Выведите его в консоль в виде "The word "begins" found at index 30".
         1.7.  Получитие подстроку "begins with a single step." и выведите её в консоль.
               Чтобы не высчитывать стартовый индекс вручную, используйте индекс, полученный на предыдущем шаге.
         1.8.  Получитие подстроку "thousand miles" и выведите её в консоль.
         1.9.  Удалите подстроку "a thousand miles begins with", чтобы осталось только "A journey of a single step.".
               Выведите в консоль получившуюся строку "A journey of a single step.".
         1.10. В последней получившейся строке "A journey of a single step." замените "a single step" на "multiple steps".
               В итоге должно получиться "A journey of multiple steps."
         1.11. В последнюю строку вставьте слово "wonderful". В итоге должно получиться "A wonderful journey of multiple steps.".
         1.12. Проверьте, что строка начинается с подстроки "A wonderful journey".
         1.13. Отрежьте точку в конце, то есть, должно остаться только "A wonderful journey of multiple steps".
               Приведите несколько вариантов того, как это можно сделать.
         1.14. Проверьте, что строка оканчивается на подстроку "multiple steps".
         1.15. Разбейте последнюю получившуюся строку на отдельные слова.
               Должен получиться массив ["A", "wonderful", "journey", "of", "multiple", "steps"].
         1.16. Склейте обратно все слова в одну строку, но уже с разделителем "; ".
               Должна получиться строка "A; wonderful; journey; of; multiple; steps".
         1.17. Определите, содержит ли строка из пункта выше подстроку "wonderful journey".
***********************************************************************************************************************************/

string phrase = "A journey of a thousand miles begins with a single step.";


/********************************************************************************************************************************************
    2. Создайте из строки из первого задания объект "StringBuilder". Все манипуляции из заданий ниже должны выполняться именно
       с изначально созданным объектом "StringBuilder". Он не должен пересоздаваться или приводиться к строке методом "ToString".
         2.1.  Выведите в консоль строку, которую он содержит.
         2.2.  Выведите в консоль длину строки, которую он содержит.
         2.3.  Выведите в консоль 25-й символ.
         2.4.  Выведите в консоль второй символ с конца (несколькими способами).
         2.5.  Измените последний символ на '!'. Выведите получившуюся строку в консоль.
         2.6.  Обрежьте строку до первых 29 символов. Предложите несколько вариантов это сделать.
               Выведите полученную строку в консоль.
         2.7.  Увеличьте строку обратно до 56 символов (только её длину). Выведите её в консоль, а также её длину.
               Почему длина равна 56, а в консоли мы всё также видим только 29 символов?
         2.8.  Восстановите исходную строку, не пересоздавая объект "StringBuilder". Предложите несколько вариантов.
         2.9.  Превратите строку "A journey of a thousand miles begins with a single step." в строку
               "A-journey-of-a-thousand-miles-begins-with-a-single-step.".
         2.10. Очистите "StringBuilder". Добавьте слова "One", "Two" и "Three", разделённые запятой. Не компонуйте необходимую
               строку вручную, чтобы добавить её целиком. Вам нужно добавить три слова через разделитель используя методы "StringBuilder".
               В результате должно получиться "One,Two,Three". Предложите несколько вариантов это сделать.
********************************************************************************************************************************************/


/**********************************************************************************************
    3. Для строки ниже я пытаюсь получить последний символ '!', но почему-то получаю ошибку.
       В чём причина? Исправьте код.
**********************************************************************************************/

/*
    Индекс последнего символа определён неверно. Индексирование начинается с нуля, а значит индекс последнего символа будет не 10, а 9.
    Но лучше использовать специальный синтаксис указания индекса с конца.
*/

string greeting = "Hi, there!";
Console.WriteLine(greeting[10]);


/*********************************************************************************************************
    4. Вам дана строка. Выполните задания ниже. Все манипуляции проводите, не изменяя исходную строку.
         4.1. Обрежьте пробельные символы только в начале и выведите в консоль.
         4.2. Обрежьте пробельные символы только в конце и выведите в консоль.
         4.3. Обрежьте пробельные символы с обоих сторон и выведите в консоль.
         4.4. Обрежьте с обоих сторон не только пробельные символы, но и символы '$' и '*'.
*********************************************************************************************************/

string str = "\t  **$$ Stay curious, stay inspired!! $$**  \n";


/*******************************************************************************************************************
    5. Я разбиваю входящую строку на подстроки по разделителю ";". Далее я вывожу полученные части в консоль.
       Но в консоли для некоторых строк я почему-то вижу ведущий пробел, хотя он мне не нужен.
       Предложите варианты, как можно избавиться от данного ведущего пробела, если:
         5.1. Формат входящей строки гарантирует, что разделитель всегда, помимо точки с запятой,
              будет содержать ещё и пробел, то есть, возможен только единственный вариант "; ".
         5.2. Формат входящей строки гарантирует, что разделитель всегда будет содержать ";", но он может
              быть как с пробелом, так и без, то есть, возможны варианты ";" и "; ". Например, строка может
              выглядеть как "One; Two;Three".
         5.3. Аналогично пункту 5.2, но также ещё могут встречаться пустые вхождения, которые вам нужно отсекать.
              То есть, входящая строка может выглядеть как "One; Two;Three; ;Four;;Five;Six".

       Для примера входящая строка состоит только из трёх частей, но давайте предположим, что в реальности она
       может содержать сотни частей.
*******************************************************************************************************************/

string inputString = "One; Two; Three";
string[] parts = inputString.Split(';');
DisplayStringParts(parts);

// Вспомогательный метод для вывода частей строки в консоль. Его трогать не нужно.
static void DisplayStringParts(string[] parts)
{
    foreach (string part in parts)
    {
        Console.WriteLine($"\"{part}\"");
    }
}


/***********************************************************************************************************************************
    6. Проверка строк на пустоту.
         6.1. Объявите пустую строку несколькими способами.
         6.2. Объявите строковую переменную, содержащую значение "null".
         6.3. Объявите строковую переменную, содержащую только пробельные символы различного характера.
         6.4. Проверьте все выше созданные строки на пустую строку.
         6.5. Проверьте все выше созданные строки на пустую строку или "null".
         6.6. Проверьте все выше созданные строки на пустую строку, "null" или строку, состоящую только из пробельных символов.
***********************************************************************************************************************************/


/***********************************************************************************************************************************
    7. Вы написали функцию, которая проверяет, содержит ли переданная строка символ '.'. Вы пытаетесь передать в неё различные
       данные, включая строки, числа, символы и даже объект "StringBuilder". Но некоторые строки кода не компилируются.
       Раскомментируйте их и предложите вариант исправления.
***********************************************************************************************************************************/

Console.WriteLine(ContainsDot("I love .NET"));
//Console.WriteLine(ContainsDot(new StringBuilder("Hi there!")));
//Console.WriteLine(ContainsDot(5.78));
//Console.WriteLine(ContainsDot('.'));


static bool ContainsDot(string str)
{
    return str.Contains('.', StringComparison.Ordinal);
}


/*******************************************************************************************************
    8. Выведите число PI с 7-ю знаками после запятой в текущей культуре и в культуре Британии (en-GB).
*******************************************************************************************************/


/*********************************************************************************************************************
    9. Создайте дату 2024-12-07 и выведите её в текущей культуре, культуре США (en-US) и культуре Китая (zh-CN).
*********************************************************************************************************************/
