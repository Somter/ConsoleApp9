using ConsoleApp9;
using System.Collections;

class MainClass
{
    public static void Main() 
    {
        try
        {
            //Person person = new Person("Иван", "Иванов", "123-456", 30);    
            ////person.Print();

            //Console.WriteLine();

            //Student student = new Student("Анна", "Смирнова", 20, "789-101", 5, 101);
            ////student.Print();
            //Student student2 = new Student("Anna", "lolol", 20, "789-101", 4.5, 5);

            //Academy_Group academy_Group = new Academy_Group();
            //academy_Group.Add(student);
            //academy_Group.Add(student2);
            ////academy_Group.Remove("Смирнова");
            ////academy_Group.Edit("Смирнова", student2);
            ////academy_Group.Print();
            //academy_Group.Save();
            //academy_Group.Load();
            //academy_Group.Print();
            //academy_Group.Search(6);    

            ClassMenu menu = new ClassMenu();
            menu.Menu();    
        }
        catch (Exception ex) 
        { 
            Console.WriteLine(ex.Message);  
        }
    }
}
