# _Vendor and Order Tracker_

#### _.NET 5 MVC Order Intake Program using TDD_

#### By _**Carlos Mendez**_

## Technologies Used

* C#
* .NET 5
* MS Test

## Description

_This project demonstrates a successful use of TDD, C# and the MVC pattern using .NET 5.  The app welcomes the user and allows them view and add vendors and also view and add orders to those vendors. It includes an Order class and Vendor class and views, controllers, and tests for both._


## Setup and Use

### Prerequisites
* [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
* A text editor like [VS Code](https://code.visualstudio.com/)
* A web browser to run and interact with the web app.

### Installation
1. Clone the repository: `$ git clone https://github.com/yesthecarlos/VOTracker.Solution`
2. Navigate to the `VOTracker.Solution/` directory on your computer
3. Open with your preferred text editor to view the code base
4. To run the web app:
    * Navigate to `VOTracker.Solution/VOTracker` in your command line
    * Run the command `dotnet restore` to restore the dependencies that are listed in the .csproj
    * Run the commmand `dotnet build` to build the project and its dependencies into a set of binaries
    * Run the command `dotnet run` to run the project
    * Finally, open the project in your web browser, using the specified address (default is localhost:5000)
    * Note: `dotnet run` also restores and builds the project, so you can use this single command to start the web app.

5. To run tests:
    * Navigate to `VOTracker.Solution/VOTracker.Tests` in your command line.
    * Run the command `dotnet restore` to restore the dependencies that are listed in the .csproj
    * Finally, run the command `dotnet test` to run the tests!

## Specs
 
### OrderTests
```c#
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test description");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    public void GetDescription_ReturnsDescription_string()
    {
      string description = "test description";
      Order newOrder = new Order(description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    public void SetDescription_SetDescription_String()
    {
      string description = "test description";
      Order newOrder = new Order(description);

      string updatedDescription = "updated test description";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    public void GetAll_ReturnsOrders_OrderList()
    {
      string description01 = "#1 Burger Place in town";
      string description02 = "#1 Sandwich Place in town";
      Order newOrder1 = new Order(description01);
      Order newOrder2 = new Order(description02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
```
### PastryTests
```c#   
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    public void GetName_ReturnsName_string()
    {
      string name = "Major's";
      string description = "burger place";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    public void SetDescription_SetDescription_String()
    {
      string name = "Major's";
      string description = "burger place";
      Vendor newVendor = new Vendor(name, description);

      string updatedDescription = "#1 Burger Place in town";
      newVendor.Description = updatedDescription;
      string result = newVendor.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    public void GetAll_ReturnsVendors_VendorList()
    {
      string name01 = "Major's";
      string description01 = "#1 Burger Place in town";
      string name02 = "Essencia";
      string description02 = "#1 Sandwich Place in town";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
```
## Feature Plans

* _Adding a database to the backend will allow the user to make changes that persist._

## License

_Copyright 2021 Carlos Mendez_

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

_

## Contact Information

_carlosmendez86@gmail.com_