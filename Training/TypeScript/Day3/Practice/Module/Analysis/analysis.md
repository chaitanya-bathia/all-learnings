Module is a concept of logically linking classes and interfaces across several files.
When a user wants to extend the scope of a class and inherit it to another class, it can be done simply by extending, if the classes are in same file.
But if the classes are written in different files, the to-be parent class needs to be exported from the file it is written in. This makes it available in the scope of the project, to be imported.
Where the to-be child class is declared, the parent class needs to be imported first, before it can be extended.
To shortly define, Modules have their own scope and hence this scope needs to be exported before it can be used elsewhere.
any file containing a top-level import or export is considered a module. 