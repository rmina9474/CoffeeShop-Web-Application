# E-Commerce Web Application - Reina.MacCredy Shop

This repository contains an ASP.NET Core e-commerce web application built using modern web development practices. The application provides a comprehensive online shopping experience with user management, product catalog, shopping cart functionality, secure payment processing, and an admin dashboard.

## 📋 Table of Contents

- [Project Overview](#project-overview)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Project Structure](#project-structure)
- [Development Workflow](#development-workflow)
- [How to Use This Project](#how-to-use-this-project)
- [Screenshots](#screenshots)
- [Setup and Installation](#setup-and-installation)
- [Payment Gateway Integration](#payment-gateway-integration)
- [Security Features](#security-features)
- [Recent Updates](#recent-updates)
- [Known Issues](#known-issues)
- [Contributing](#contributing)
- [License](#license)

## 🔍 Project Overview

This e-commerce application is a fully functional online shop with both customer-facing features and administrative tools. It follows modern ASP.NET Core MVC architecture with repository patterns, Entity Framework Core for data access, and Identity for user authentication and authorization. The application is containerized using Docker, allowing for easy deployment and scaling.

### Key Components:

- User-friendly product browsing and shopping experience
- Secure user authentication and account management
- Shopping cart and checkout process with multiple payment options
- Integrated payment gateways (MoMo, VNPay) with proper error handling
- Secure session management and data protection
- Admin dashboard for managing products, categories, and orders
- Order management and tracking
- Containerized deployment with Docker and Docker Compose
- Integrated health checks for monitoring

## ✨ Features

### Customer Features:
- **User Registration and Authentication**: Secure sign-up, login, and account management
- **Product Browsing**: View products with details, images, and pricing
- **Product Reviews**: Read and write reviews for products
- **Shopping Cart**: Add items, update quantities, and manage the cart
- **Checkout Process**: Complete orders with shipping information
- **Order History**: View past orders and order details
- **Quick Order**: Streamlined purchasing process for popular items

### Admin Features:
- **Admin Dashboard**: Overview of store statistics and recent orders
- **Product Management**: Add, edit, and delete products
- **Category Management**: Create and manage product categories
- **Order Management**: View and process customer orders
- **Sales Analytics**: Monitor sales trends and performance

### UI/UX Improvements:
- **Modern Interface**: Enhanced design with improved user experience
- **Interactive Product Cards**: Hover effects and quick action buttons
- **Visual Feedback**: Toast notifications for cart actions
- **Animation Effects**: Subtle animations for improved user engagement
- **Quantity Controls**: Intuitive interface for adjusting quantities in multiple locations

## 🛠️ Technologies Used

- **ASP.NET Core 8.0**: Modern web framework
- **Entity Framework Core 9.0.3**: ORM for database operations
- **ASP.NET Core Identity**: User authentication and authorization
- **ASP.NET Core Data Protection**: Secure session management
- **C# 12**: Primary programming language
- **HTML/CSS/JavaScript**: Frontend development
- **CSS Custom Properties**: Variables for consistent theming
- **CSS Animations**: Keyframes for interactive effects
- **Bootstrap 5**: Responsive UI framework
- **Bootstrap Icons**: Icon library for UI elements
- **SQL Server**: Database management
- **MVC Pattern**: Architectural pattern
- **Repository Pattern**: Data access abstraction
- **Dependency Injection**: For loosely coupled design
- **Docker & Docker Compose**: Containerization and orchestration
- **Health Checks**: Application monitoring
- **MoMo Payment Gateway**: Payment processing
- **VNPay Payment Gateway**: Payment processing

## 📂 Project Structure

The application follows a standard ASP.NET Core MVC structure with additional organization for better maintainability:

```
Reina.MacCredy/
├── Areas/
│   ├── Admin/          # Admin dashboard and functionality
│   └── Identity/       # User authentication and management
├── Controllers/        # Application controllers
├── Extensions/         # Custom extensions
├── Migrations/         # Database migrations
├── Models/             # Data models
├── Repositories/       # Data access repositories
├── Views/              # UI templates
├── wwwroot/            # Static resources (CSS, JS, images)
├── Dockerfile          # Container definition for the web application
├── docker-compose.yml  # Multi-container application setup
└── Program.cs          # Application configuration and startup
```

## 🔄 Development Workflow

The development of this project followed these key steps:

1. **Project Planning and Design**:
   - Defining requirements and features
   - Database schema design
   - UI/UX planning

2. **Project Setup**:
   - Creating ASP.NET Core project
   - Adding necessary packages and dependencies
   - Setting up Entity Framework and Identity

3. **Database Implementation**:
   - Creating models
   - Setting up database context
   - Implementing migrations

4. **Repository Pattern Implementation**:
   - Creating repository interfaces
   - Implementing data access logic
   - Setting up dependency injection

5. **Feature Development**:
   - Building product catalog and browsing
   - Implementing shopping cart functionality
   - Creating checkout process
   - Developing order management
   - Building admin dashboard and tools

6. **UI Modernization**:
   - Enhancing home page design
   - Implementing interactive product cards
   - Adding visual feedback mechanisms
   - Creating streamlined ordering experience

7. **Bug Fixing and Stability**:
   - Fixing controller inheritance issues
   - Resolving CSS syntax errors
   - Implementing proper error handling
   - Adding null checks for critical objects

8. **Deployment**:
   - Configuration for production environment
   - Database migration in production
   - Final testing

## 🚀 How to Use This Project

### Customer Experience

1. **Browsing Products**
   - Visit the home page to view featured products
   - Browse products by category using the navigation menu
   - Use the search function to find specific products by name or description
   - Click on any product to view its details, pricing, and customer reviews

2. **Quick Ordering**
   - Use the dedicated "Quick Order" section on the home page for faster purchasing of popular items
   - Adjust quantities directly on product cards
   - Add items to cart with a single click
   - Receive visual confirmation through toast notifications

3. **Account Management**
   - Register for a new account by clicking on "Register" in the navigation menu
   - Log in to your existing account from the "Login" page
   - Update your profile information from the account settings
   - View your order history under "My Orders" in your account dashboard

4. **Shopping Process**
   - Add products to your cart by clicking the "Add to Cart" button on product cards or detail pages
   - Adjust quantities or remove items from your cart on the Shopping Cart page
   - Proceed to checkout by clicking the "Checkout" button
   - Fill in your shipping details and select a payment method
   - Review your order and complete the purchase
   - View the order confirmation and receipt

5. **Product Reviews**
   - Leave reviews for products you've purchased
   - Rate products on a scale of 1-5 stars
   - Read other customers' reviews to help with purchasing decisions

### Admin Experience

1. **Accessing Admin Dashboard**
   - Log in with admin credentials
   - Navigate to the Admin dashboard through the admin menu dropdown or by going to /Admin/Dashboard

2. **Managing Products**
   - View all products in the admin product management section
   - Add new products with details, pricing, and images
   - Edit existing product information
   - Delete products that are no longer available
   - Sort and filter products for easier management

3. **Category Management**
   - Create new product categories
   - Edit existing categories
   - Organize products by assigning them to appropriate categories

4. **Order Management**
   - View all customer orders in the admin order section
   - Check order details including products, quantities, and customer information
   - Track order status and update it as needed
   - Print order invoices for record-keeping

5. **Sales Analytics**
   - View sales statistics on the admin dashboard
   - Monitor monthly revenue and popular products
   - Track customer purchasing trends

### User Roles and Permissions

- **Visitors (Unauthenticated Users)**
  - Browse products and view details
  - Read product reviews
  - Register for an account or log in

- **Registered Customers**
  - All visitor capabilities
  - Add products to cart and complete purchases
  - Leave reviews for purchased products
  - View order history and track current orders

- **Administrators**
  - All customer capabilities
  - Access to the admin dashboard
  - Full product and category management
  - Order processing and management
  - User account management
  - Sales data and analytics access

## ⚙️ Setup and Installation

### Prerequisites
- .NET 9.0 SDK (for local development)
- SQL Server (or SQL Server Express) (for local development)
- Visual Studio 2022 or Visual Studio Code (for local development)
- Docker and Docker Compose (for containerized deployment)
- SSL Certificate (for secure payment processing)
- Payment Gateway API Keys (for MoMo and VNPay integration)

### Installation Steps

#### Method 1: Local Development

1. **Clone the repository**
   ```
   git clone https://github.com/yourusername/Reina.MacCredy.git
   cd Reina.MacCredy
   ```

2. **Configure environment variables**
   
   Create a `.env` file in the root directory:
   ```
   ASPNETCORE_ENVIRONMENT=Development
   ASPNETCORE_URLS=https://localhost:5001;http://localhost:5000
   
   # Database Configuration
   ConnectionStrings__DefaultConnection=Server=YOUR_SERVER;Database=ReinaMacCredyShop;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;
   
   # Session Configuration
   DataProtection__ApplicationName=Reina.MacCredy.Shop
   DataProtection__KeyLifetime=30.00:00:00
   
   # Payment Gateway Configuration
   MoMo__PartnerCode=your_partner_code
   MoMo__AccessKey=your_access_key
   MoMo__SecretKey=your_secret_key
   MoMo__ApiEndpoint=https://test-payment.momo.vn
   
   VNPay__TmnCode=your_tmn_code
   VNPay__HashSecret=your_hash_secret
   VNPay__PaymentUrl=https://sandbox.vnpayment.vn/paymentv2/vpcpay.html
   ```

3. **Update the connection string**
   
   In appsettings.json, verify the connection string matches your environment:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER;Database=ReinaMacCredyShop;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;"
     },
     "DataProtection": {
       "ApplicationName": "Reina.MacCredy.Shop",
       "KeyLifetime": "30.00:00:00"
     }
   }
   ```

4. **Apply database migrations**
   ```
   dotnet ef database update
   ```

5. **Install SSL certificate for development**
   ```
   dotnet dev-certs https --clean
   dotnet dev-certs https --trust
   ```

6. **Run the application**
   ```
   dotnet run
   ```

#### Method 2: Docker Deployment

1. **Clone the repository**
   ```
   git clone https://github.com/yourusername/Reina.MacCredy.git
   cd Reina.MacCredy
   ```

2. **Configure environment variables**
   
   Create a `.env` file as described above, but update the connection string for Docker:
   ```
   ConnectionStrings__DefaultConnection=Server=sqlserver;Database=ReinaMacCredyShop;User Id=sa;Password=NewPassword123!;TrustServerCertificate=True;
   ```

3. **Build and start the Docker containers**
   ```
   docker-compose build
   docker-compose up -d
   ```

4. **Access the application**
   - Web Application: https://localhost:8443 (HTTPS)
   - Web Application: http://localhost:8080 (HTTP)
   - SQL Server: localhost:1499
     - Username: sa
     - Password: NewPassword123!
     - Database: ReinaMacCredyShop

5. **Docker management commands**
   ```
   # View container status
   docker-compose ps
   
   # View logs
   docker-compose logs webapp
   docker-compose logs sqlserver
   
   # View logs in real-time
   docker-compose logs -f
   
   # Stop the containers
   docker-compose down
   
   # Restart after making changes
   docker-compose build --no-cache
   docker-compose up -d
   ```

### Payment Gateway Setup

1. **MoMo Configuration**
   - Register for a MoMo Merchant account
   - Obtain your Partner Code, Access Key, and Secret Key
   - Configure the callback URL in your MoMo merchant portal
   - Update the `.env` file with your credentials

2. **VNPay Configuration**
   - Register for a VNPay Merchant account
   - Obtain your TMN Code and Hash Secret
   - Configure the callback URL in your VNPay merchant portal
   - Update the `.env` file with your credentials

### Security Configuration

1. **Session Security**
   - Configure Data Protection keys persistence:
   ```csharp
   services.AddDataProtection()
       .SetApplicationName("Reina.MacCredy.Shop")
       .SetDefaultKeyLifetime(TimeSpan.FromDays(30));
   ```

2. **Cookie Security**
   - Configure secure session cookies:
   ```csharp
   services.AddSession(options =>
   {
       options.Cookie.Name = ".Reina.MacCredy.Session";
       options.Cookie.HttpOnly = true;
       options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
       options.Cookie.SameSite = SameSiteMode.Strict;
   });
   ```

## 🆕 Recent Updates

### Security Enhancements
- Added data protection with application name and lifetime configuration
- Implemented secure session cookies with proper protection
- Added explicit route attributes for payment callbacks
- Enhanced payment gateway integration with proper error handling
- Improved payment verification and cancellation flows

### Payment Processing
- Integrated MoMo payment gateway with proper cancellation handling
- Added VNPay payment gateway support
- Implemented comprehensive payment error handling
- Added proper route configuration for payment callbacks

### UI/UX Improvements
- Enhanced profile page design
- Improved avatar management
- Added service cards
- Enhanced form layouts with better validation
- Added interactive animations and feedback
- Improved product cards with quick actions

### Price Formatting
- Standardized all price displays to VND format throughout the application

### Navigation
- Simplified by removing redundant order button from navigation bar

### Order History
- Added missing view to fix order history display issues

### Payment Flow
- Enhanced payment gateway integration with improved cancellation handling and error messages

### Session Security
- Implemented data protection with explicit application name and key lifetime settings

### Cookie Configuration
- Updated session cookies with secure settings and proper timeout values

### Routing
- Added explicit route attributes for payment callbacks and MapControllers() for proper registration

### Validation
- Improved email validation in checkout form

### Code Quality
- Cleaned up trailing whitespace and fixed syntax errors

### UI Styling
- Enhanced button hover states and animations

### Source Control
- Added comprehensive .gitignore configuration for .NET Core projects

## ⚠️ Known Issues
- Some views require additional null checking
- Database migrations need careful management
- Search performance optimization needed
- Mobile UI improvements for admin pages
- Payment gateway error handling expansion needed
- Additional session security measures planned

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## 📝 License

This project is licensed under the MIT License - see the LICENSE file for details.

---

Developed by Reina MacCredy © 2025