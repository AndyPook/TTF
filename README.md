###TTF ASSIGNMENT
As TTF is a rather complex system, it's important for us, that you have an eye for
algorithmic design and implementing rather complex user input mappings.

In this assignment, we want you to implement a (very simple) version of how TTF
works.

You are given a number of inputs, mappings between inputs and outputs, and the
expected output.

The algorithm should be implemented in a SOLID manner, and be exposed in a
simple REST api.

Your assignment can be implemented in PHP or C# (any version you prefer), and
you can use any framework / libraries that you wish. Unit testing is not a
requirement, but a certain plus.

###Inputs
We have the following variables:
```
A: bool
B: bool
C: bool
D: int
E: int
F: int
```

###Outputs
The outputs are defined as:
```
X: enum[S,R,T]
Y: real/float/decimal
```

###Mappings
The assignment consists of a 'base mapping', and two specialized mappings that
override / extend the base mapping.
####Base
```
A && B && !C => X = S
A && B && C => X = R
!A && B && C => X =T
[other] => [error]

X = S => Y = D + (D * E / 100)
X = R => Y = D + (D * (E - F) / 100)
X = T => Y = D - (D * F / 100)
```

####Specialized 1
```
X = R => Y = 2D + (D * E / 100)
```

####Specialized 2
```
A && B && !C => X = T
A && !B && C => X = S

X = S => Y = F + D + (D * E / 100)
```

###REST
Please implement the algorithms in any RESTful manner, you seem fit. The services
should, however, return the resulting data as JSON.
