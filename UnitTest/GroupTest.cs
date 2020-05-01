using System;
using BillSplitter;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTest
{
    [TestClass]
    public class GroupTest
    {
        [TestMethod]
        public void TotalExpenseTest()
        {
            Group group = new Group(3);
            group.Friends.Add(new Friends(1, 15.01m));
            group.Friends.Add(new Friends(1, 3.00m));
            group.Friends.Add(new Friends(1, 5.00m));

            //test
            Assert.AreEqual(group.TotalFriends, 3);
            Assert.AreEqual(group.TotalExpense(), 23.01m);
        }
        [TestMethod]
        public void DividePerFriendTest()
        {
            Group group = new Group(2);
            group.Friends.Add(new Friends(1, 8.00m));
            group.Friends.Add(new Friends(1, 7.01m));
            group.Friends.Add(new Friends(2, 3.00m));
            group.Friends.Add(new Friends(2, 5.00m));

            //test
            Assert.AreEqual(group.TotalFriends, 2);
            Assert.AreEqual(group.DividePerFriend(1), -3.50m);
            Assert.AreEqual(group.DividePerFriend(2), 3.50m);
        }
    }
}
