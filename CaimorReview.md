# Peer Project Review

## Project Structure Rating: 3
The actual code files are organized nicely, with separate folders for `Layout` and `Pages`, and consistent file names like `Login.razor` and `MainNewLayout.razor`. However, the main folders are nested very poorly, placing the actual app deep inside a `Capacio_WriterCo` folder and then another `Project/WriterCo` folder. I had to write `cd` commands three times in the terminal just to reach the right project folder. This confusing setup makes the root repository messy and is the exact reason why the standard `dotnet run` command failed to work at first.


## Front-End Rating: 2
This project earns a 2 instead of a 1 because it successfully uses a consistent dark theme across the pages and sets up the basic foundation for the document editor. However, the overall design feels very empty, and the navigation is severely broken because the home button logo does not work on the login and register screens, leaving the user completely stuck. It is also hard to figure out what to click due to poor placement, like the cramped text boxes on the login page and the sidebar layout bugs where typing "Bookmark" cuts off the text entirel. Because the interface has these major navigation traps and unfinished elements, it cannot earn a higher score.
