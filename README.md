# logic-test

We need to encode a given text following the next rules:
The spaces should be removed. Being L the length of the text, the characters are written in a table whose rows and columns must meet the following conditions:
 
![Conditions](docs/conditions.jpg?raw=true "Conditions")
 
Example:
we the people of the united states in order to form a more perfect union etc
After removing the spaces, it is 61 characters long. So, we write it as a table with 8 rows and 8 columns:

![Table](docs/table.jpg?raw=true "Table")
 
•	Make sure that rows * columns >= L

•	If there are more than one table that satisfy these conditions, choose the one with the minimum area.

•	The result message is created by displaying the characters in a column, inserting a space, and repeating the process with all columns.

Expected result for above example:
wpuadmro elnteafn teiermee hotstoct efeiortc ptdnfeu ehsoopn oetrrei

Input sample:
cheating is not allowed
Output:
cinl hnoo egtw aiae tsld

Input sample:
the rocks
Output:
trk hos ec

# Instructions

* Install .NET SDK 6.0
* Run using  ```dotnet run```
