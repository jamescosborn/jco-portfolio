# James Carl Osborn's Technical Portfolio

A website providing information about myself, James Carl Osborn. For your convenience, the portfolio has been divided into the following parts:

* Work experience
* Relevant skills
* Education
* How I got into coding
* Contact information
* My top projects (top 3 starred GitHub repos)

## Getting Started

To start the website, you'll need the following:

* A command prompt (Terminal or GitBash recommended)
* A web browser (Chrome recommended)
* A local server environment (MAMP recommended)

### Installation Steps

1. In your command prompt, enter:  
  `git clone https://github.com/jamescosborn/jco-portfolio.git`
2. Start your SQL server on MAMP.
3. Navigate to the folder with the .csproj in it and enter: `dotnet ef migrations add CodeReview`    
followed by:  
`dotnet ef database update  `
4. Enter:  `dotnet run`
5. In a web browser, navigate to http://localhost:5000 (if the command prompt displays a different local host number, enter that one)

### Technologies Used

GitBash  
GitHub   
GitHub API  
Atom   
C#  
.NET Core (v1.1)  
Visual Studio 2017  

## Scheduled Updates

* Build it

Anything else?

## Known Bugs

* On my machine, you need to force quit the dotnet process in task manager every time you close the app.  
* Style sheet master.css is not being applied.

## Contributors

James Carl Osborn
jamescarlosborn@gmail.com  

## Project Specs

| Description        | Input           | Output  |
| ------------- |:-------------:| -----:|
| User is greeted with a landing page, where they see __a picture__       | localhost:5000       | User sees landing page    |
| User can navigate to a blog section with a collection of __blog posts__       | Clicks "Blogs"       | User is shown all blog posts    |
| Clicking on a blog post, the user will see all the blog's specific __comments__       | Clicks "Post A"       | User sees all comments of "Post A"    |
| User is able to log on/off as an administrator | Clicks "Admin" | User is logged in if they have the credentials |
| Only admins can Create, Read, Update, Delete posts | Create a new blog post | Blog post is added to list |
| Only admins are able to remove Comments | Remove comment from blog post | Comment no longer appears on post |
| Projects section displays the top 3 starred GitHub repos | Clicks "Projects" | The top 3 starred GitHub repos for JCO are displayed  |

## Technical Specs
-Ajax required for GET methods on Post CRUD

## Developer Notes  
For info on API calls to starred repos:   
-https://developer.github.com/v3/activity/starring/  

For info on API call parameters:  
-https://developer.github.com/v3/#parameters  

## License

This project is licensed under the MIT License.

## Acknowledgments

Thank you to my teachers, fellow students, friends, family and pets for your continued support and inspiration.  

:shipit:
