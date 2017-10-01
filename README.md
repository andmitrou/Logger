# Logger
Logger is a library that enables to use multiple log mechanisms in order to log information, warnings, exceptions casused in code.<br/>
For now it supports FileLog and EventViewer log but it will be extended for Mail, Database etc.<br/><br/>
The architecture is based on the <b>Bridge Pattern</b>.
### Bridge Pattern
The bridge pattern is a design pattern used in software engineering that is meant to "decouple an abstraction from its implementation so that the two can vary independently", introduced by the Gang of Four. The bridge uses encapsulation, aggregation, and can use inheritance to separate responsibilities into different classes.
When a class varies often, the features of object-oriented programming become very useful because changes to a program's code can be made easily with minimal prior knowledge about the program. The bridge pattern is useful when both the class and what it does vary often. The class itself can be thought of as the abstraction and what the class can do as the implementation. The bridge pattern can also be thought of as two layers of abstraction.

![Bridge Pattern](https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Bridge_UML_class_diagram.svg/500px-Bridge_UML_class_diagram.svg.png)<br/>

### Logger Analysis using Bridge Pattern
<b>ConcreteImplementors</b>: The classes that are inside Loggers namespace <b>EventViewerLogger</b>, <b>FileLogger</b>
<b>Implementor</b>:The Interface <b>ILog</b> which is a property to the abstract implementor

