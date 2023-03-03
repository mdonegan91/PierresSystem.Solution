# 🇫🇷 Pierre's Bakery 🇫🇷

#### By Molly Donegan

## ☕ Technologies Used ☕

* C# 
* .NET 6.0 
* dotnet script REPL 

## 🥐 Description 🥐
A web application that allows Pierre to track the vendors that purchase baked goods from him and the orders belonging to those vendors.

## ☕ Setup Instructions ☕

1. Clone this repo.
2. Install the [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
3. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "PierresBakery".
4. In the command line, run the command "dotnet run" to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal.
5. Optionally, you can run "dotnet build" to compile this console app without running it.
6. Confirm all business logic tests pass with MSTest by running commands (not including the dollar symbol):
`$ dotnet restore ./PierresBakery.Tests`
`$ dotnet test ./PierresBakery.Tests`

## 🥐 Known Bugs 🥐

Unhandled exception: If user enters anything besides a whole number when prompted to enter a number, system will throw user out of the bakery.

## ☕ License ☕
Enjoy the app! If you have questions or suggestions for fixing the code, please contact me!

MIT License Copyright (c) 2023 Molly Donegan. Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.