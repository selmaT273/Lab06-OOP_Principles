using System;
namespace Lab06_OOP_Principles
{
    public class Poodle : Dog, ISpeakAlot, IEatFresh
    {
        // Inherited Properties
        public override string Color => "black";

        public override string FurType => "curly";

        public override string Temperament => "calm";

        public override string Speak()
        {
            return "bark";
        }

        public string SpeaksAlot()
        {
            return $"{Speak()} {Speak()} {Speak()} {Speak()}";
        }

        public string EatsFresh()
        {
            return $"I eat {Eat()} and fresh meat";
        }
    }
}
