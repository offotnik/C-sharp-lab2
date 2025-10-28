using System;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ТЕСТИРОВАНИЕ КЛАССОВ ЛАБОРАТОРНОЙ РАБОТЫ 2 ===\n");

            TestHumanWithName();
            TestNames();
            TestPoint();
            TestPolyline();
            TestUPDPolyline();
            TestSecondUPDPolyline();
            TestHumanWithFather();

            Console.WriteLine("\n=== ВСЕ ТЕСТЫ ЗАВЕРШЕНЫ ===");
        }

        static void TestHumanWithName()
        {
            Console.WriteLine("1. ТЕСТИРОВАНИЕ КЛАССА Human_with_Name:");
            Console.WriteLine("=========================================");

            // Тест 1: Полное имя
            var human1 = new Human_with_Name(180, "Иван", "Иванов", "Иванович");
            Console.WriteLine($"Тест 1 (полное имя): {human1}");

            // Тест 2: Без имени
            var human2 = new Human_with_Name(175, "", "Петров", "Петрович");
            Console.WriteLine($"Тест 2 (без имени): {human2}");

            // Тест 3: Без фамилии
            var human3 = new Human_with_Name(170, "Сергей", "", "Сергеевич");
            Console.WriteLine($"Тест 3 (без фамилии): {human3}");

            // Тест 4: Без отчества
            var human4 = new Human_with_Name(185, "Алексей", "Алексеев", "");
            Console.WriteLine($"Тест 4 (без отчества): {human4}");

            // Тест 5: Только имя
            var human5 = new Human_with_Name(160, "Мария", "", "");
            Console.WriteLine($"Тест 5 (только имя): {human5}");

            // Тест 6: Пустые данные
            var human6 = new Human_with_Name(150, "", "", "");
            Console.WriteLine($"Тест 6 (пустые данные): {human6}");

            Console.WriteLine();
        }

        static void TestNames()
        {
            Console.WriteLine("2. ТЕСТИРОВАНИЕ КЛАССА Names:");
            Console.WriteLine("=============================");

            // Тест 1: Полное имя
            var name1 = new Names("Анна", "Сидорова", "Владимировна");
            Console.WriteLine($"Тест 1 (полное имя): {name1}");

            // Тест 2: Без имени
            var name2 = new Names("", "Кузнецова", "Дмитриевна");
            Console.WriteLine($"Тест 2 (без имени): {name2}");

            // Тест 3: Без фамилии
            var name3 = new Names("Ольга", "", "Андреевна");
            Console.WriteLine($"Тест 3 (без фамилии): {name3}");

            // Тест 4: Только отчество
            var name4 = new Names("", "", "Павловна");
            Console.WriteLine($"Тест 4 (только отчество): {name4}");

            Console.WriteLine();
        }

        static void TestPoint()
        {
            Console.WriteLine("3. ТЕСТИРОВАНИЕ КЛАССА Point:");
            Console.WriteLine("==============================");

            // Тест 1: Обычная точка
            var point1 = new Point(3.5, 4.2);
            Console.WriteLine($"Тест 1 (обычная точка): {point1}");

            // Тест 2: Отрицательные координаты
            var point2 = new Point(-2.1, 5.7);
            Console.WriteLine($"Тест 2 (отрицательные координаты): {point2}");

            // Тест 3: Нулевые координаты
            var point3 = new Point(0, 0);
            Console.WriteLine($"Тест 3 (нулевые координаты): {point3}");

            Console.WriteLine();
        }

        static void TestPolyline()
        {
            Console.WriteLine("4. ТЕСТИРОВАНИЕ КЛАССА Polyline:");
            Console.WriteLine("================================");

            // Создаем точки
            var points = new List<Point>
            {
                new Point(0, 0),
                new Point(3, 4),
                new Point(6, 8),
                new Point(10, 12)
            };

            // Тест 1: Создание ломаной из списка точек
            var polyline1 = new Polyline(points);
            Console.WriteLine($"Тест 1 (из списка точек): {polyline1}");

            // Тест 2: Сдвиг ломаной
            polyline1.Shift(2, 3);
            Console.WriteLine($"Тест 2 (после сдвига на (2,3)): {polyline1}");

            // Тест 3: Сдвиг начала ломаной
            polyline1.ShiftStart(0, 0);
            Console.WriteLine($"Тест 3 (после сдвига начала в (0,0)): {polyline1}");

            // Тест 4: Пустая ломаная
            var polyline2 = new Polyline();
            Console.WriteLine($"Тест 4 (пустая ломаная): {polyline2}");

            Console.WriteLine();
        }

        static void TestUPDPolyline()
        {
            Console.WriteLine("5. ТЕСТИРОВАНИЕ КЛАССА UPDPolyline:");
            Console.WriteLine("===================================");

            // Тест 1: Создание через params
            var updPolyline1 = new UPDPolyline(
                new Point(1, 1),
                new Point(2, 3),
                new Point(4, 5)
            );
            Console.WriteLine($"Тест 1 (через params): {updPolyline1}");

            // Тест 2: Добавление точки через объект Point
            updPolyline1.AddPoint(new Point(7, 8));
            Console.WriteLine($"Тест 2 (после добавления точки): {updPolyline1}");

            // Тест 3: Добавление точки через координаты
            updPolyline1.AddPoint(10, 12);
            Console.WriteLine($"Тест 3 (после добавления координат): {updPolyline1}");

            // Тест 4: Сдвиг ломаной
            updPolyline1.Shift(-1, -1);
            Console.WriteLine($"Тест 4 (после сдвига на (-1,-1)): {updPolyline1}");

            Console.WriteLine();
        }

        static void TestSecondUPDPolyline()
        {
            Console.WriteLine("6. ТЕСТИРОВАНИЕ КЛАССА SecondUPDPolyline:");
            Console.WriteLine("==========================================");

            // Тест 1: Создание через массив точек
            var secondPolyline = new SecondUPDPolyline(
                new Point(0, 0),
                new Point(3, 0),
                new Point(3, 4)
            );
            Console.WriteLine($"Тест 1 (треугольник): {secondPolyline}");

            // Тест 2: Расчет длины ломаной
            Console.WriteLine($"Тест 2 (длина ломаной): {secondPolyline.GetLength()}");

            // Тест 3: Добавление массива точек
            var additionalPoints = new Point[]
            {
                new Point(0, 4),
                new Point(0, 0)
            };
            secondPolyline.AddPoints(additionalPoints);
            Console.WriteLine($"Тест 3 (после добавления массива точек): {secondPolyline}");

            // Тест 4: Расчет новой длины
            Console.WriteLine($"Тест 4 (новая длина): {secondPolyline.GetLength()}");

            // Тест 5: Добавление через IEnumerable
            var morePoints = new List<Point> { new Point(1, 1), new Point(2, 2) };
            secondPolyline.AddPoints(morePoints);
            Console.WriteLine($"Тест 5 (после добавления коллекции): {secondPolyline}");

            Console.WriteLine();
        }

        static void TestHumanWithFather()
        {
            Console.WriteLine("7. ТЕСТИРОВАНИЕ КЛАССА Human_with_Father:");
            Console.WriteLine("===========================================");

            // Создаем отца
            var father = new Human_with_Father(185, "Александр", "Смирнов", "Петрович");

            // Тест 1: Сын с полными данными
            var son1 = new Human_with_Father(175, "Дмитрий", "Смирнов", "Александрович", father);
            Console.WriteLine($"Тест 1 (сын с полными данными): {son1}");

            // Тест 2: Сын без фамилии (должна унаследоваться от отца)
            var son2 = new Human_with_Father(170, "Павел", "", "", father);
            Console.WriteLine($"Тест 2 (сын без фамилии): {son2}");

            // Тест 3: Сын без отчества (должно сгенерироваться от имени отца)
            var son3 = new Human_with_Father(180, "Игорь", "Смирнов", "", father);
            Console.WriteLine($"Тест 3 (сын без отчества): {son3}");

            // Тест 4: Человек без отца
            var orphan = new Human_with_Father(165, "Елена", "Ковалева", "Сергеевна");
            Console.WriteLine($"Тест 4 (человек без отца): {orphan}");

            // Тест 5: Сложная цепочка наследования
            var grandfather = new Human_with_Father(190, "Петр", "Иванов", "Семенович");
            var father2 = new Human_with_Father(185, "Сергей", "", "Петрович", grandfather);
            var grandson = new Human_with_Father(175, "Андрей", "", "", father2);
            Console.WriteLine($"Тест 5 (внук с дедушкой): {grandson}");

            Console.WriteLine();
        }
    }
}