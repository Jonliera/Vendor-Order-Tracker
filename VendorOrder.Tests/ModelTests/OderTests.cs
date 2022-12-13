using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
   [TestClass]
    public class OrderTests : IDisposable
   {

     public void Dispose()
    {
      Order.ClearAll();
    }

     [TestMethod]
      public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test","orderTest",100,12-01-22);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Dough";
      string description = "5lb Empanadas dough";
      int price = 50;
      int date = 12-10-22;
    
      //Act
      Order newOrder = new Order(title,description,price,date);
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string title = "Dough";
      string description = "5lb Empanadas dough";
      int price = 50;
      int date = 12-10-22;
    
      //Act
      Order newOrder = new Order(title,description,price,date);
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      //Arrange
      string title = "Dough";
      string description = "5lb Empanadas dough";
      int price = 50;
      int date = 12-10-22;
    
      //Act
      Order newOrder = new Order(title,description,price,date);
      int result = newOrder.Price;

      //Assert
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void GetDate_ReturnsDate_Int()
    {
      //Arrange
      string title = "Dough";
      string description = "5lb Empanadas dough";
      int price = 50;
      int date = 12-10-22;
    
      //Act
      Order newOrder = new Order(title,description,price,date);
      int result = newOrder.Date;

      //Assert
      Assert.AreEqual(date, result);
    }
    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "Dough";
      string description = "5lb Empanadas dough";
      int price = 50;
      int date = 12-10-22;
      Order newOrder = new Order(title,description,price,date);
      
      //Act
      string updatedTitle = "Sour Dough";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(updatedTitle, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string title = "Dough";
      string description = "5lb Empanadas dough";
      int price = 50;
      int date = 12-10-22;
      Order newOrder = new Order(title,description,price,date);
      
      //Act
      string updatedDescription = "10lb Pizza dough";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]
    public void SetPrice_SetPrice_Int()
    {
      //Arrange
      string title = "Dough";
      string description = "5lb Empanadas dough";
      int price = 50;
      int date = 12-10-22;
      Order newOrder = new Order(title,description,price,date);
      
      //Act
      int updatedPrice = 100;
      newOrder.Price = updatedPrice;
      int result = newOrder.Price;

      //Assert
      Assert.AreEqual(updatedPrice, result);
    }
    [TestMethod]
    public void SetDate_SetDate_Int()
    {
      //Arrange
      string title = "Dough";
      string description = "5lb Empanadas dough";
      int price = 50;
      int date = 12-10-22;
      Order newOrder = new Order(title,description,price,date);
      
      //Act
      int updatedDate = 12-22-22;
      newOrder.Date = updatedDate;
      int result = newOrder.Date;

      //Assert
      Assert.AreEqual(updatedDate, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      // Arrange
      string title01 = "Dough";
      string description01 = "5lb Empanadas dough";
      int price01 = 50;
      int date01 = 12-10-22;
      string title02 = "Pizza Dough";
      string description02 = "5lb Pizza dough";
      int price02 = 30;
      int date02 = 12-12-22;
      Order newOrder1 = new Order(title01,description01,price01,date01);
      Order newOrder2 = new Order(title02,description02,price02,date02);
      
      List<Order> newList = new List<Order> {newOrder1, newOrder2 };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
  public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
  {
    //Arrange
    string title = "Dough";
      string description = "5lb Empanadas dough";
      int price = 50;
      int date = 12-10-22;
      Order newOrder = new Order(title,description,price,date);

    //Act
    int result = newOrder.Id;

    //Assert
    Assert.AreEqual(1, result);
  }
  [TestMethod]
  public void Find_ReturnsCorrectOrder_Order()
  {
    //Arrange
      string title01 = "Dough";
      string description01 = "5lb Empanadas dough";
      int price01 = 50;
      int date01 = 12-10-22;
      string title02 = "Pizza Dough";
      string description02 = "5lb Pizza dough";
      int price02 = 30;
      int date02 = 12-12-22;
      Order newOrder1 = new Order(title01,description01,price01,date01);
      Order newOrder2 = new Order(title02,description02,price02,date02);

    //Act
    Order result = Order.Find(2);

    //Assert
    Assert.AreEqual(newOrder2, result);
  }
}
}