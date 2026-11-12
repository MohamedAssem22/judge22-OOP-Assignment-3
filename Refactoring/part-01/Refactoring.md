Part 1: Decorator & Template Method Patterns
1. Task 1.1 — Decorator Pattern (Notifications)
Design Pattern Used: Decorator Pattern

Why this pattern was chosen:
Allows dynamic adding of responsibilities (like Logging or Retrying) to notification services without altering the base INotificationService implementations. It adheres to the Open/Closed Principle (OCP) as we can add new behaviors by wrapping objects rather than modifying existing code.

Refactoring Summary:

Created base interface INotificationService.

Implemented concrete notifications (EmailNotificationService, SmsNotificationService).

Created an abstract NotificationDecorator and concrete decorators (LoggingNotificationDecorator, RetryNotificationDecorator).

2. Task 1.2 — Template Method Pattern (Report Exporters)
Design Pattern Used: Template Method Pattern

Why this pattern was chosen:
Defines the skeleton of the report generation algorithm (ExportReport) in an abstract base class while letting subclasses override specific steps (FormatHeader, FormatContent, FormatFooter) without changing the overall workflow structure.

Refactoring Summary:

Created abstract base class ReportExporter defining the template method ExportReport().

Derived specialized classes (PdfReportExporter, ExcelReportExporter, JsonReportExporter) overriding specific formatting steps.