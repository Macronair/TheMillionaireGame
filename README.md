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
- Compatible with Microsoft SQL Server (Local only).
- Easy to use Questions Editor.

New features, releases, suggestions and issues will be documented in this GitHub repository.

## How to install and use?
- Download the latest (or other) release and extract the zip file to the desired folder.
- Run MillionaireGame.exe
- When you launch it for the first time, the database file will be created automatically for you.
- If you used an older version of the Millionaire Game, you need to transfer the questions to a new database table. A message box will notify you if this is the case.
- Tweak some settings to what you like (don't forget adding questions if you don't have them already)
- You are ready to go! Have fun!

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
<img src="https://user-images.githubusercontent.com/43847273/134224389-8e6c555d-d539-421f-b2fe-2af17bab13c5.png" alt="drawing" width="100"/>
Take out two wrong answers and leave one right & wrong answer.

### Plus One / Phone-A-Friend
<img src="https://user-images.githubusercontent.com/43847273/134224961-a43b1462-3f2b-4575-ac0d-6583f62b37bb.png" alt="drawing" width="100"/>
Ask a friend or other person for help on a question. The contestant has 30 seconds to get an answer.

### Ask The Audience
<img src="https://user-images.githubusercontent.com/43847273/134224974-d00f79a1-d538-47be-87fe-27ef6cc720e6.png" alt="drawing" width="100"/>
Ask the 'virtual' audience for help! (Also possible to set custom results per question in the Question Editor)

### Switch the Question
<img src="https://user-images.githubusercontent.com/43847273/134225023-037b27e8-6346-4354-aab7-8e49b6aec46c.png" alt="drawing" width="100"/>
When the contestant doesn't like the current question, this lifeline will switch the question for another one on the same level.

### Double Dip
The contestant gets two chances to give the correct answer. When this lifeline is in use, it is not allowed to walk away.

### Ask The Host
Like the name of the lifeline already suggest, ask the present host to give his/her opinion on what the correct answer could be.

## The Money Tree

**15 - 1.000.000**

14 - 500.000

13 - 250.000

12 - 125.000

11 - 64.000

**10 - 32.000** (When Risk Mode is active, this 2nd safety net is not present)

9 - 16.000

8 - 8.000

7 - 4.000

6 - 2.000

**5 - 1.000**

4 - 750

3 - 500

2 - 250

1 - 100

## Video Demo

[![The Millionaire Game Demo 2021](https://img.youtube.com/vi/hXtrJ1ECPtc/0.jpg)](https://youtu.be/hXtrJ1ECPtc)

## Screenshots
### Main overview:
![Screenshot_1](https://user-images.githubusercontent.com/43847273/134223822-951c5603-050c-4ac0-b000-b3dbf171fa77.png)
### Options Menu:
### Editing the sound cues:
### Questions Editor:
![Screenshot_2](https://user-images.githubusercontent.com/43847273/134223880-4fc9cb37-6084-4744-a260-1d227abfecdf.png)
### A virtual Fastest Finger First session:
![Screenshot_3](https://user-images.githubusercontent.com/43847273/134223890-5ec9aff8-88d1-4bbb-afa4-15bbcdd32c25.png)
### The Fastest FInger First client program:
### Rules in the middle of a game:
![Screenshot_4](https://user-images.githubusercontent.com/43847273/134223902-15be2d30-4a35-4ec6-932a-36aa8f8b51fe.png)
### Contestant winning 32.000:
![Screenshot_5](https://user-images.githubusercontent.com/43847273/134223910-30d1e2ab-83e9-456f-98f1-a01d477be1b2.png)

## Where to download it?
You can download one of the releases: 
[here](https://github.com/Maerciez/TheMillionaireGame/releases)
!

## Other versions / forks.
When I was inactive for a while, I noticed on Github that forks were created from this repository.
And my support for it is 100%. So if you have any knowledge about VB.net & C# programming languages, then feel free to modify this to your own liking.
The best forks will be highlighted in the list below (with short description of what is modified) so you can check it as well.

- Version of mathieufitzgerald (https://github.com/mathieufitzgerald/TheMillionaireGame): Custom textures + 1920x1080 support
- <maybe your fork??>
