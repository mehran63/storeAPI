﻿# Store eCommerce API 

This project demonstrates using ASP.NET Core API basic functionality for a store eCommerce Restful API application.

## How to Run

Open the solution in Visual Studio 2019 and press F5, to run the tests including unit tests and integration tests use Visual Studio test explorer.

## Basic UI

Run the app and then browse the root address ```https://localhost:44361``` to see basic UI generated by Swagger UI.

## Authorization
Instruction to add required authorization header:
1. Post the following content to ````https://localhost:44361/api/auth```` and copy the token from the response.
````json
{
  "username": "Test",
  "password": "Not for production use, DEMO ONLY!"
}
````
2. Open  the root address ```https://localhost:44361``` and click on ````Authorize```` button on the left-top corner and enter 'Bearer __token__', replace __token__ with the copied token from the previous step.
3. Click ````Authorize````. You should be able to access all the APIs listed under ```Products``` now.
