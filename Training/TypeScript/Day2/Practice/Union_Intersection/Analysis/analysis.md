Typescript compels the programmer to assign a datatype to each variable declared, and a variable can only be of any one type by default.
in cases where there is a need for some flexibility, like allowing a variable to hold data of different types, there the concept of union comes in use.
As the name suggests, Union allows us to assign multiple datatypes to the same variable. This lets user assign, for example, a string or a number to the same variable.
This is done by writing the datatypes inside a pair of paranthesis, and separated by a "|"(pipeline) symbol.

example:

let demovar :(number|string);