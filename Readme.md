SOLID are five design principles used to make your software design more understandable, flexible, and maintainable. They could be used in any OOP language. - [Wikipedia](https://en.wikipedia.org/wiki/SOLID)

1. S - Single Responsibility Principle: A class should have only one responsibility, and there should be only a single reason to change it.

2. O - Open Closed Principle: A class should be open for extension but closed for modification.

3. L - Liskov Substitution Principle: A child class should be substitutable for its parent class without breaking the behavior of our code.

4. I - Interface Segregation Principle: An interface should only have methods that apply to all child classes.

5. D - Dependency Inversion Principle: A class should depend on abstraction (interface and abstract class) not of concrete implementations.

___________________________________________________________________________________________________________________________________________

S - Single Responsibility Principle:

Problem: Order class has too many responsabilities. Calculate total, process payment, send e-mail, and data logic to save/update.

![Problem](SOLID\SingleResponsibilityProblem\1_Single_Responsibility_Problem.png)

```
Order: 1 - Status: Pending
Order: 1 - ProcessPayment: 121.14  
Order: 1 - Status: PaymentReceived 
Order: 1 - SendEmail: bia@solid.com
```

Solution: Split business logic into multiple classes and implement their specific responsabilities.

![Solution](SOLID\SingleResponsibilitySolution\1_Single_Responsibility_Solution.png)

```
Order: 2 - Status: Pending
Payment: Process 121.14
Order: 2 - Status: PaymentReceived
Email: SendEmail 2 - ed@solid.com 
```

O - Open Closed Principle:

Problem: CalculateTotal is based into PaymentType. In the future, the code needs to be modified to be based into another PaymentType.

![Problem](SOLID\OpenCloseProblem\2_Open_Close_Problem.png )

```
Customer: Ed - Order: 2 - Status: Pending
Payment: Cash - CalculateTotal()
Payment: Process 121.14
Customer: Ed - Order: 2 - Status: PaymentReceived - Total: 121.14
``` 
Solution: Create a new interface IPayment and create two new classes CardPayment and CashPayment, both of which implement the IPayment interface.

![Solution](SOLID\OpenCloseSolution\2_Open_Close_Solution.png)

```
Customer: Bia - Order: 1 - Status: Pending
Payment: Process 121.14
Customer: Bia - Order: 1 - Status: PaymentReceived - Total: 121.14
Customer: Ed - Order: 2 - Status: Pending
Payment: Process 121.14
Customer: Ed - Order: 2 - Status: Pending - Total: 181.710  

```

L - Liskov Substitution Principle:

Problem: ToyTruck extends Truck but does not support Refuel() method.

![Problem](SOLID\LiskovSubstitutionProblem\3_Liskov_Substitution_Problem.png )

```
Truck needs to refuel
Truck is running: 1     
ToyTruck needs to refuel
Unhandled exception. System.InvalidOperationException: ToyTruck does not need to refuel
   at LiskovSubstitutionProblem.ToyTruck.Refuel(Int32 amount) in D:\GitHub\csharp-solid\SOLID\LiskovSubstitutionProblem\ToyTruck.cs:line 33
   at LiskovSubstitutionProblem.Program.Main(String[] args) in D:\GitHub\csharp-solid\SOLID\LiskovSubstitutionProblem\Program.cs:line 14   
```

Solution: Create a new class ToyTruck, so EletronicToyTruck can extends ToyTruck. 

![Solution](SOLID\LiskovSubstitutionSolution\3_Liskov_Substitution_Solution.png)

```
Truck started: Gasoline
Truck needs to refuel       
Truck is running: 1
Truck stopped
EletronicToyTruck started   
EletronicToyTruck is running
EletronicToyTruck stopped  
```

I - Interface Segregation Principle:

Problem: ITransaction interface contains method that force Product to have a dummy implementation.

![Problem](SOLID\InterfaceSegregationProblem\4_Interface_Segregation_Problem.png)

```
Supplier: Validate
Supplier: Save
Supplier: SendEmail
Product: Validate
Product: Save
Unhandled exception. System.NotSupportedException: Product does not send e-mail
   at InterfaceSegregationProblem.Product.SendEmail() in D:\GitHub\csharp-solid\SOLID\InterfaceSegregationProblem\Product.cs:line 17
   at InterfaceSegregationProblem.Program.Main(String[] args) in D:\GitHub\csharp-solid\SOLID\InterfaceSegregationProblem\Program.cs:line 15
```

Solution: Implement the SendEmail method into a new interface to solve the issue.

![Solution](SOLID\InterfaceSegregationSolution\4_Interface_Segregation_Solution.png)

```
Supplier: Validate
Supplier: Save     
Supplier: SendEmail
Product: Validate  
Product: Save   
```

D - Dependency Inversion Principle:

Problem: Customer class directly reference EmailSender.

![Problem](SOLID\DependencyInversionProblem\5_Dependency_Inversion_Problem.png)

```
Customer: Save
EmailSender: E-mail sent: bia@solid.com - Customer - Test
```

Solution: Create a Interface IEmailSender and SmtpSender and Implement it. Make Customer class directly reference IEmailSender.

![Solution](SOLID\DependencyInversionSolution\5_Dependency_Inversion_Solution.png)

```
Customer saved
EmailSender: E-mail sent: bia@solid.com - Customer - Test
EmailSender: E-mail sent: ed@solid.com - Customer - Test
```
