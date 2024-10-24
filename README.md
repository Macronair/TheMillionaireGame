![millionairebanner](https://user-images.githubusercontent.com/43847273/134223706-0bd26069-d8a0-475b-a918-f151a401b819.png)

# The Millionaire Game
A custom game controller software like WWTBAM.

## Introduction
This project began in the summer of 2017 for a YouTube series called 'Het DJG Toernooi' (The DJG Tournament). After couple of livestreams and video's, the project discontinued in late 2018.


But when the COVID-19 reached the rest of the world in 2020, I restarted this project with a new name called 'The Millionaire Game' and decided to put the source code on GitHub to help other people making their own quiz game with this program.
This software can be used to run your own Who Wants To Be A Millionaire games. For example at home, on Discord with friends or on a Youtube video/livestream.
There will be new features in the future to play around with. But there are a lot of elements that you can use:
- Max. 4 lifelines (customizable).
- Host and Contestant screen.
- TV/Livestream screen.
- Fastest Finger First (+ online features) (Windows only).
- Risk Mode (2nd safety net disabled & extra lifeline(s) can be activated).
- Free Safety Net Mode (2nd safety net can be placed anywhere after the 5th question).
- Compatible with Microsoft SQL Server (Local & Networked).
- Easy to use Questions Editor.

New features, releases, suggestions and issues will be documented in this GitHub repository.

## Software Requirements
To run the Millionaire Game, you also need to install the following software:
- Microsoft SQL Server Express (2019 or later).

## How to install and use?
- Download the latest (or other) release and extract the zip file to the desired folder.
- When you want to run the database locally on your computer, you also need to install SQL Server Express.
- Run MillionaireGame.exe located in the downloaded zip archive.
- When you launch it for the first time, you can choose where your database is going to be and the application will make the database itself + the tables automatically for you.
- If you used an older version of the Millionaire Game, you need to transfer the questions to a new database table. A message box will notify you if this is the case.
- Tweak some settings to what you like (don't forget adding questions if you don't have them already). Therefore, you can also use the import tool in the Questions Editor.
- You are ready to go! Have fun playing Millionaire!

## Extra information
To use the online features of Fastest Finger First, you need to setup the following:
1. Open the 'FFF Server' in the application. At first, Windows Firewall asks if you want to allow this program. Click 'Allow' or 'Yes'.
2. On your router, open the TCP port that is given in the Options menu. Otherwise people cannot join. (*The default port is 3818*).
3. Choose the preferred amount of player slots on the server (2-8).
4. The contestants need to have the application 'FFF_Client.exe' to connect to your FFF session. In the texbox, enter the needed IP address. *(LAN IP for people in the same network, WAN IP for people on other networks)*
5. Select a player slot that is free (1 to 8).
7. Click 'Connect' and you are done. *(When the 'Connect' button on the client changes to 'Disconnect', then the contestant is connected.)*

## Lifelines

The lifelines that are in play are fully customizable. You can use up to 4 lifelines in total when playing the game.
So if you want, you can also set the total lifelines to 0. Then there will be no lifelines in the game to use. *(Pretty hardcore)*
Also there is the option to set when the lifeline(s) become available. These are the current possibilities:
- Always (Lifeline can be used on every question)
- After Q5 (Lifeline is unlocked after the contestant answers question 5 correctly)
- After Q10 (Lifeline is unlocked after the contestant answers question 10 correctly)
- Risk Mode (When activating Risk Mode, the lifeline becomes available to the contestant)

### 50:50
<img src="https://github.com/Macronair/TheMillionaireGame/assets/43847273/71a05554-885f-45b1-8684-2326e0d825ef" alt="drawing" width="100"/>

Take out two wrong answers and leave one right & wrong answer.

### Plus One (Phone-A-Friend)
<img src="https://github.com/Macronair/TheMillionaireGame/assets/43847273/7792b3a8-687d-4057-89a3-86f3fc8f8d8e" alt="drawing" width="100"/>

Ask a friend or other person for help on a question. The contestant has 30 seconds to get an answer.

### Ask The Audience
<img src="https://github.com/Macronair/TheMillionaireGame/assets/43847273/d5be754e-4516-49f1-909c-1b3d77b6e30d" alt="drawing" width="100"/>

Ask the 'virtual' audience for help! (Also possible to set custom results per question in the Question Editor)

### Switch the Question
<img src="https://github.com/Macronair/TheMillionaireGame/assets/43847273/b6818568-0b4f-4537-b3a1-1889cc0c16a4" alt="drawing" width="100"/>

When the contestant doesn't like the current question, this lifeline will switch the question for another one on the same level.

### Double Dip
<img src="https://github.com/Macronair/TheMillionaireGame/assets/43847273/ef1e51ae-95ce-4918-be29-5cf6bb355a3a" alt="drawing" width="100"/>

The contestant gets two chances to give the correct answer. When this lifeline is in use, it is not allowed to walk away.

### Ask The Host
<img src="https://github.com/Macronair/TheMillionaireGame/assets/43847273/2f5693a1-9d80-45c4-b5b4-c460f293ba8d" alt="drawing" width="100"/>

Like the name of the lifeline already suggest, ask the present host to give his/her opinion on what the correct answer could be.

## The Money Tree
![0_tree_0](https://github.com/Macronair/TheMillionaireGame/assets/43847273/d6df607e-3d9a-460f-8142-7b30fcd71640)

## Video Demo
You can watch the demo video of 2023 here below:

[![The Millionaire Game Demo 2023](https://img.youtube.com/vi/NVtr-75A5mc/0.jpg)](https://youtu.be/NVtr-75A5mc)

## Screenshots
### Main overview:
![Schermafbeelding 2023-11-21 224448](https://github.com/Macronair/TheMillionaireGame/assets/43847273/db4cb661-eb36-4cb5-a0cc-332b02385b24)
### Options Menu:
![Schermafbeelding 2023-11-21 224557](https://github.com/Macronair/TheMillionaireGame/assets/43847273/323c4648-3d5b-408c-ac8b-80807dd42794)
### Editing the sound cues:
![Schermafbeelding 2023-11-21 224658](https://github.com/Macronair/TheMillionaireGame/assets/43847273/38b9ecf5-1919-48ad-a354-23008be36af5)
### Questions Editor:
![Schermafbeelding 2023-11-21 224805](https://github.com/Macronair/TheMillionaireGame/assets/43847273/71c96aed-3a8e-4b25-bc7e-849704ca0330)
### A virtual Fastest Finger First session:
![Schermafbeelding 2023-11-21 224958](https://github.com/Macronair/TheMillionaireGame/assets/43847273/a72fba3f-65b8-4975-bede-92500a3dc4fc)
### The Fastest FInger First client program:
![Schermafbeelding 2023-11-21 225043](https://github.com/Macronair/TheMillionaireGame/assets/43847273/0f539ca6-704b-4598-8868-79b9e05978be)

## Where to download it?
You can download one of the releases: 
[here](https://github.com/Maerciez/TheMillionaireGame/releases)
!

## Some other useful guides
- Setting up and using a networked SQL Server.
- Back-up and restore questions.
- Migrating questions to other database.
- Writing questions in Excel/CSV + bulk import in application.
- Using Fastest Finger First

## Other versions / forks.
When I was inactive for a while, I noticed on Github that forks were created from this repository.
And my support for it is 100%. So if you have any knowledge about VB.net & C# programming languages, then feel free to modify this to your own liking.
The best forks will be highlighted in the list below (with short description of what is modified) so you can check it as well.

- Version of mathieufitzgerald (https://github.com/mathieufitzgerald/TheMillionaireGame): Custom textures + 1920x1080 support
- <maybe your fork??>
