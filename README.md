# Fawry OOP Solution

![Language](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Framework](https://img.shields.io/badge/Framework-.NET%209-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)

An OOP shopping cart system demonstrating product type hierarchy.

## Features
- Digital products, expirable+shippable products, and non-expirable shippable products
- Checkout and customer balance management

## Tech Stack
| Technology | Description |
|---|---|
| C# | Programming Language |
| .NET 9 | Framework |

## Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/OmarAlfar0uk/Fawry_OOP_Solution.git
   ```
2. Build the project:
   ```bash
   dotnet build
   ```
3. Run the application:
   ```bash
   dotnet run
   ```

## Project Structure
- `Product.cs`: Base product class
- `DigitalProduct.cs`, `ExpirableShippableProduct.cs`, `NonExpirableShippableProduct.cs`: Product types
- `IShippable.cs`: Interface for shippable items
- `Cart.cs`, `CartItem.cs`: Shopping cart logic
- `Customer.cs`: Customer data and balance
- `Program.cs`: Application entry point

## Author
- GitHub: [OmarAlfar0uk](https://github.com/OmarAlfar0uk)
- LinkedIn: [omar-alfarouk-252471251](https://www.linkedin.com/in/omar-alfarouk-252471251/)
- Email: omaralfarouk646@gmail.com
