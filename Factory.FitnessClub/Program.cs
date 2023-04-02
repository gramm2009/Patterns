using Factory.FitnessClub.Domain;
using Factory.FitnessClub.Factories;

namespace Factory.FitnessClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>Hello NPC<<\n");
            Console.WriteLine(">>Enter your programm<<\n");
            Console.WriteLine(">> G - Gym <<\n");
            Console.WriteLine(">> P - Pool and Gym<<\n");
            Console.WriteLine(">> T - Personal Training<<\n");

            string? membershipType = Console.ReadLine();

            // В зависимости от решения создаем необходимую фабрику
            MembershipFactory? factory = GetFactory(membershipType);

            // Фабрика - создает нам абонемент.
            IMembership membership = factory.GetMembership();

            // У абонемента смотрим (Имя, Описание, Цену)
            Console.WriteLine(membership.Name);
            Console.WriteLine(membership.Description);
            Console.WriteLine(membership.GetPrice());
        }

        // Метод который возвращает одну из фабрик.
        private static MembershipFactory GetFactory(string membershipType) =>
            membershipType.ToLower() switch
            {
                "g" => new GymMembershipFactory(100, "Basic membership"),
                "p" => new GymPlusPoolMembershipFactory(120, "GymPlusPool"),
                "t" => new PersonalTrainFactory(150, "PersonalTrain"),
                _ => null
            };
    }
}