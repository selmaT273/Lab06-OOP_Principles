using System;
namespace Lab06_OOP_Principles
{
    public class Cardinal : Bird
    {
        // Inherited Properties
        public override string Color => "red";

        public override string FeatherType => "medium";

        public override bool Migrate()
        {
            return true;
        }


    }
}
