using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillSplitter
{
    class CalculateExpense
    {
        private IList<Group> allGroups = new List<Group>();
        public CalculateExpense(string filePath)
        {           
            ParseLines(filePath);
            ExpenseDistribute(filePath);
        }
        private void ParseLines(string filePath)
        {
            int totalFriends = 0;
            int participants = 0;
            List<decimal> expenseList = new List<decimal>();
            StreamReader sr = new StreamReader(filePath);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains("."))
                {
                    participants++;
                    expenseList.Add(Convert.ToDecimal(line));
                }
                else if (participants == 0)
                {
                    if (Convert.ToInt16(line) >= totalFriends) totalFriends = Convert.ToInt16(line);
                }
                else
                {
                    //Console.WriteLine("Group: " + totalFriends);
                    //Console.WriteLine("Participants: " + participants);
                    Group group = new Group(totalFriends);
                    for (var i = 0; i < totalFriends; i++)
                    {
                        if (i < expenseList.Count)
                        {
                            //Console.WriteLine("dollar: " + expenseList[i]);
                            group.Friends.Add(new Friends(i + 1, expenseList[i]));
                        }
                        else
                        {
                            //Console.WriteLine("dollar: " + 0);
                            group.Friends.Add(new Friends(i + 1, 0));
                        }
                    }
                    allGroups.Add(group);
                    totalFriends = 0;
                    participants = 0;
                    expenseList.Clear();
                    if (Convert.ToInt16(line) >= totalFriends) totalFriends = Convert.ToInt16(line);
                }
            }
        }
        private void ExpenseDistribute(string filePath)
        {
            // save the output in same location as input file
            using (StreamWriter outfile = new StreamWriter(filePath + ".out"))
            {
                foreach (var group in allGroups)
                {
                    foreach (var friend in group.Friends)
                    {
                        var amount = group.DividePerFriend(friend.Friend);
                        if (amount > 0) outfile.WriteLine(amount.ToString("$#,##0.00"));
                        else outfile.WriteLine(amount.ToString("$#,##0.00;($#,##0.00)"));
                    }
                    outfile.WriteLine();
                }
            }            
        }
    }
}
