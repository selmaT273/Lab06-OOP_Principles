﻿using System;
namespace Lab06_OOP_Principles
{
    public class Poodle : Dog
    {
        // Inherited Properties
        public override string Color => "black";

        public override string FurType => "curly";

        public override string Temperament => "calm";

        public override string Speak()
        {
            return "bark";
        }
    }
}