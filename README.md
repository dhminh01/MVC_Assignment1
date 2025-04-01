# MVC_Assignment1

## Project Overview

This project is an implementation of the .NET Core MVC.

## Features

The project has the functions below:

1. Action to return a list of members who is Male
2. Action to return the oldest one based on “Age” (if return more than one record then select first
   record)
3. Action to return a new list that contains Full Name only ( Full Name = Last Name + First Name)
4. Action to redirect to the following actions based on the value provided by end user via Query
   String (action param) :
   o Action to return list of members who has birth year is 2000
   o Action to return list of members who has birth year greater than 2000
   o Action to return list of members who has birth year less than 2000

## Requirements

- .NET Framework or .NET Core
- Visual Studio or any compatible IDE

## Installation

1. Clone the repository:
   ```bash
   git clone <https://github.com/dhminh01/MVC_Assignment1.git>
   ```
2. Open the project in your IDE.
3. Build the solution to restore dependencies:

   ```bash
   cd <your_folder>
   dotnet build
   ```

## Usage

1. Run the application from your IDE.
   ```bash
   dotnet run
   ```
2. Access the application in your browser at `http://localhost:<port>`.
3. add /Nashtech/Rookies/(action) to run the function. E.g: /Nashtech/Rookies/GetOldest.

## Updates

Any further updates will show here

- 4/1/2025: Final
