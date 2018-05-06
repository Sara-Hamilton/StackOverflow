# StackOverflow

##### A clone of stack overflow made using Visual Studio MVC, C#, and .NET.  05/01/18

## By Sara Hamilton and Stephanie Faber

# Description
This is an Epicodus practice project for week 3 of the .NET course.  Its purpose is to display understanding of user authentication using Visual Studio MVC, ORM, Migrations, and AJAX posts.  


## Functionality

### User Stories
* a user can
  * view all questions and answers and their authors
  * create a question 
  * click on a link to see answers pertaining to a question
  * create answers for any question
  * vote questions up or down

### Models
  * Question
    * Title
    * Content 
    * VoteTally
    * User

  * Answer
    * Content
    * VoteTally
    * User


## Technologies Used
* HTML
* CSS
* Bootstrap
* Visual Studio
* C#
* .NET
* MySql
* MAMP

## Run the Application  

  * _Clone the github respository_
  ```
  $ git clone https://github.com/StackOverflow/StackOverflow
  ```

  * _Install the .NET Framework and MAMP_

    .NET Core 1.1 SDK (Software Development Kit)

    .NET runtime.

    MAMP

    See https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c for instructions and links.

* _Start the Apache and MySql Servers in MAMP_

* _Move into the directory_
```
$ cd StackOverflow
```
*  _Restore the program_

 ```
 $ dotnet restore
 ```
* _Move one layer deeper into the directory_
```
$ cd StackOverflow
```
*  _Setup the database_

 ```
 $ dotnet ef database update 
```
*  _Run the program_
```
$ dotnet run
```

### License

*MIT License*

Copyright (c) 2018 **_Sara Hamilton and Stephanie Faber_**

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
