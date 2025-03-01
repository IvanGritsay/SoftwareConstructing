# Принципи SOLID:
## 1. S – Single Responsibility Principle (Принцип єдиного обов’язку)

В моєму коді кожен клас виконує тільки одну відповідальність

__Приклад__:
_Клас [Food (рядки 9-19)](https://github.com/IvanGritsay/SoftwareConstructing/blob/lab-1/ClassLibrary/Food.cs#L9-L19) відповідає тільки за дані про їжу._

_Клас має єдину відповідальність – зберігати інформацію про їжу._ _Немає зайвих методів (наприклад, Eat() або Store())._

## 2.Open-Closed Principle (OCP) – Принцип відкритості/закритості

__Приклад:__
Клас [Animal (рядки 10-16)](https://github.com/IvanGritsay/SoftwareConstructing/blob/lab-1/ClassLibrary/Animal.cs#L10-L16) можна розширювати, не змінюючи його код.

_Можна додати нові види тварин (Lion, Elephant), просто розширивши Animal._ _Не потрібно змінювати сам клас Animal, тільки створюємо підкласи._

## 3.Liskov Substitution Principle (LSP) – Принцип підстановки Лісков

__Приклад:__
Клас [Lion (рядки 9-15)](https://github.com/IvanGritsay/SoftwareConstructing/blob/lab-1/ClassLibrary/Lion.cs#L9-L15) не порушує логіку Animal

_Lion можна підставити в код замість Animal, і все буде працювати._

## 4. Interface Segregation Principle (ISP) – Принцип розділення інтерфейсів

__Приклад:__
Інтерфейс [IEatable (рядки 9-12)](https://github.com/IvanGritsay/SoftwareConstructing/blob/lab-1/ClassLibrary/Interfaces/IEatable.cs#L9-L12) використовується тільки там, де потрібно.

_Якщо б був один інтерфейс IAnimal з методами Eat(), Work(), Sleep(), тоді Employee мав би Eat(), що нелогічно. Тепер IEatable використовують тільки тварини (Animal)_

## 5. Dependency Inversion Principle (DIP) – Принцип інверсії залежностей

__Приклад:__
Клас Inventory залежить від інтерфейсу [IEmployee (рядки 9-13)](https://github.com/IvanGritsay/SoftwareConstructing/blob/lab-1/ClassLibrary/Interfaces/IEmployee.cs#L9-L13), а не від конкретного Employee.

_Inventory працює з IEmployee, а не напряму з Employee. Це дозволяє замінити Employee на Volunteer без зміни Inventory._

# Принцип DRY (Don't Repeat Yourself) – Не повторюй себе

__Приклад__:
В моєму коді немає дублікатів логіки. Тобто в мене є абстрактний клас [Animal (рядки 10-16)](https://github.com/IvanGritsay/SoftwareConstructing/blob/lab-1/ClassLibrary/Animal.cs#L10-L16),
який дозволяє уникнути дублювання логіки в похідних класах тварин (Lion, Elephant)

# YAGNI (You Ain’t Gonna Need It) – Не додавати зайвий код

__Приклад__:
В моєму коді взагалі немає методів, які НЕ використовуються. Всі методи є важливими і корисними для виконання завдання.
До прикладу, всі методи написані в інтерфейсі
[IInventory (рядки 11-13)](https://github.com/IvanGritsay/SoftwareConstructing/blob/lab-1/ClassLibrary/Interfaces/IInventory.cs#L11-L13)
використовуються в класі [Program (рядки 29-33)](https://github.com/IvanGritsay/SoftwareConstructing/blob/lab-1/ZooProgram/Program.cs#L29-L33).

# Program to Interfaces, not Implementations

__Приклад__:
Я використовую інтерфейси ([IEatable](https://github.com/IvanGritsay/SoftwareConstructing/blob/lab-1/ClassLibrary/Interfaces/IEatable.cs),
[IEmployee](https://github.com/IvanGritsay/SoftwareConstructing/blob/lab-1/ClassLibrary/Interfaces/IEmployee.cs),
[IInventory](https://github.com/IvanGritsay/SoftwareConstructing/blob/lab-1/ClassLibrary/Interfaces/IInventory.cs)), а не жорстке наслідування. Наприклад:

Inventory працює з IEmployee, а не з конкретним класом Employee. Це означає, що можна легко замінити реалізацію Employee на іншу без змін в Inventory.
Animal реалізує IEatable, але метод Eat(Food food) реалізується в конкретних класах (Lion, Elephant).
Це дозволяє змінювати реалізації, не чіпаючи код, який їх використовує.
