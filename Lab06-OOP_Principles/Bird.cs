using System;
namespace Lab06_OOP_Principles
{
    public abstract class Bird : Animal
    {
        // Properties
        public abstract string FeatherType { get; }

        // Methods

        public override string Move()
        {
            return "fly";
        }

        public override string Eat()
        {
            return "worms";
        }


        public override string Speak()
        {
            return "chirp";
        }

        public virtual bool Migrate()
        {
            return false;
        }
    }
}
