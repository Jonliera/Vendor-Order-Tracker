using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
   [TestClass]
    public class OrderTests 
   {

  //    public void Dispose()
  //   {
  //     Order.ClearAll();
  //   }

     [TestMethod]
      public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test","orderTest",100,12-01-22);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

//     [TestMethod]
//     public void GetDescription_ReturnsDescription_String()
//     {
//       //Arrange
//       string description = "Walk the dog.";
//       Item newItem = new Item(description);

//       //Act
//       string result = newItem.Description;

//       //Assert
//       Assert.AreEqual(description, result);
//     }

//     [TestMethod]
//     public void SetDescription_SetDescription_String()
//     {
//       //Arrange
//       string description = "walk the dog";
//       Item newItem = new Item(description);

//       //Act
//       string updatedDescription = "Do the dishes";
//       newItem.Description = updatedDescription;
//       string result = newItem.Description;

//       //Assert
//       Assert.AreEqual(updatedDescription, result);
//     }

//     [TestMethod]
//     public void GetAll_ReturnsEmptyList_ItemList()
//     {
//       // Arrange
//       List<Item> newList = new List<Item> { };

//       // Act
//       List<Item> result = Item.GetAll();

//       // Assert
//       CollectionAssert.AreEqual(newList, result);
//     }

//     [TestMethod]
//     public void GetAll_ReturnsItems_ItemsList()
//     {
//       //Arrange
//       string description01 = "Walk the dog";
//       string description02 = "Wash the dishes";
//       Item newItem1 = new Item(description01);
//       Item newItem2 = new Item(description02);
//       List<Item> newList = new List<Item> { newItem1, newItem2 };

//       //Act
//       List<Item> result = Item.GetAll();

//       //Assert
//       CollectionAssert.AreEqual(newList, result);
//     }
//     [TestMethod]
//   public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
//   {
//     //Arrange
//     string description = "Walk the dog.";
//     Item newItem = new Item(description);

//     //Act
//     int result = newItem.Id;

//     //Assert
//     Assert.AreEqual(1, result);
//   }
//   [TestMethod]
//   public void Find_ReturnsCorrectItem_Item()
//   {
//     //Arrange
//     string description01 = "Walk the dog";
//     string description02 = "Wash the dishes";
//     Item newItem1 = new Item(description01);
//     Item newItem2 = new Item(description02);

//     //Act
//     Item result = Item.Find(2);

//     //Assert
//     Assert.AreEqual(newItem2, result);
//   }
//   }
// }using Microsoft.VisualStudio.TestTools.UnitTesting;
// using VendorOrder.Models;
// using System.Collections.Generic;
// using System;

// namespace VendorOrder.Tests
// {
//   [TestClass]
//   public class ItemTests : IDisposable
//   {

//     public void Dispose()
//     {
//       Item.ClearAll();
//     }

//     [TestMethod]
//     public void ItemConstructor_CreatesInstanceOfItem_Item()
//     {
//       Item newItem = new Item("test");
//       Assert.AreEqual(typeof(Item), newItem.GetType());
    }
}