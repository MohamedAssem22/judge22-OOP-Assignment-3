## Part 2: Facade Pattern & SOLID / OCP
3. Task 1.3 — Facade Pattern & Dependency Injection (Enrollment)
Design Pattern Used: Facade Pattern combined with Interface-based Dependency Injection.

Why this pattern was chosen:

Facade: Provides a unified, simple interface (EnrollmentManager) over a set of complex subsystem services (PaymentGateway, SeatInventory, InvoiceGenerator, EmailService), decoupling client code (Program.cs) from subsystem complexity.

SOLID / OCP: Introduced interfaces (IPaymentGateway, ISeatInventory, IInvoiceGenerator, IEmailService) so the system is open for extension but closed for modification. Changing or adding gateway implementations won't break or require modifying the EnrollmentManager.

Refactoring Summary & Execution Workflow:

Defined interfaces for all 4 subsystem services.

Updated EnrollmentManager to depend on these interfaces via Constructor Injection.

Ensured logical order of operations inside Enroll():

Charge Payment (_paymentGateway.Charge)

Reserve Seat (_seatInventory.Reserve)

Generate Invoice (_invoiceGenerator.Create)

Send Confirmation Email (_emailService.Send)