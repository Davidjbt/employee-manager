namespace employee_manager.Models;

public class Employee {
    
    public int Id {get; set;}
    public string Name {get; set;}
    public string Surname {get; set;}
    public int Age {get; set;}
    public Gender Gender {get; set;}
    public string Nationality {get; set;}
}

public enum Gender {
    Male, Female
}