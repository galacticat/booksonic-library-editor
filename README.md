# Booksonic Library Editor
### Current Release: [Version 1.0.0](https://github.com/galacticat/booksonic-library-editor/tree/master/Booksonic%20Setup/Release)
![picture alt](https://github.com/galacticat/booksonic-library-editor/blob/master/Booksonic%20Library%20Editor.png)

Instructions:
1. Download both the .exe and .msi and run the .exe to install.
2. Use the Configuration button to select the root location of your Booksonic library.

### Expected Directory Structure
    .
    Author
    ├── Book Series
    	├── Boook

### Release Notes [Version 1.0.0](https://github.com/galacticat/booksonic-library-editor/tree/master/Booksonic%20Setup/Release):
* Configure Button: Allows user to select the root location for their audiobook library
* Refresh Button: Reloads the directory tree from the set Library Path
* Search (Hotkey: Enter): Allows users to enter the name of a book or author and search for the tree node.
* Expand All: Expands all nodes in the tree, but will leave the previous selected node selected
* collapse All: Collapses all ndoes in the tree, but will leave the previous selected node selected
* Prev Book (Hotkey: Page Up): Selects the previous lowest visible sub node. Intended to easily navigate visible books in the tree.
* Next Book (Hotkey: Page Down): Selects the next lowest visible sub node. Intended to easily navigate visible books in the tree.
* Book: Displays the selected books name if it is the bottom of the tree.
* Narrator: Reads the conent of the reader.txt file in the selected directory
* Book Synopsis: Reads the content of the desc.txt file in the selected directory
* Save (Hotkey: Ctrl+S): Saves the content of the Narrator field to the reader.txt file in the selected directory, and saves the content of the Book Synopsis to the desc.txt file in the selected directory.
>NOTE: The Narrator, Book Synopsis, and Save button are only enabled if the lowest node is selected (it assumes the last node is where your audio files are).
* Open Location: Opens the selected directory
* Book Path: Shows the directory path of the selected node.
