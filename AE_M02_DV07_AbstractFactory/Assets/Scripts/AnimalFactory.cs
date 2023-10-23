using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAnimalFactory
{
    IAnimal Create(AnimalRequirements requirements);
}

public class FarmAnimalFactory : IAnimalFactory //was cycleFactory
{
    public IAnimal Create(AnimalRequirements requirements)
    {
        switch (requirements.NumberOfLegs)
        {
            case 0:
                if (requirements.HasFur == 1 || requirements.HasFur == 2) return new Caterpillar(); //IUWDHILUAGQD
                return new Worm();
            case 2:
                if (requirements.HasFur == 0) return new Human();
                if (requirements.HasFur == 3) return new LiterallyNothing();
                if (requirements.HasFur == 1) return new Rabbit();
                return new Chicken();
            case 4:
                if (requirements.HasFur == 0) return new LiterallyNothing();
                if (requirements.HasFur == 2) return new Cow();
                if (requirements.HasFur == 1) return new Horse();
                return new Horse();
        default:
            return new Worm();
        }
    }
}

//public class MotorVehicleFactory : IAnimalFactory
//{
//    public IAnimal Create(AnimalRequirements requirements)
//    {
//        switch (requirements.Passengers)
//        {
//            case 1:
//                return new MotorBike();
//            case 2:
//                if (requirements.Cargo && requirements.NumberOfWheels == 4) return new Truck();
//                return new Car();
//            default:
//                return new Car();
//        }
//    }
//}

public class WildAnimalFactory : IAnimalFactory
{
    public IAnimal Create(AnimalRequirements requirements)
    {
        if (requirements.Pet)
            return new PetFactory().Create(requirements);
        switch (requirements.NumberOfLegs)
        {
            case 0:
                if (requirements.HasFur == 0) return new Snake();
                if (requirements.HasFur == 2) return new Caterpillar();
                if (requirements.HasFur == 1) return new LiterallyNothing();
                return new Snail();
            case 2:
                if (requirements.HasFur == 0 || requirements.HasFur == 2) return new LiterallyNothing();
                if (requirements.HasFur == 1) return new Monkey();
                return new Ostrich();
            case 4:
                if (requirements.HasFur == 0) return new Crocodile();
                if (requirements.HasFur == 2) return new Fox();
                if (requirements.HasFur == 1) return new Zebra();
                return new Zebra();
            default:
                return new Snail();
        }
    }
}

public class PetFactory : IAnimalFactory
{
    public IAnimal Create(AnimalRequirements requirements)
    {
        switch (requirements.NumberOfLegs)
        {
            case 0:
                if (requirements.HasFur == 0) return new Snake();
                if (requirements.HasFur == 2) return new LiterallyNothing();
                if (requirements.HasFur ==  1) return new Caterpillar();
                return new Snake();
            case 2:
                if (requirements.HasFur == 0) return new LiterallyNothing();
                if (requirements.HasFur == 2) return new LiterallyNothing();
                if (requirements.HasFur == 1) return new Duck();
                return new Duck();
            case 4:
                if (requirements.HasFur == 0) return new Lizard();
                if (requirements.HasFur == 2) return new Dog();
                if (requirements.HasFur == 1) return new Cat();
                return new Dog();
            default:
                return new Snake();
        }
    }
}

//public class MotorVehicleFactoryCargo : IVehicleFactory
//{
//    public IVehicle Create(VehicleRequirements requirements)
//    {
//        switch (requirements.Cargo)
//        {
//            case true:
//                return new Truck();
//            default:
//                return new Car();
//        }
//    }
//}

public abstract class AbstractAnimalFactory
{
    public abstract IAnimal Create();
}

public class AnimalFactory : AbstractAnimalFactory
{
    private readonly IAnimalFactory _factory;
    //private readonly IAnimalFactory _factoryTwo;
    private readonly AnimalRequirements _requirements;

    public AnimalFactory(AnimalRequirements requirements)
    {
        _factory = requirements.FarmAnimal ? (IAnimalFactory)new WildAnimalFactory() : new FarmAnimalFactory();

        _requirements = requirements;
    }

    public override IAnimal Create()
    {
        return _factory.Create(_requirements);
    }
}
