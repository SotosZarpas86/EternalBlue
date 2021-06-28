# EternalBlue

The application is implemented using Blazor WebAssembly, in .NET 5 framework
(In order to run the application, please be sure you have installed the above framework)

The high-level logic behind the implementation is the following:

	1. A new razor component has been created, containing all three(3) pages
	2. Based on which pages the user is, the html of the other two(2) is hidden
	3. Blazored/SessionStorage package is used to handle session management.
