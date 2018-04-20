# Gummi Bear Kingdom
## A sample layout for your future site!

This is a sample layout and design for an updated version of Gummi Bear Kingdom.


## Getting Started & Requirements
* Required software:
	* Browser
	* MAMP
	* Terminal interface
	* Familiarity with dotnet & git commands is not required, but helpful!

* In your terminal, clone the repo from GitHub (Alternatively [Click Here](https://github.com/johnnymayer/gummibearkingdom) to download a zip directly from the repo).

```
$git clone https://github.com/johnnymayer/gummibearkingdom
```

Navigate to the cloned directory:

```
$cd gummibearkingdom
```

Navigate to the GummiBearKingdom directory:

```
$cd GummiBearKingdom
```

Run a dotnet restore to restore files post download:

```
dotnet restore
```

Start your MAMP servers, making sure the MySQL port is set to 8889.
Create Database via dotnet migrations:

```
dotnet ef database update
```
	 
## Specifications
* Admin will be able to create a new "Gummi" with name, price, description values.
    * Sample Input: "Gummi", 1, "A flavorful demo Gummi"
    * Expected Output: Name:"Gummi", Price: $1, Description:"A flavorful demo Gummi"

* A user should be able to click on a link on the Landing page that takes them to a page that lists all available Products.

* A user should be able to click on each Product and see its Details.

* An admin should be able to add and remove individual Products, as well as delete all Products.