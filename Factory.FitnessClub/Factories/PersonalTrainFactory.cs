using Factory.FitnessClub.Domain;

namespace Factory.FitnessClub.Factories;

internal class PersonalTrainFactory : MembershipFactory
{
    private readonly decimal _price;
    private readonly string _description;

    public PersonalTrainFactory(decimal price, string description)
    {
        _price = price;
        _description = description;
    }

    public override IMembership GetMembership()
    {
        PersonalTrain membership = new PersonalTrain(_price)
        {
            Description = _description
        };

        return membership;
    }
}
