Hello!

The setup for this program is pretty straight-forward. 
  1. Make sure that both the setup.exe and Setup.msi are present in the same directory as each other.
  
  2. Run setup.exe
  
  3. The default installation path is going to be somewhere in the Programs (x86) file. 
      However, the application has trouble accessing the files due to high security, so change the installation path
      to somewhere easily accesible. For me, my Documents file worked perfectly.
      
  4. Once the program runs, you'll be greeted with a Login page. The default user to get into the system is 
  
      username: admin
      password: admin
      
      Once in, you can add additional users if you'd like.
      
  NOTE: The program won't work with SQL server versions older than SQL Server 2019. The setup should prompt the user if it
        isn't present, but if for any reason this becomes a problem, I thought this was worth noting. 
      
General functionalities:
  1. Dashboard
    a. Shows general statistics
       - Registered Guests Count
       - Registered Rooms
       - Current reservations (Ongoing reservations with regards to the device's current date. This means past and future reservations aren't counted.)
       - Current Employees
       
    b. Hotel Amenities
       - Ability to add, delete, edit, or view hotel amenities and their description. 
          Example Amenity: Name: Gym, Description: Includes free weights, machines, cardio machines, and more.
          
   2. Guests
      - Ability to add, delete, search Guests.
      - Throws errors when adding if any fields are empty or phonenumber contains any characters that aren't numbers.
      - Throws an error when deleting if an email doesn't exist.
      
        NOTE: For all search capabilities (not just for Guests), it returns rows that BEGIN with whatever is in the search box.
       
    3. Rooms
      - Ability to add, delete, and search rooms and their room types.
      - Throws an error when adding if the room number is already registered.
      - Throws an error when deleting if the room number doesn't exist.
      - Throws an error when adding room type if price isn't a number.
      - Clicking on "Existing Room Types" DataGridView cells will prompt user if they would like to delete the room type.

        NOTE: If you delete a room type, any rooms that were registered with that type will also be deleted.
       
    4. Reservations
      - Ability to add, delete, and search reservations.
      - Throws errors if Email doesn't exist, no rooms are available, or the Check-In and Check-Out dates are the same.
      - Users can't make reservations that are before the device's current day.
      - Price for the stay displayed.
      - Clicking on "Search Reservations" DataGridView cells will prompt the user if they would like to delete a reservation.
      
        NOTE: You won't be able to reserve a room if it's already being reserved.
    
    5. Employees
      - Ability to add, delete, and search employees.
      - Throws errors when adding if username is already taken or passwords don't match.
      - Throws errors when deleting if username or password is incorrect.
      
  General notes when looking at my code:
    The code that I wrote is going to be found in these files/folders primarily:
      1. /Database Models
      2. /User Controls
      3. /User Forms
      4. DataAccess (contains all of my DML. The skeleton of my program).
      5. Program.cs
      
  Ending Notes:
    1. In order to uninstall my program, you can rerun the setup or you can go to Windows's Add/remove Programs option.
    I hope you've enjoyed my project!
       
