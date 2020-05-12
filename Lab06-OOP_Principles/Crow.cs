using System;
namespace Lab06_OOP_Principles
{
    public class Crow : Bird
    {
        // Inherited Properties
        public override string Color => "black";

        public override string FeatherType => "heavy";

        public override string Speak()
        {
            return "caw";
        }


    }
}
