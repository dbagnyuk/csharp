Лабораторна №5

FaradayTheCat and AdaTheCat

Напишіть публічний клас Cat, що буде описувати кота. Клас Cat повинен містити виключно вказані члени. Порядок членів у класі не є важливим. Назви членів важливі. Елементи класу Cat:
1. Автозгенерований параметр тільки для зчитування Name типу string.
2. Автозгенерований параметр тільки для зчитування Gender типу Lab5.Gender (enum (дивись нижче)).
3. Приватне поле _energy типу double. Параметр Energy має записувати і зчитувати значення з цього поля.
4. Публічне статичне readonly поле MaxEnergy типу double зі значенням 20.
5. Публічне статичне readonly поле MinEnergy типу double зі значенням 0.
6. Публічне статичне readonly поле SleepEnergyGain типу double зі значенням 10.
7. Публічне статичне readonly поле JumpEnergyDrain типу double зі значенням 0.5.
8. Параметр для зчитування для всіх(public) та запису(private) Energy типу double. Якщо значення, що записується, менше за MinEnergy, то необхідно кидати помилку(exception) з повідомленням "Not enough energy to jump". Якщо значення більше за MaxEnergy, то необхідно записувати значення MaxEnergy.
9. Конструктор, який приймає 2 аргументи name та gender типів string та Lab5.Gender відповідно та записує ці значення в параметри Name та Gender відповідно. Також конструктор повинен записати в параметр Energy значення MaxEnergy.
10. Метод Jump() без параметрів типу void, який зменшує Energy на JumpEnergyDrain.
11. Метод Sleep() без параметрів типу void, який збільшує Energy на SleepEnergyGain.


Enum Lab5.Gender має містити два перелічення Male та Female.


Пояснення до завдання

Наш кіт має наперед задані стать та ім'я, які ми не можемо змінити після його створення. На момент створення він має максимальну кількість енергії аби стрибати. З кожним стрибком кількість його енергії повинна зменшуватись, але не менше ніж мінімальна кількість енергії. Для того, щоб відновити енергію коту( як і всім ) необхідно поспати. На цьому простому прикладі легко побачити як може бути зручно використовувати об'єкти, адже кожен окремий об'єкт має свій незалежний від інших стан.
