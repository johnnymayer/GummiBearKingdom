# Gummi Bear Kingdom
### A sample layout for the future Gummi Bear Kingdom site!

This is a sample layout and design for an updated version of Gummi Bear Kingdom.  It will allow guests to browse all Gummis available, and it will allow Admins to add, edit, or delete new or existing Gummis.


## Getting Started & Requirements
* Required software:
	* Browser
	* MAMP
	* Terminal interface
	* Familiarity with dotnet & git commands is not required, but helpful!

In your terminal, clone the repo from GitHub (Alternatively [Click Here](https://github.com/johnnymayer/gummibearkingdom) to download a zip directly from the repo).

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
dotnet ef migrations add Initial
```
And then update the database:

```
dotnet ef database update
```

Build the project:

```
$dotnet build
```

Launch the project to run:

```
$dotnet run
```
	 
## Specifications
* Admin will be able to create a new "Gummi" with name, price, description values.
    * Sample Input: "Gummi", 1, "A flavorful demo Gummi"
    * Expected Output: Name:"Gummi", Price: $1, Description:"A flavorful demo Gummi"

* A user should be able to click on a link on the Landing page that takes them to a page that lists all available Products.
	* If a user clicks the "View Gummis" link on the Home page, they will be redirected to a table containing all Gummis.

* A user should be able to click on each Product and see its Details.
	* If a user clicks the Gummi's name, they will be redirected to a page with details of the selected Gummi, with Name, Price, and a Description.

* An admin should be able to add and remove individual Products, as well as delete all Products.
	* Currently all CRUD functions are accessible.

	
	***Future feature proposal:***
	
	* Authentication will be added with separate routings to allow for "Admin" or "Owner" or "Guest" level access privileges.  The tiered privileges will allow for CRUD, and other functionality at top tiers, and for "read only", "purchase" functions at lower level tiers such as "Guest".
	
## Built With
* Visual Studio 2017
* C#
* ASP.NET
* Dotnet Core 1.1
* Chrome

## Author
[Johnny Mayer](https://github.com/johnnymayer)

## License
This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

## Acknowledgements
* [Barista Coffee](http://www.baristapdx.com)
	* For keeping the caffeine pumping!
* [Microsoft Developer Network](https://msdn.microsoft.com/en-us/)
	* For every question anyone could ever have about navigating Visual Studio (be it via Mac OS X or Windows), how to get x, y, or z done, or any other vast amount of knowledge accessible through the infinite archives and lessons MSDN has to offer.
* [Dieselboy - System Upgrade Mixtape](https://www.youtube.com/watch?v=4SIdbXP3JNA&t=3018s)
	* High energy tunes for some high energy coding, a must.
