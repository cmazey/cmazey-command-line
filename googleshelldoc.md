# Cmazey Command Line: Google Shell Documentary

This documentary is going to be quick, and short. So let's begin right now. So, after the virtual machine is done forking the project. Before you can access more of my code, there are a few things to do. So we are going to use the terminal. 

<img title="a title" alt="Alt text" src="/images/image1.png">

Just to let you know, you are going to input the following commands. Which is changing to the `Cmd-REPL` directory using the `cd` command. This will change the directory from `cmazey-command-line` to `Cmd-REPL`.

```
cd Cmd-REPL
```
<img title="a title" alt="Alt text" src="/images/image2.png">

- **IMPORTANT**: INSTALL THE REQUIREMENT DEPENDENCY OR IT WONT WORK:: `python -m pip install -r requirements.txt`

After that, you will type in `python`, and then `ccl.py`. This will open the `ccl.py` file using Python. Python is already pre-installed, and it also includes Node.JS and C#, so there's no need to preinstall those.

```
python ccl.py
```
<img title="a title" alt="Alt text" src="/images/image3.png">

That's all that you have to do. If you are experiencing some issues, please let me know in my discord server, or open an issue request.


# The Manual Way
> Directory is a fancy terminal-related term for folder

This is optional, but if you prefer to manually direct yourself to the file, and run it yourself, then you can, but you should get some prior experience with the terminal, so let me teach you some cool tricks.

The first and only trick I will teach you is `ls` which is used to see what's inside the directory.
> Blue indicates that it's a folder
<img title="a title" alt="Alt text" src="/images/image4.png">

So that's all that you would need experience-wise. Anyways, let's use the `cd` command to head to the `re` directory. So if you are already in the `Cmd-REPL` directory, then `cd` to the `re` directory.

<img title="a title" alt="Alt text" src="/images/image5.png">

```
cd re
```
> If it doesn't work, then you weren't in the Cmd-REPL directory in the first place.


When you are in the `re` directory, then run the `ls` command, and see what directory, and/or files are in.

<img title="a title" alt="Alt text" src="/images/image6.png">

- `math` directory stores Cmazey Calculator aka `mathcmd.cs` file.
- `py` directory stores `pycmd.py` file which is referred to as CCL: py.
- `node` stores  `nodecmd.js` file which is referred as CCL: node.
- `other` stores some additional small projects that I did.
- `lesson` stores some lessons that I did during my freshman, and Junior year.
- `pymath` is one of my new projects I made which includes a copycat-like of Cmazey Calculator, but it's very lightweight and basic, and it's going to be referred as Cmazey Pylicator.



## Accessing Cmazey Calculator

Since you are already in the `re` directory. Let cd to 2 directories, so we will be using `/` to navigate to 2 directories. So let's `cd` to  `math`, and `rere`

<img title="a title" alt="Alt text" src="/images/image7.png">

```
cd math/rere
```
> We are skipping the `math` directory, and heading straight to the `rere` directory because that directory stores the whole code source. `math` directory only stores the `startup.py` which we don't need to run since it's time-wasting.

After that. Now we run the command, which will create a Debug build of `mathcmd.cs` aka Cmazey Calculator. Also note: Google Shell has .NET 7.0 which is enough to run my AP project. Anyway, let's run the file now.

<img title="a title" alt="Alt text" src="/images/image8.png">

```
dotnet run
```

That's it, The project has complied a Debug build, and it should be running the file now. But if it somehow freezes, and it stops responding. Then press `CTRL + C`. This will terminate the command, and you can run the command again. If the issue persists. Then please let me know in my discord server, or create a new issue request.


## Accessing Node

When running a `.js` file, there are packages that you would need to install so that it will work out of the box without having any issues. This documentary will explain how to download the necessary packages and don't worry, it's going to be quick and easy.

First, we will cd to `node`, and `rere`. 
> Assuming that you are in the `Cmd-REPL/re` directory, if you aren't in there, then `cd` there first.

<img title="a title" alt="Alt text" src="/images/image9.png">

```
cd node/rere
```

Now that you are in the `rere` directory for `node`. We will install the necessary packages. If you already done that, then you can skip this part.

We will be installing 2 packages. The 2 packages are 'readline-sync', and 'colors'. So type in the following command each.
> npm is a package manager for node.js

<img title="a title" alt="Alt text" src="/images/image10.png">

```
npm install readline-sync
```
```
npm install colors
```

After the necessary packages are installed. We are going to run the `nodecmd.js` file. To run the file, we have to type out `node` then we will add `./` which tells the shell that we want to run a Javascript file in the same directory, and then we will type out the file name.

<img title="a title" alt="Alt text" src="/images/image11.png">

```
node ./nodecmd.js
```

> If you are having some issues running the file. Then double-check that you are in the same directory, and you have installed the necessary packages. Also, use the `ls` command to see what files are in the directory that you are currently in.


*Still working on it. Last updated 06:02 PM EST, 2/15/2024*

