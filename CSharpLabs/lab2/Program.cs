using System;

class Subject
{
    public string Name { get; set; }

    public Subject(string name)
    {
        Name = name;
    }
}

class Game
{
    public string Title { get; set; }

    public Game(string title)
    {
        Title = title;
    }
}

class Student
{
    private string name; // Поле с модификатором private
    public int Age { get; set; } // Поле с модификатором public
    public Subject FavoriteSubject { get; set; }
    public Game FavoriteGame { get; set; }

    // Конструктор с двумя параметрами
    public Student(string name, int age, Subject favoriteSubject, Game favoriteGame)
    {
        this.name = name;
        Age = age;
        FavoriteSubject = favoriteSubject;
        FavoriteGame = favoriteGame;
    }

    // Конструктор с одним параметром
    public Student(string _name)
    {
        name = _name;
        Age = 0;
        FavoriteSubject = new Subject("Неизвестный предмет");
        FavoriteGame = new Game("Неизвестная игра");
    }

    // Метод для вывода информации о студенте
    public void WriteInfo()
    {
        Console.WriteLine("Студент " + name + ", возраст " + Age);
    }

    // Метод для увеличения возраста студента
    public void BecomeOlder()
    {
        Console.WriteLine("Студент " + name + ", возраст " + (Age + 1));
    }

    // Метод для получения имени студента
    public string GetName()
    {
        return name;
    }

    // Метод для установки имени студента
    public void SetName(string _name)
    {
        name = _name;
    }

    // Метод, возвращающий любимый предмет и игру студента
    public void GetFavoriteSubjectAndGame()
    {
        Console.WriteLine("Любимый предмет: " + FavoriteSubject.Name);
        Console.WriteLine("Любимая игра: " + FavoriteGame.Title);
    }

    // Пример передачи параметра по значению
    public static void ModifyStudentByValue(Student student)
    {
        student = new Student("Измененный студент", 30, new Subject("Физика"), new Game("Шахматы"));
    }

    // Пример передачи параметра по ссылке
    public static void ModifyStudentByReference(ref Student student)
    {
        student.name = "Студент по ссылке";
        student.Age = 35;
    }

    static void Main(string[] args)
    {
        // Создаем объекты студента
        Subject math = new Subject("Математика");
        Game football = new Game("Футбол");

        Student Oleg = new Student("Олег", 25, math, football);
        Student Venya = new Student("Веня");

        // Вывод информации о студентах
        Oleg.WriteInfo();
        Oleg.BecomeOlder();

        Venya.WriteInfo();
        Oleg.SetName("Рома");
        Oleg.BecomeOlder();

        // Вывод любимого предмета и игры
        Oleg.GetFavoriteSubjectAndGame();
        Venya.GetFavoriteSubjectAndGame();

        // Пример передачи параметра по значению
        Console.WriteLine("\nПередача по значению:");
        ModifyStudentByValue(Oleg);
        Oleg.WriteInfo(); // Имя и возраст не изменятся

        // Пример передачи параметра по ссылке
        Console.WriteLine("\nПередача по ссылке:");
        ModifyStudentByReference(ref Oleg);
        Oleg.WriteInfo(); // Имя и возраст изменятся


    }
}
