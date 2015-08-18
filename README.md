# Data Segment Exchange Pattern

Description and sample of the Data Segment Exchange Pattern.

## Quick Start Guide

Clone the repository and open with Visual Studio 2015. 
Sample is built using C# and uses [xunit](http://xunit.github.io/) for unit testing.

## Pattern Description

Object-oriented pattern for exchanging segments of data structures in software system. 
Objects can declare their data dependencies and the data they provide.

## Benefits

* Separates the business domain objects from the retreival and discovery of data segments.
* Fits well in a system that utilizes different external providers for different countries.
* Improves the code quality of systems that have a lot of data orchestration.

## Sample Project

The sample project is built with a shared common library that implements the Data Segment Exchange Pattern, 
and there is a domain class library for business logic and Web API project for calling. The pattern fits
well for both APIs and for self-contained applications and services.

## Final Notes

Any [software pattern](http://www.martinfowler.com/articles/writingPatterns.html) is never a silver bullet that can be used across any type of software or system. This
pattern works well for the scenarios describe above, and make sure you properly test and validate the
pattern in our own solutions before deciding if it's a good match for your problem area.

## License

MIT © [Sondre Bjellås](http://sondreb.com)
