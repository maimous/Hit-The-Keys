# Hit The Keys!
[Head First C#](http://www.headfirstlabs.com/books//hfcsharp/)

&nbsp;
## 00 Start the project
* In VS, create a Windows Forms Application project.

&nbsp;
## 01 Configure the form
* Set name, text, icon etc.
* Turn off the minimize box and maximize box. Then set the form’s FormBorderStyle
property to Fixed3D. That way, the player won’t be able to accidentally drag and resize it.
Then resize it so that it’s much wider than it is tall (we set our form’s size to 876, 174).
* Drag a ListBox out of  the toolbox onto the form. Set its Dock property to Fill, and its
MultiColumn property to True. Set its Font to 72 point bold.
* Add a Timer control and a StatusStrip control.

&nbsp;
## 02 Configure the StatusStrip control
* Add a StatusLabel to your StatusStrip by clicking its drop-down and selecting StatusLabel.
* Use the Properties window to set its (Name) to correctLabel and its Text to “Correct: 0”. Add three more StatusLabels: missedLabel, totalLabel, and accuracyLabel, and set their Text properties to
“Missed: 0”, “Total: 0”, and “Accuracy: 0%”.
* Add one more StatusLabel. Set its Spring to True, TextAlign to MiddleRight, and Text to “Difficulty”. Finally, add a ProgressBar and name it difficultyProgressBar.
* Set the StatusStrip’s SizingGrip property to False (hit Escape if  you’ve got a child StatusLabel or ProgressBar selected to return the IDE’s focus to the parent StatusStrip).

&nbsp;
## 03 Configure the Timer control
* Set the Timer control’s Interval property to 800, so that it calls its method every 800 milliseconds.
* Set the Timer control’s Enabled property to True. This way the Timer starts ticking automatically and there is no need to call the Start() method of the Timer class in the project code.
* Add the code for the Timer. Random capital letters are appearing in the ListBox. When they are more than seven, the game ends.

&nbsp;
## 04 Add the Stats class
* Add a class called Stats to your project.
* It’ll have four int fields called Total, Missed, Correct, and Accuracy, and a method called Update with one bool parameter: true if  the player typed a correct letter that was in the ListBox, or false if  the player missed one.
* We need an instance of the new Stats class to actually store the information, so add a field to the top of the form, called stats.
