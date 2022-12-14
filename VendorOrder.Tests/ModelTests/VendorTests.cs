using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests 
{
  [TestClass]
  public class VendorTests : IDisposable 
  {

  public void Dispose()
  {
    Vendor.ClearAll();
  }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Sinclair","C-Store");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    } 
  [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Vendor";
      string description = "Test Description";
      Vendor newVendor = new Vendor(name, description);

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
     }
     [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string name = "Test Vendor";
      string description = "Test Description";
      Vendor newVendor = new Vendor(name, description);

      //Act
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(description, result);
     }
    [TestMethod]
  public void GetId_ReturnsVendorId_Int()
  {
    //Arrange
    string name = "Test Vendor";
    string description = "Test Description";
    Vendor newVendor = new Vendor(name,description);

    //Act
    int result = newVendor.Id;

    //Assert
    Assert.AreEqual(1, result);
   }
  [TestMethod]
  public void GetAll_ReturnsAllVendorObjects_VendorList()
  {
    //Arrange
    string name01 = "Sinclair";
    string description01 = "C-store";
    string name02 = "Jhon's";
    string description02 = "Spices Store";
    Vendor newVendor1 = new Vendor(name01, description01);
    Vendor newVendor2 = new Vendor(name02,description02);
    List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

    //Act
    List<Vendor> result = Vendor.GetAll();

    //Assert
    CollectionAssert.AreEqual(newList, result);
  }
  [TestMethod]
  public void Find_ReturnsCorrectVendor_Vendor()
  {
    //Arrange
    string name01 = "Sinclair";
    string description01 = "C-store";
    string name02 = "Jhon's";
    string description02 = "Spices Store";
    Vendor newVendor1 = new Vendor(name01, description01);
    Vendor newVendor2 = new Vendor(name02, description02);

    //Act
    Vendor result = Vendor.Find(2);

    //Assert
    Assert.AreEqual(newVendor2, result);
   }
   [TestMethod]
  public void AddOrder_AssociatesOrderWithVendor_OrderList()
  {
    //Arrange
    string title = "Dough";
    string description = "5lb Empanadas dough";
    int price = 50;
    string date = "12-10-22"; 
    Order newOrder = new Order(title, description, price, date);
    List<Order> newList = new List<Order>  { newOrder };
    string name = "Jhon's";
    string vendorDescription = "Dough Shop";
    Vendor newVendor = new Vendor (name, vendorDescription);
    newVendor.AddOrder(newOrder);

    //Act
    List<Order> result = newVendor.Orders;

    //Assert
    CollectionAssert.AreEqual(newList, result);
   }
  }
}