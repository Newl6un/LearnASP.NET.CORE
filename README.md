# ASP.NET Core Web API - What I Learned

This project helped me gain a deeper understanding of building and optimizing APIs using ASP.NET Core. Below are the key concepts and techniques I learned while working through this project.

---

## Key Learnings

### 1. Project Configuration
- **Environment-Based Configuration**: Learned how to manage `appsettings.json` for different environments (`Development`, `Production`) and use environment variables effectively.
- **Middleware Pipeline**: Explored how middleware components process requests and responses and their importance in structuring the application pipeline.
- **CORS Setup**: Configured Cross-Origin Resource Sharing (CORS) to allow controlled access to APIs.

### 2. Core API Development
- **Controllers and Routing**: Built and managed routes to handle API endpoints efficiently.
- **DTOs and AutoMapper**: Differentiated between DTOs and entity models, and automated data mapping using AutoMapper.
- **CRUD Operations**: Implemented Create, Read, Update, and Delete (CRUD) functionalities with a structured approach.

### 3. Validation
- **Built-in Attributes**: Used attributes like `[Required]`, `[MaxLength]`, and `[Range]` for input validation.
- **Custom Validation**: Implemented custom attributes and the `IValidatableObject` interface for complex validation scenarios.

### 4. Logging and Debugging
- **Custom Logger Service**: Integrated a custom logging service using NLog for detailed log management.
- **Log Levels**: Utilized Info, Debug, Warn, and Error levels to monitor and debug the application.

### 5. Architecture and Design Patterns
- **Onion Architecture**: Applied the Onion Architecture to ensure separation of concerns and modular development.
- **Repository Pattern**: Built a generic repository for data access and encapsulated business logic in the service layer.
- **Dependency Injection**: Leveraged DI to manage services and promote loose coupling between components.

### 6. Advanced Concepts
- **Asynchronous Programming**: Used `async` and `await` for non-blocking operations and improved application performance.
- **Action Filters**: Implemented filters for cross-cutting concerns like validation and logging.
- **Data Shaping**: Customized API responses to include only requested data fields.

### 7. Performance Optimization
- **Paging and Filtering**: Implemented server-side paging and filtering for better data retrieval efficiency.
- **Caching**: Applied response and output caching to reduce server load and improve response times.

### 8. Security
- **Authentication and Authorization**: Configured JWT authentication and role-based authorization.
- **Refresh Tokens**: Implemented refresh tokens for secure and persistent user sessions.

### 9. Documentation and Deployment
- **API Documentation**: Used Swagger to document and test API endpoints.
- **Deployment**: Configured the project for deployment to IIS with proper environment settings and SSL configuration.

---

## Personal Takeaways
- Developed a deeper understanding of API architecture and design patterns.
- Improved skills in creating scalable, maintainable, and secure APIs.
- Learned how to optimize APIs for performance and user experience.

This project provided a solid foundation for building professional-grade Web APIs in ASP.NET Core.
