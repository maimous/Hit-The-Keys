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
