using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillSplitter
{
    public class Group
    {
        public int TotalFriends { get; private set; }
        public IList<Friends> Friends { get; set; }

        public Group(int totalFriends)
        {
            TotalFriends = totalFriends;
            Friends = new List<Friends>();
        }

        public decimal TotalExpense()
        {
            return Friends.Sum(item => item.Amount);
        }
        private decimal AverageExpense()
        {
            return TotalExpense() / TotalFriends;
        }
        private decimal ExpensePerFriend(int friend)
        {
            return Friends.Where(item => item.Friend == friend).Sum(item => item.Amount);
        }
        public decimal DividePerFriend(int friend)
        {
            return decimal.Round(AverageExpense() - ExpensePerFriend(friend), 2);
        }
    }
}
