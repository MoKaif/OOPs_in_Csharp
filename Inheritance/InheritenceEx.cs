using System;

// Single Inheritance
public class Employee
{
    public string Name { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Employee: {Name}");
    }
}

public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public void WriteCode()
    {
        Console.WriteLine($"Developer {Name} is writing code in {ProgrammingLanguage}.");
    }
}

// Multi-level Inheritance
public class Manager : Developer
{
    public void ManageTeam()
    {
        Console.WriteLine($"Manager {Name} is managing the development team.");
    }
}

// Hierarchical Inheritance
public class QAEngineer : Employee
{
    public void TestSoftware()
    {
        Console.WriteLine($"QA Engineer {Name} is testing software.");
    }
}

public class ScrumMaster : Employee
{
    public void FacilitateScrum()
    {
        Console.WriteLine($"Scrum Master {Name} is facilitating the Scrum process.");
    }
}

// Multiple Inheritance
public interface ITraining
{
    void ProvideTraining();
}

public class TechnicalLead : Developer, ITraining
{
    public void LeadDevelopment()
    {
        Console.WriteLine($"Technical Lead {Name} is leading the development.");
    }

    public void ProvideTraining()
    {
        Console.WriteLine($"Technical Lead {Name} is providing training on {ProgrammingLanguage}.");
    }
}

class Program
{
    static void Main()
    {
        // Single Inheritance
        Developer developer = new Developer { Name = "John", ProgrammingLanguage = "C#" };
        developer.DisplayInfo();
        developer.WriteCode();

        // Multi-level Inheritance
        Manager manager = new Manager { Name = "Alice", ProgrammingLanguage = "Java" };
        manager.DisplayInfo();
        manager.WriteCode();
        manager.ManageTeam();

        // Hierarchical Inheritance
        QAEngineer qaEngineer = new QAEngineer { Name = "Bob" };
        qaEngineer.DisplayInfo();
        qaEngineer.TestSoftware();

        ScrumMaster scrumMaster = new ScrumMaster { Name = "Eve" };
        scrumMaster.DisplayInfo();
        scrumMaster.FacilitateScrum();

        // Multiple Inheritance
        TechnicalLead techLead = new TechnicalLead { Name = "Charlie", ProgrammingLanguage = "Python" };
        techLead.DisplayInfo();
        techLead.WriteCode();
        techLead.ProvideTraining();
    }
}
