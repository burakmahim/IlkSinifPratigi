using System;

class Person
{
    // Ad, Soyad ve Doğum Tarihi için özellikler
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    // Bilgileri konsola yazdırmak için bir metot
    public void DisplayInfo()
    {
        Console.WriteLine($"Ad: {FirstName}, Soyad: {LastName}, Doğum Tarihi: {BirthDate.ToShortDateString()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Öğrenci ve öğretmen nesneleri oluşturuluyor
        Person student1 = new Person()
        {
            FirstName = "Burak",
            LastName = "Mahim",
            BirthDate = new DateTime(2002, 12, 11)
        };

        Person student2 = new Person()
        {
            FirstName = "Rabia",
            LastName = "Zalan",
            BirthDate = new DateTime(2003, 7, 23)
        };

        Person teacher1 = new Person()
        {
            FirstName = "Metehan",
            LastName = "Meto",
            BirthDate = new DateTime(2001, 11, 24) // Ay değeri düzeltildi
        };

        Person teacher2 = new Person()
        {
            FirstName = "Berk",
            LastName = "Kaymaz",
            BirthDate = new DateTime(2000, 10, 25) // Ay değeri düzeltildi
        };

        // Öğrenci ve öğretmen bilgilerini ekrana yazdırma
        Console.WriteLine("Öğrenci Bilgileri:");
        student1.DisplayInfo();
        student2.DisplayInfo();

        Console.WriteLine("\nÖğretmen Bilgileri:");
        teacher1.DisplayInfo();
        teacher2.DisplayInfo();
    }
}
