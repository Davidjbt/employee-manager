using employee_manager.Models;
using static employee_manager.Models.Gender;

namespace employee_manager.Utils;

public static class EmployeesList {

    public static readonly List<Employee> Employees = [
        new Employee {Id = 1, Name = "John", Surname = "Doe", Age = 25, Gender = Male, Nationality = "Italian"},
        new Employee {Id = 2, Name = "Jane", Surname = "Smith", Age = 30, Gender = Female, Nationality = "American"},
        new Employee {Id = 3, Name = "Peter", Surname = "Jones", Age = 35, Gender = Male, Nationality = "British"},
        new Employee {Id = 4, Name = "Anna", Surname = "Garcia", Age = 28, Gender = Female, Nationality = "Spanish"},
        new Employee {Id = 5, Name = "Michael", Surname = "Chen", Age = 40, Gender = Male, Nationality = "Chinese"},
        new Employee {Id = 6, Name = "Sophia", Surname = "Davies", Age = 22, Gender = Female, Nationality = "Australian"},
        new Employee {Id = 7, Name = "David", Surname = "Schmidt", Age = 45, Gender = Male, Nationality = "German"},
        new Employee {Id = 8, Name = "Olivia", Surname = "Martin", Age = 33, Gender = Female, Nationality = "French"},
        new Employee {Id = 9, Name = "Daniel", Surname = "Kim", Age = 29, Gender = Male, Nationality = "Korean"},
        new Employee {Id = 10, Name = "Emily", Surname = "Rodriguez", Age = 27, Gender = Female, Nationality = "Mexican"},
        new Employee {Id = 11, Name = "James", Surname = "Wilson", Age = 50, Gender = Male, Nationality = "Canadian"},
        new Employee {Id = 12, Name = "Isabella", Surname = "Moore", Age = 31, Gender = Female, Nationality = "Irish"},
        new Employee {Id = 13, Name = "William", Surname = "Taylor", Age = 26, Gender = Male, Nationality = "New Zealander"},
        new Employee {Id = 14, Name = "Charlotte", Surname = "Brown", Age = 38, Gender = Female, Nationality = "South African"},
        new Employee {Id = 15, Name = "Mohammed", Surname = "Khan", Age = 42, Gender = Male, Nationality = "Pakistani"},
        new Employee {Id = 16, Name = "Priya", Surname = "Sharma", Age = 29, Gender = Female, Nationality = "Indian"},
        new Employee {Id = 17, Name = "Carlos", Surname = "Santana", Age = 33, Gender = Male, Nationality = "Mexican"},
        new Employee {Id = 18, Name = "Lena", Surname = "Petrov", Age = 36, Gender = Female, Nationality = "Russian"},
        new Employee {Id = 19, Name = "Kenji", Surname = "Tanaka", Age = 24, Gender = Male, Nationality = "Japanese"},
        new Employee {Id = 20, Name = "Fatima", Surname = "Al-Farsi", Age = 31, Gender = Female, Nationality = "Saudi Arabian"},
        new Employee {Id = 21, Name = "Tom", Surname = "Hanks", Age = 65, Gender = Male, Nationality = "American"},
        new Employee {Id = 22, Name = "Sophie", Surname = "Dubois", Age = 27, Gender = Female, Nationality = "French"},
        new Employee {Id = 23, Name = "Gareth", Surname = "Roberts", Age = 48, Gender = Male, Nationality = "British"},
        new Employee {Id = 24, Name = "Lucia", Surname = "Costa", Age = 23, Gender = Female, Nationality = "Brazilian"},
        new Employee {Id = 25, Name = "Manuel", Surname = "Silva", Age = 55, Gender = Male, Nationality = "Portuguese"},
        new Employee {Id = 26, Name = "Ayanda", Surname = "Mkhize", Age = 30, Gender = Female, Nationality = "South African"},
        new Employee {Id = 27, Name = "Giovanni", Surname = "Rossi", Age = 39, Gender = Male, Nationality = "Italian"},
        new Employee {Id = 28, Name = "Elena", Surname = "Popova", Age = 34, Gender = Female, Nationality = "Russian"},
        new Employee { Id = 29, Name = "José", Surname = "Fernandez", Age = 41, Nationality = "Spanish"},
    ];

}