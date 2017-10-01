# Logger
Logger is a library that enables to use multiple log mechanisms in order to log information, warnings, exceptions casused in code.<br/>
For now it supports FileLog and EventViewer log but it will be extended for Mail, Database etc.<br/><br/>
The architecture is based on the <b>Bridge Pattern</b>.
### Bridge Pattern
The bridge pattern is a design pattern used in software engineering that is meant to "decouple an abstraction from its implementation so that the two can vary independently", introduced by the Gang of Four. The bridge uses encapsulation, aggregation, and can use inheritance to separate responsibilities into different classes.
When a class varies often, the features of object-oriented programming become very useful because changes to a program's code can be made easily with minimal prior knowledge about the program. The bridge pattern is useful when both the class and what it does vary often. The class itself can be thought of as the abstraction and what the class can do as the implementation. The bridge pattern can also be thought of as two layers of abstraction.

[[Image:Bridge UML class diagram.svg|500px]]
; Abstraction (abstract class)
: defines the abstract interface
: maintains the Implementor reference.
; RefinedAbstraction (normal class)
: extends the interface defined by Abstraction
; Implementor (interface)
: defines the interface for implementation classes
; ConcreteImplementor (normal class)
: implements the Implementor interface

[[Image:Bridge pattern in LePUS3.1.gif|thumb|none|400px|Bridge in [[Lepus3|LePUS3]] ([http://lepus.org.uk/ref/legend/legend.xml legend]) ]]

