﻿/*********************************************************************************************************************
    1. В заданиях ниже вам предоставлены какие-то данные, и вам нужно объявить и инициализировать переменную
       в соответствии с описанными условиями. Именуйте вашу переменную в соответствии с её смысловым значением.
*********************************************************************************************************************/

// 1.1. Определите, находится ли данный вам год в диапазоне от 1900 включительно до 2000 не включительно.
int year = 1927;


// 1.2. Определите, имеет ли пользователь право управлять автомобилем. Пользователь имеет право управлять автомобилем,
//      если ему 18 или более лет, и он имеет водительское удостоверение.
int age = 19;
bool hasDrivingLicense = true;


// 1.3. Определите, поступил ли абитуриент в ВУЗ. Абитуриент считается поступившим,
//      если его балл по ЕГЭ больше 80 или он занимал призовые места.
int egeScore = 83;
bool hadOlympiadPrizes = false;


// 1.4. Определите, находится ли число вне диапазона от 10 до 20 включительно.
int number = 20;


// 1.5. Определите, кратно ли число 3-м или 7-и.
number = 129772;


// 1.6. Определите, что данный вам день недели является будним днём, то есть, не субботой и не воскресеньем.
//      Дни недели нумеруются от 1 до 7, то есть:
//        Понедельник - 1
//        Вторник - 2
//        ...
//        Воскресенье - 7
int dayOfWeek = 5;


// 1.7. Определите, может ли пользователь участвовать в предстоящем событии. Пользователь может участвовать,
//      если его возраст больше или равен 18 и меньше или равен 65, он является членом клуба и не имеет никаких
//      задолженностей.
age = 25;
bool isClubMember = true;
bool hasNoDebts = true;


// 1.8. Определите, имеет ли сотрудник право на повышение. Сотрудник имеет право на повышение, если он проработал
//      3 года и более, его коэффициент производительности более 85, и он не имеет дисциплинарных нарушений.
int yearsWorked = 6;
int performanceScore = 87;
bool hasDisciplinaryActions = false;


// 1.9. Определите, имеет ли пользователь право на скидку в гимнастический зал. Пользователь имеет право на скидку,
//      если он студент или его возраст равен или больше 60, а также он имеет членскую карту зала. 
bool isStudent = false;
age = 65;
bool hasGymMembershipCard = true;


// 1.10. Определите, имеет ли пользователь доступ к ограниченной зоне. Чтобы иметь такой доступ пользователь
//      должен быть админом или обычным пользователем со специальными разрешениями. В любом случае пользователь
//      должен иметь включенной многофакторную аутентификацию или заходить с доверенного устройства.
bool isAdmin = false;
bool hasSpecialPermissions = true;
bool isMfaEnabled = false;
bool isTrustedDevice = true;


// 1.11. Определите, имеет ли сотрудник право на специальную льготную программу. Сотрудник имеет право на льготную программу, если:
//        - сотрудник имеет полный рабочий день и проработал в компании 5 лет или более
//        - сотрудник имеет неполный рабочий день, но имеет превосходный рейтинг производительности
//        - подрядчик со стажем работы не менее 7 лет и не имеющий негативных отзывов
bool isFullTimeEmployee = true;
bool isPartTimeEmployee = false;
bool isContractor = false;
int yearsOfWork = 12;
bool hasExcellentPerformance = false;
bool hasNegativeFeedback = false;


// 1.12. Определите, имеет ли пользователь доступ к закрытому событию. Пользователь имеет такой доступ, если у него VIP-статус
//       или он имеет специальное приглашение, но не то и другое одновременно.

bool isVip = false;
bool hasSpecialInvitation = true;


