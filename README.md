# SplittingBill

## Input
The program reads a text file which contain the information for several camping trips. The information for each trip consists of a line containing a positive integer, n, the number of peopling participating in the camping trip, followed by n groups of inputs, one for each camping participant.  Each groups consists of a line containing a positive integer, p, the number of receipts/charges for that participant, followed by p lines of input, each containing the amount, in dollars and cents, for each charge by that camping participant.  A single line containing 0 follows the information for the last camping trip.

## Output
For each camping trip, the program will output one line per participant indicating how much he/she must pay or be paid rounded to the nearest cent.  If the participant owes money to the group, then the amount is positive.  If the participant should collect money from the group, then the amount is negative.  Negative amounts should be denoted by enclosing the amount in brackets.  Each trip are separated by a blank line.

## Example Input
3
2
10.00
20.00
4
15.00
15.01
3.00
3.01
3
5.00
9.00
4.00
2
2
8.00
6.00
2
9.20
6.75
0

## Output for Example Input
($1.99)
($8.01)
$10.01

$0.98
($0.98)
