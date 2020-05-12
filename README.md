# Lab 06: I built a Zoo!

## Problem Domain
The contents of this lab will plan and build out what animals live in the zoo. It contains a console app that will instantiate animals and prove that they are inheriting traits and features from their parent classes. 

## UML
[UML](Lab06-UML.JPG)

## Object Oriented Programming Principles
### Inheritance
- The notion that a class can get its behavior and data from a parent class

### Abstraction
- Refers to the characteristics of Abstract classes. Abstract classes contain things that are true for all of the ancestors but does not specify any kind of default behavior. The use of an abstract class also requires implementing override. 

## Polymorphism
- The idea that child classes can change behavior by overriding previous/parent behavior in order to reflect their particular abilities.

## Encapsulation
- This is the practice of hiding implementation methods and attributes from the user to a varying degree by way of using access modifiers such as public, private, protected, and internal. 

# Lab 07: Interfaces

## Interface
- An interface is a way to group types together by sharing the same kind of inheritance among them. It defines a role that an object can play by specifying a thing that an object is able to do. 

## Interface Implementation
- In my project, there are currently 2 interfaces: IEatFresh and ISpeakAlot. 
### IEatFresh
- This interface allows specific concrete animals to eat fresh food if they inherit from the IEatFresh interface.
### ISpeakAlot
- This interface allows some of the concrete animals to SpeakAlot if they inherit from the ISpeakAlot class.

[Updated Diagram](Lab07-UML.jpg)