using System;
namespace Lab06_OOP_Principles
{
    public class Oriole : Bird, IEatFresh
    {
        // Inherited Properties
        public override string Color => "orange";

        public override string FeatherType => "light";


        public string EatsFresh()
        {
            return $"I eat fresh {Eat()}.";
        }

    }
}