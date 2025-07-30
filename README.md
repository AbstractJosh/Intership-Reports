# SOLID Principles and Design Patterns

## SOLID Principles

These principles help developers write code that is maintainable, scalable, and robust. They provide guidelines for writing clean and easily modifiable code.

### S – Single Responsibility Principle (SRP)

> A class should have only one reason to change.

Each class should focus on a single task or functionality.  
For example, a `ReportGenerator` method should not also handle file saving; it should leave that to a separate class.

**Bad Code Example:**

<!-- Add code snippet here -->

**Fix:**

<!-- Add fixed code snippet here -->

---

### O – Open/Closed Principle (OCP)

> Software entities should be open for extension, but closed for modification.

You should be able to add new functionality without altering existing code. This is often achieved using interfaces and inheritance.

**Bad Code Example:**

<!-- Add code snippet here -->

**Fix:**

<!-- Add fixed code snippet here -->

---

### L – Liskov Substitution Principle (LSP)

> Subtypes must be substitutable for their base types.

A child class should be able to do whatever a parent class can.

**Bad Code Example:**

<!-- Add code snippet here -->

**Fix:**

<!-- Add fixed code snippet here -->

---

### I – Interface Segregation Principle (ISP)

> Clients should not be forced to depend on interfaces they do not use.

Developers should break down large, "fat" interfaces into smaller and more specific ones to reduce dependencies.

**Bad Code Example:**

<!-- Add code snippet here -->

**Fix:**

<!-- Add fixed code snippet here -->

---

### D – Dependency Inversion Principle (DIP)

> Entities must depend on abstractions, not on concretions.

High-level modules should not depend on low-level modules. Both should depend on abstractions.

**Bad Code Example:**

<!-- Add code snippet here -->

**Fix:**

<!-- Add fixed code snippet here -->

---

## Design Patterns

Design patterns are preset, reusable solutions to recurring design problems.  
They are categorized into three types: **Creational**, **Structural**, and **Behavioral**.

---

### A. Creational Patterns

These handle object creation mechanisms:

- **Singleton**: Ensures a class has only one instance.
- **Factory Method**: Defines an interface for creating an object, but lets subclasses decide which class to instantiate.
- **Abstract Factory**: Produces families of related objects without specifying concrete classes.
- **Builder**: Separates object construction from its representation.
- **Prototype**: Creates new objects by copying existing ones.

---

### B. Structural Patterns

These focus on class and object composition:

- **Adapter**: Converts one interface into another.
- **Bridge**: Separates an abstraction from its implementation.
- **Composite**: Treats individual objects and compositions uniformly.
- **Decorator**: Adds behavior to objects dynamically.
- **Facade**: Provides a simplified interface to a complex subsystem.
- **Flyweight**: Shares common state between many objects to save memory.
- **Proxy**: Provides a placeholder or surrogate for another object.

---

### C. Behavioral Patterns

These focus on communication between objects:

- **Observer**: Defines a dependency between objects so that when one changes, all dependents are notified.
- **Strategy**: Allows selecting an algorithm at runtime.
- **Command**: Encapsulates a request as an object.
- **State**: Allows an object to alter its behavior when its internal state changes.
- **Template Method**: Defines the skeleton of an algorithm, deferring steps to subclasses.
- **Chain of Responsibility**: Passes a request along a chain of handlers.
- **Mediator**: Centralizes complex communications between related objects.
