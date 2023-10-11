## Vendor and Order Tracker

#### A web application that allows a user (Pierre) to keep track of vendors that purchase his baked goods, and the orders belonging to those vendors.

#### By Brian Scherner

## Technologies Used

* C#
* .NET
* ASP.NET MVC

## Description

Pierre runs a bakery and is expanding his business operations. This application presents Pierre with a Home page with an introduction to the application. It contains a link labeled as `Vendors` that presents Pierre with an empty vendor list. Here, Pierre can select a link that takes him to a page where he can fill out a form to create a new vendor. After the form is submitted, the vendor is saved into the list. Pierre can then select the vendor's name and go to a page that displays a list of that vendor's orders.

Pierre can then select a link where he can fill out a form to create a new order for that specific vendor. After this form is submitted, the order is saved into the list for that vendor. He can select each order to view the details for that specific order. If Pierre wishes, he can also navigate to the page listing all of the vendors and clear the list by selecting the `Clear Vendor List` button.

## Setup Instructions

1. Select the green button that says `Code`, and clone this repository to your desktop.
2. Open your terminal and navigate to this project's test directory called `VendorAndOrderTracker.Tests`.
3. To run tests for the `Vendor` and `Order` classes, run the command `dotnet test` to test the classes.
4. To launch the project in development mode with a watcher, navigate to the production directory called `VendorAndOrderTracker` and run the command `dotnet watch run`.


## Known Bugs

Application is functioning fully as intended.

## License

MIT

Copyright(c) 2023 Brian Scherner