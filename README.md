# Description
This repository contains C# code that implements two classes for a project manager system. 
The classes are `Customer` and `Employee`, and they are part of the `ProjectManager.Module.BusinessObjects` namespace.

The `Customer` class represents a customer of a marketing company. 
It has properties for the customer's name, last name, and phone number. 
It also has collections of `Project` and `Testimonials` objects that represent the projects and testimonials associated with the customer.

The `Employee` class represents an employee of the marketing company. 
It has properties for the employee's name, last name, birthday, and an image of the employee. 
It also has a boolean property that indicates whether the employee is active or not.

# Project Manager
This project contains code for a project manager system. It implements two classes for the system, `Customer` and `Employee`.

### Customer Class
The Customer class is defined in the `ProjectManager.Module.BusinessObjects` namespace. 
It represents a customer of a marketing company. It has the following properties:

+ `Name`: A string property that represents the customer's name.
+ `LastName`: A string property that represents the customer's last name.
+ `PhoneNumber`: A string property that represents the customer's phone number.
+ `Projects`: A collection of Project objects that represent the projects associated with the customer.
+ `Testimonialss`: A collection of Testimonials objects that represent the testimonials associated with the customer.

### Employee Class
The Employee class is defined in the `ProjectManager.Module.BusinessObjects` namespace. 
It represents an employee of the marketing company. It has the following properties:

+ `Name`: A string property that represents the employee's name.
+ `LastName`: A string property that represents the employee's last name.
+ `Birthday`: A `DateTime` property that represents the employee's birthday.
+ `Image`: A byte array property that represents an image of the employee.
+ `Active`: A boolean property that indicates whether the employee is active or not.

## Technologies
This project is written in C# and uses the DevExpress framework.

## Usage
This code can be used as a starting point for a project manager system that needs to manage customers and employees. 
Developers can modify the classes to fit their specific requirements.

