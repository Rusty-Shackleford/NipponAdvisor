# NipponBuddy

Let's face it: The fun to be found in Kairosoft games is *figuring out how to play it*.  They'll hide a lot of vital information you need to make basic decisions, and then you've either got to discover the rules by trail and error or look up the details in someone's guide. 

NipponBuddy is a small application for Windows that I am writing while playing Cafe Nippon. Basically, part of the fun I'm having while playing this is was writing code to make the game better for myself. 


### Update 58/17/2019
So I've more or less finished with the game itself for now, so motivation to complete this tool is fairly low because it will be of little use to me - but on the other hand I really dislike leaving projects unfinished.  Chances are I will come back in the next 3 months or so and finish this up.  It's nearly done, just a couple UI tweaks and a couple of functions for the ingredient recommendations.


## Installation

For now, you'll have to build the project in Visual Studio.

```
git clone https://github.com/Rusty-Shackleford/NipponAdvisor

Open NipponAdvisor.sln in Visual Studio

<kbd>F5</kbd> build / run the application.

```

Once the project is completed, an executible installer will be hosted on this GitHub project.


## Features
- It's going to recommend... which ingredients to use... ya this is WAY over-kill.  
- Also, I wanted to play around with a "Dark" Custom User Control theme for WinForms, so far I really like it, though it has a couple of quirks that were tricky to get through.

## Screenshots?

Here's an early screenshot, most of the controls are working at this point.
![MainScreen](https://raw.githubusercontent.com/Rusty-Shackleford/NipponAdvisor/master/screenshots/MainScreen.png)
![Dialog](https://raw.githubusercontent.com/Rusty-Shackleford/NipponAdvisor/master/screenshots/DishSelect.png)


## Acknowledgements

- [Seebs' Ingredient Calculator for Cafe Nippon](http://www.seebs.net/ingredients.html) for the inspiration, and let's be honest, the ingredient data in JavaScript
- [Happy Enna](http://happyenna.blogspot.com/p/cafe-nippon.html) for her amazing content on Cafe Nippon, and her generally awesome and happy style.
- [DarkUI](https://github.com/RobinPerris/DarkUI) - a very nice Dark themed control and docking library for .NET WinForms.

## License
[MIT](https://choosealicense.com/licenses/mit/)
