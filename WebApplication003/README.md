## Using a View Start File

I still have a tiny wrinkle to sort out, which is that I have to specify the layout file I want in every view. If
I need to rename the layout file, I am going to have to find every view that refers to it and make a change,
which will be an error-prone process and counter to the general theme of easy maintenance that runs
through MVC development.
I can resolve this by using a view start file. When it renders a view, MVC will look for a file called
_ViewStart.cshtml. The contents of this file will be treated as though they were contained in the view file
itself, and I can use this feature to automatically set a value for the Layout property.
To create a view start file, right-click the Views folder, select Add ➤ New Item from the pop-up menu,
and choose the MVC View Start Page template from the ASP.NET category.

Listing 5-11. The Initial Contents of the _ViewStart.cshtml File in the Views Folder
@{
 Layout = "_Layout";
}
To apply my layout to all the views in the application, I changed the value assigned to the Layout
property, as shown in Listing 5-12.
Listing 5-12. Applying a Default View in the _ViewStart.cshtml File in the Views Folder
@{
 Layout = "_BasicLayout";
}
Since the view start file contains a value for the Layout property, I can remove the corresponding
expression from the Index.cshtml file, as shown in Listing 5-13.

Listing 5-13. Applying a View Start File in the Index.cshtml File in the Views/Home Folder
@model Product
@{
 ViewBag.Title = "Product Name";
}
Product Name: @Model.Name
I do not have to specify that I want to use the view start file. MVC will locate the file and use its contents
automatically. The values defined in the view file take precedence, which makes it easy to override the view
start file.
You can also use multiple view start files to set defaults for different parts of the application. Razor looks
for the closest view start file to the view that it being processed, which means you can override the default
setting by adding a view start file to the Views/Home or Views/Shared folders, for example.

■ Caution
[It is important to understand the difference between omitting the Layout property from the view
file and setting it to null. If your view is self-contained and you do not want to use a layout, then set the Layout
property to null. If you omit the Layout property, then MVC will assume that you do want a layout and that it
should use the value it finds in the view start file.]

*[Source : ASP.net MVC 2 (BOOK)]