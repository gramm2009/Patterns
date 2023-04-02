namespace Factory.FitnessClub.Domain;


// Интерфейс фитнесс абонемента.
public interface IMembership
{
    string Name { get; }
    string Description { get; set; }
    decimal GetPrice();
}
