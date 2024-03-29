Лабораторна №4

Сортування злиттям

Напишіть програму, що відсортує заданий масив у порядку зростання за допомогою алгоритму сортування злиттям.
В попередній лабораторній роботі ми розглянули алгоритм сортування вибором. Може виникнути справедливе питання : "Навіщо мені інших алгоритм, якщо я вже знаю один?". Вся справа в тому, що алгоритм сортування вибором НЕ є оптимальним і працює досить повільно, коли кількість чисел починає рости. Давайте спробуємо зрозуміти чому.

Давайте розглянемо такий приклад (тут розглядаємо випадок сортування у порядку зростання):
6, 5, 4, 3, 2
На першому кроці ми знайшли найменше число – 2 за 4 порівняння.
На другому кроці ми знайшли найменше число – 3 за 3 порівняння.
На третьому кроці ми знайшли найменше число – 4 за 2 порівняння.
На четвертому кроці ми знайшли найменше число – 5 за 1 порівняння.
На п’ятому кроці ми знайшли найменше число – 6
Як ми бачимо кількість порівнянь, що потрібно здійснити, щоб відсортувати масив алгоритмом вибору = 1 + 2 + 3 + 4 = 1 + 2 + … n-2 = ((1 + n-1)/2)*(n-1) = (n^2 - n)/2, тобто кількість порівнянь має квадратичну залежність від кількості елементів. Для опису швидкодії алгоритмів зазвичай використовують асимптотичну нотацію великого О(нотація Ландау). Ми можемо описати алгоритмічну складність сортування вибором як O(n^2).
Давайте підставимо в нашу асимптотичну оцінку, наприклад, 10 елементів:
10^2 =(приблизно) 100 порівнянь.
І 100 елементів:
100^2 =(приблизно) 10000 порівнянь.
Вже навіть на 100 елементах кількість порівнянь виходить достатньо великою. (Потрібно зазначити, що насправді кількість порівнянь для сортування вибором 100 елементів в нашому випадку буде дорівнювати 4851, але нас цікавить лише порядок зростання, тому оцінка в 10000 порівнянь є прийнятною.

На щастя існують інші алгоритми сортування, які мають кращу алгоритмічну складність. Наприклад, сортування злиттям має алгоритмічну складність O(nlog(n)) (для 100 елементів приблизно 664 порівнянь. Знову ж таки точна кількість порівнянь може бути іншою, але нас цікавить лише порядок зростання).

Сортування злиттям базується на ідеї, що ,для того щоб отримати відсортований масив, можна розбити його на два підмасиви, відсортувати їх, та злити два відсортовані масиви в один. Саму роботу алгоритму можна описати в такі два кроки:
1. Поділити масив на дві рівні частини(якщо кількість елементів непарна, то на дві майже рівні частини) і застосувати сортування злиттям до кожної з них.
2. Злити два відсортовані масиви з попереднього кроку у один таким чином, щоб результат теж був відсортований.
Необхідно зазначити, що для того, щоб сортування злиттям мало алгоритмічну складність O(nlog(n)), необхідно щоб саме злиття(другий крок) мало алгоритмічну складність O(n).
Приклад:



Уявімо, що маємо такі два підмасиви 1 5 8 | 3 7 10, кожен з них вже є відсортованим. Давайте спробуємо злити ці два підмасиви.
Беремо перший елемент з лівого підмасиву : 1
Порівнюємо його з першим елементом правого підмасиву: 3
1 < 3, тому записуємо в результуючий масив 1.
Беремо другий елемент з лівого підмасиву : 5
Порівнюємо його з першим елементом правого підмасиву: 3
5 > 3, тому записуємо в результуючий масив 3.
Беремо другий елемент з правого підмасиву : 7
Порівнюємо його з другим елементом лівого підмасиву: 5
5 < 7, тому записуємо в результуючий масив 5.
Беремо третій елемент з лівого підмасиву : 8
Порівнюємо його з другим елементом правого підмасиву: 7
8 > 7, тому записуємо в результуючий масив 7.
Беремо третій елемент з правого підмасиву : 10
Порівнюємо його з першим елементом лівого підмасиву: 8
8 < 10, тому записуємо в результуючий масив 8.
Записуємо в результуючий масив 10.
Завдання: Відсортуйте масив алгоритмом сортування злиттям (у порядку зростання). В першому рядку виведіть всі елементи відсортованого масиву. (Використовуйте такий запис для виведення Console.Write($"{a[i]} ");)
