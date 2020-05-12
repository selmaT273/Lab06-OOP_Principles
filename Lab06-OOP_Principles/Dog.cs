using System;
namespace Lab06_OOP_Principles
{
    public abstract class Dog : Animal
    {
        // Inherited Properties
        public override int Legs => 4;

        // Dog Properties 
        public abstract string FurType { get; }

        public virtual string Temperament { get; } = "calm";

        // Inherited Methods

        public override string Move()
        {
            return "walk";
        }

        public override string Eat()
        {
            return "kibble";
        }





    }
}
