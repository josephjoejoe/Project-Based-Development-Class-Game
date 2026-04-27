//          SUMMARY

/*Since trying to find the exit condition is difficult with the current code(as well as making a list of pipes that are present on the board), I am going to try to rewrite MOST of the code, if not all.
Some of the code functions hold up and are not causing issues, but the lack of organization is causing for some problems to emerge.
I want to be able to organize this that way this will mitigate the chances that any problems occur later down the line. */

//          TO DO

/* The following tasks are gonna help make the code seem more organized, although the price of this is that it may seem complicated at first, but all code will be 
accompanied with comments that highlight not only their function, but my thought process and why I made that change. 
Hopefully all code and their accompanying comments will be able to answer any questions or confusions. If there are any questions or concerns outside what the comments cover
let me know in person or in discord.

- Create an inheritance structure that combines the common functions of multiple scripts in order to consolidate the amount of scripts present in a folder.
(Parent script will be responsible for dragging from the side bar and going back to the sidebar, children script will be tools, pipes,etc)
- Make a universal check script, this will get rid of unnecessary scripts that do the same thing.
- Make a new pipe dragging system that can spawn an unlimited amount of pipes(That way we can at least have enough pipes to finish the level)
(The pipe amount can be adjusted later on in script)
-Redo the sidebar system so that only one bar can be active at a time.
-Rethink the grid system and consider going to a tilemap format(This can help us maybe, not a big necessity for now.)
*/

//          CHANGE LOG

/*
        4/26/26 - Added a parent dragging script which is responsible for giving the drag function to both the tools and pipes for now. 
        The syntax is mostly the same but there is a virtual function that can be overridden to suit the need of whatever child script.
        Also added empty scripts for the Checking script and Appliance script which should respond base on the checking scripts
        (Will most likely use case switch statements to determine what happens when checking different appliances)
        Todo: Next time I need to add Two Pipe Scripts, One will be in the toolbar and be the child to the parent dragging function. 
        The other sctript will be a prefab object script which will spawn from the first script and be responsible for the checking and any other behavior in the future.

*/