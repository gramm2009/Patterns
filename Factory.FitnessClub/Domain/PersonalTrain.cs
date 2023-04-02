namespace Factory.FitnessClub.Domain;

internal class PersonalTrain : IMembership
{

    private readonly string _name;
    private readonly decimal _price;


    public PersonalTrain(decimal price)
    {
        _name = "PersonalTrain";
        _price = price;
    }

    public string Name => _name;
    public string Description { get; set; } = "";
    public decimal GetPrice() => _price;

}
