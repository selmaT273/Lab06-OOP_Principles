using System;
namespace Lab06_OOP_Principles
{
    public abstract class Animal
    {
        // Properties 
        public virtual int Legs { get; } = 2;
        public abstract string Color { get; }



        // Methods
        public abstract string Eat();

        public abstract string Move();

        public virtual string Speak()
        {
            return "screech";
        }

    }
}
