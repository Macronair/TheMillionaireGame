# (Bulk) Exporting and Importing questions
## Intro
This tutorial explains how to export and import questions between databases.
For example, it can be useful if you want to transfer all the questions from a local database server to a server on another computer without manually inserting all the questions again.

## Export from Database to CSV

To export, follow the steps below...
- Open the Question Editor:
	- This is possible via The Millionaire Game app: *Game > Questions Editor*
	- Or open the QEDIT.exe file directly to open the Editor.
- In the menu bar, click on 'Actions' > 'Export Questions' > 'To CSV...'

  ![Schermafbeelding 2024-11-04 222557](https://github.com/user-attachments/assets/965fff9a-06b6-48cb-b696-8b5bb9ff1616)

- A new window will popup. There you can select which type of questions you want to export.
	- If 'Regular Questions' is selected, all the questions that is made for the real game will be exported to the specified location.
	- If 'Fastest Finger First Questions' is selected, all the questions from the Fastest Finger First mode will be exported to the specified location.
	- When both checked, it will create two files (1 for Regular, 1 for Fastest Finger questions).

![Schermafbeelding 2024-11-04 222416](https://github.com/user-attachments/assets/2d339869-9095-4dc4-b9be-9b852d991b83)

- When you are ready, click 'Export'.
	- If the export tool didn't report any errors, then this action had ran succesfully.
	- But when there is an error message, check all the options and try it again. Otherwise report this issue in the Github repository of The Millionaire Game.
- To double check if everything exported without any problems, open the CSV files and see if the data is all there. When it is, you are done exporting!

## Import from CSV to Database

To import, follow these steps below...
- Open the Question Editor:
	- This is possible via The Millionaire Game app: *Game > Questions Editor*
	- Or open the QEDIT.exe file directly to open the Editor.
- In the menu bar, click on 'Actions' > 'Import Questions' > 'To CSV...'

![Schermafbeelding 2024-11-04 222543](https://github.com/user-attachments/assets/5091fcab-8c7c-4f95-8e91-d0da8acf2fd7)

- A new window will popup. There you can select which type of questions you want to import.
	- If 'Regular Questions' is selected, all the questions that is made for the real game will be exported from the specified location.
	- If 'Fastest Finger First Questions' is selected, all the questions from the Fastest Finger First mode will be exported from the specified location.
	- When both checked, it will check on both files (1 for Regular, 1 for Fastest Finger questions).

![Schermafbeelding 2024-11-04 222510](https://github.com/user-attachments/assets/c86e0892-68d0-4bb7-b212-7c142b666054)

- When everything is ready, click 'Import'.
	- If everything imports correctly, then a message will pop up telling that the questions imported succesfully.
	- Otherwise you get an error message. If that's the case, check the import settings, CSV files and folder/file permissions. When that is all right, then let it know us in the Github repository of The Millionaire Game.
- Refresh the main window. Then it will show you all the questions + the imported ones.

## Bulk insert from self-written CSV

> Attention / FYI: As it is the first ever variant of a CSV import tool, the chance of getting errors is still high and the tool itself is very basic. Keep that in mind when you come along some challenges. ;)
> 
> Improvements and updates will come in newer versions of course.

When you want to make your own CSV file from scratch, that's also possible.
But keep in mind that the file needs to be in the correct format.
Making your own CSV file is quite helpful if you want to import a bulk of (Fastest Finger First) questions.

Every row in the file is an individual question. The format of how you write one question is as follows:

    <Question>;<A>;<B>;<C>;<D>;<CorrectAnswer>;<Difficulty_Type>;<Level>;<LevelRange>;<Note>

More info about the information that you need to fill in:
`<Question>` = The actual question

`<A>` `<B>` `<C>` `<D>` = The four answers that comes with the question.

`<CorrectAnswer>` = The correct answer to the question. 
**Use following options: `A`,`B`,`C`or `D`**

`<Difficulty_Type>` = The type of difficulty system this question is using.
**Use following options: `1`for 'Specific' or `2` 'Range'**

`<Level>` = Type in the level of where the question can be played.
**For example: When you set this to `8`, then it will be in play at question 8!**
**Use a number in the following range: `1 - 15`(Lower = Easier)**

`<LevelRange>` = Type in the desired level range for the question.
**For example: When you set this to `2`, then it can be in play from question 6 to 10!**
**Use following options:  
 `1` (Question 1-5)**
  **-`2` (Question 6-10)**
  **-`3` (Question 11-14)**
   **-`4` (Question 15)**

`<Note>` = Here you can insert notes or some info about the question/answer for the host. (Not required)

### Example:

    What is the correct answer?;This Answer;No Idea;For what?;Not this one;A;1;6;;This is a note!

### Tip:
When you want to insert a line break, make sure to add `%[NL]%` at the desired place.
The application will replace this variable with an actual break.
