# InfinityNotes
An application that mimics notepad++ and some of its features

## Task
Create in C # using WPF (Windows Presentation Foundation) a similar application
with Notepad ++ (https://notepad-plus-plus.org/downloads/), with the following features:
  1. Open an empty tab to write text in it
  2. Save the contents of the tab as a text file (Save and Save As submenus)
  3. Open the contents of a text file on disk in a tab (Open submenu, with option
  default to open files with txt extension, but also with the possibility to open anything
  file)
  4. To open the directory and file structure on the disk, in tree form, in which
  directories may expand or collapse
  5. Double-click on a file in the structure to open its contents in a new tab
  6. Close an open file in a tab (if the file is not saved, then ask
  saving him)
  7. For the Find, Replace and Replace All functionalities it will be specified if it will be done
  operation only on the current file or in all open files.
  The application will have a menu bar with the following menus / submenus:

File: 
- New
- Open ...
- Save
- Save As ...
- Exit

Search: 
- Find ...
- Replace ...
- Replace All ...

Help: 
- About

A window with the student's name will appear in the About submenu, the group to which a
link to institutional email address.
Tabs that contain files in them will also display the name of the open file. If it's a document
new, then the tab name will be automatically given File 1, File 2 etc. Unsaved files will be highlighted in
name this aspect (e.g. they will have a different color name or a different marking)
