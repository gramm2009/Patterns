// Самая главная фабрика (Абстрактная)

using Factory.FitnessClub.Domain;

namespace Factory.FitnessClub.Factories;

internal abstract class MembershipFactory
{
    public abstract IMembership GetMembership();
}
