using System;
namespace Lab06_OOP_Principles
{
    public class Crow : Bird, ISpeakAlot
    {
        // Inherited Properties
        public override string Color => "black";

        public override string FeatherType => "heavy";

        public override string Speak()
        {
            return "caw";
        }

        public string SpeaksAlot()
        {
            return $"{Speak()} {Speak()} {Speak()} {Speak()}";
        }

    }
}
