using System;
namespace Lab06_OOP_Principles
{
    public class Poodle : Dog, ISpeakAlot, IEatFresh, IBite
    {
        // Inherited Properties
        public override string Color => "black";

        public override string FurType => "curly";

        public override string Temperament => "calm";

        public string BiteForce { get; set; }

        public string BiteMark { get; set; }

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

        public string BiteMark => "tiny teeth";
    }
}
