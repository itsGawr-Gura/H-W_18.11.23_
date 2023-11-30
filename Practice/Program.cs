using Practice;

class Program
{
    static void Main(string[] args)
    {
        //Ex 1 Students on Events
        List<string> students = new List<string>();
        using (StreamReader sr = new StreamReader("students.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                students.Add(line);
            }
        }
        string eventName = "Театральная постановка";
        DateTime eventDate = new DateTime(2022, 11, 30);
        int participantsPerGroup = 3;
        CreateEvent(eventName, eventDate, participantsPerGroup);
        AddParticipantsToEvent(eventName, eventDate, students);
        static void CreateEvent(string name, DateTime date, int participantsPerGroup)
        {
            using (StreamWriter sw = File.AppendText("events.txt"))
            {
                sw.WriteLine($"Мероприятие «{name}» на {date}. От каждой группы нужно {participantsPerGroup} человека.");
            }
        }
        static void AddParticipantsToEvent(string name, DateTime date, List<string> participants)
        {
            using (StreamWriter sw = File.AppendText("events.txt"))
            {
                sw.WriteLine($"Участники мероприятия «{name}» на {date}:");
                foreach (var participant in participants)
                {
                    sw.WriteLine(participant);
                }
            }
        }
    // Ex 2 Events
    Console.WriteLine("--------------------");
        Console.WriteLine("Events");
        List<Person> people = new List<Person>
        {
            new Person("Алексей", "концерты", "Я так долго ждал этого концерта! Я обязательно пойду!"),
            new Person("Елена", "выход сериала", "О, это мой любимый сериал! Я с нетерпением буду ждать выхода новой серии!"),
            new Person("Иван", "спорт", "Я обожаю спорт! Это событие будет для меня настоящим праздником!")
        };
        Console.Write("Введите интересующее вас событие: ");
        string eventInput = Console.ReadLine();
        List<Person> matchingPeople = people.FindAll(person => person.Hobby == eventInput);
        if (matchingPeople.Count > 0)
        {
            foreach (Person person in matchingPeople)
            {
                Console.WriteLine($"{person.Name}: {person.Reaction}");
            }
        }
        else
        {
            Console.WriteLine("Нет людей с таким увлечением.");
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
}