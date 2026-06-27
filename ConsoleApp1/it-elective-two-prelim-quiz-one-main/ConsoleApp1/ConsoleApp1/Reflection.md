I used inheritance because all the specific transport types share a fundamental, common identity as vehicles, which allows us to write shared properties like Name once in a central base class and group different vehicle types together in a single collection.

I used interfaces to define specific, standalone capabilities like flying, driving, or sailing that can be flexibly assigned to any vehicle type regardless of where it sits in the structural family tree.

A Helicopter cannot inherit from both Vehicle and Airplane because C# strictly prohibits multiple class inheritance to prevent architectural conflicts like the "Diamond Problem," where a sub-class wouldn't know which parent's overlapping logic to execute.

A Helicopter can implement both IFlyable and IDriveable because C# explicitly allows a class to implement an unlimited number of interfaces, as they function merely as flexible design contracts rather than restrictive parental bloodlines.

I would design a Submarine by having it inherit its primary structural identity from the Vehicle base class while simultaneously implementing both the ISailable and IDiveable interfaces to support both behavioral capabilities without violating single-inheritance