/***********************************************************************************************************
    2. Вы производите тестирование функционала. У вас есть два метода Check1() и Check2(). Методы
       тестируют какую-то логику и возвращают результаты проверок. Если успешно, то "true", а если
       нет, то "false". Также методы внутри себя логгируют результаты проверок. Для того чтобы функционал
       считался корректным, обе проверки должны пройти одновременно, то есть, оба метода должны вернуть
       "true". Вы делаете это следующим образом (см. код ниже), но через какое-то время замечаете,
       что если первый метод вернул "false", то второй метод ничего не логгирует. Вы же бы хотели, чтобы
       оба метода всегда логгировали свои результаты, независимо от успешности или неуспешности проверок.
       В чём причина и как это можно исправить?
***********************************************************************************************************/

bool isFunctionalityCorrect = Check1() && Check2();
Console.WriteLine($"Functionality is correct: {isFunctionalityCorrect}");

bool Check1()
{
    bool checkResult = false;                            // Какая-то логика проверки функционала (в нашем случае просто присваиваем "false").
    Console.WriteLine($"Check1 result: {checkResult}");  // Логгирование результатов проверки. В нашем случае просто логгируем результат в консоль.
    return checkResult;                                  // Возврат результатов проверки (false - при некорректной работе, true - при корректной).
}

bool Check2()
{
    bool checkResult = true;                             // Какая-то логика проверки функционала (в нашем случае просто присваиваем "true").
    Console.WriteLine($"Check2 result: {checkResult}");  // Логгирование результатов проверки. В нашем случае просто логгируем результат в консоль.
    return checkResult;                                  // Возврат результатов проверки (false - при некорректной работе, true - при корректной).
}


/***********************************************************************************************************
    3. Почему не существует оператора XOR, который использует короткую схему вычисления (short-circuit)?
***********************************************************************************************************/


/***************************************************************************************
    4. В выражениях ниже ожидается один результат, но в реальности получается другой.
       В чём причина? Исправьте код.
***************************************************************************************/

/*
    4.1. Вы пытаетесь ограничить доступ к определённому ресурсу. Доступ к нему должны иметь только админы
         или обычные пользователи, но имеющие специальные права. Также доступ должен быть ограничен, если
         данный ресурс находится на техническом обслуживании. Вы объявили переменную "isAccessAllowed",
         которой присвоили соответствующее выражение. Но почему-то ограничение доступа работает некорректно.
         Например, в случае ниже доступ должен быть ограничен, потому что система находится на техническом
         обслуживании, но переменная почему-то содержит "true".
         В чём причина и как это можно исправить?
*/

isAdmin = true;
bool hasSpecialAccess = false;
bool underMaintenance = true;

bool isAccessAllowed = isAdmin || hasSpecialAccess && !underMaintenance;
Console.WriteLine(isAccessAllowed);


/*
    4.2. Магазин предлагает скидку, если вы купили более 3-х товаров или потратили более 5 тысяч, но только если
         это не распродажа. Вы объявили переменную "isDiscountApplied", которой присвоили соответствующее выражение.
         Но почему-то скидка применяется не всегда некорректно. Например, в случае ниже скидка примениться не должна,
         так как идёт распродажа, но она почему-то применяется.
         В чём причина и как это можно исправить?
*/

int itemsPurchased = 2;
decimal amountSpent = 6000;
bool isSale = true;

bool isDiscountApplied = !isSale && itemsPurchased > 3 || amountSpent > 5000;
Console.WriteLine(isDiscountApplied);


/*
    4.3. Система должна отсылать уведомление в случае ошибки или в случае предупреждения, но только если его уровень
         критичности больше 5. Вы объявили переменную "shouldSendNotification", которой присвоили соответствующее выражение.
         Но почему-то уведомления отсылаются не всегда корректно. Например, в случае ниже уведомление должно отсылаться,
         так как произошла ошибка, но переменная почему-то имеет значение "false".
         В чём причина и как это можно исправить?
*/

bool isError = true;
bool isWarning = false;
int warningLevel = 0;

bool shouldSendNotification = isWarning && warningLevel > 5 | isError;
Console.WriteLine(shouldSendNotification);
