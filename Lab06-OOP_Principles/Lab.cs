using System;
namespace Lab06_OOP_Principles
{
    public class Lab : Dog
    {
        // Inherited Properties
        public override string Color => "yellow";

        public override string FurType => "short hair";

        public override string Temperament => "energetic";

        public override string Speak()
        {
            return "woof";
        }
    }
}