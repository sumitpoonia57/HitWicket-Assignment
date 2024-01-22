
                                                                             #HitWicket Assignment

# Work Done:-  Created the game in three levels staged in the assignment.

LEVEL 1: Ensures the movement of our game character and proper platform placement as per the JSON file provided. Json: (https://s3.ap-south-1.amazonaws.com/superstars.assetbundles.testbuild/doofus_game/doofus_diary.json)

Outcome made for Level 1: 
![image](https://github.com/sumitpoonia57/HitWicket-Assignment/assets/90952998/8ee32684-c99b-423b-b14a-687184bb3b93)

LEVEL 2: Made sure of proper score updation after every successful move to a different platform.

Here are some images showing proper updation as the character has moved from one platform to another.

Score at first platform:
![image](https://github.com/sumitpoonia57/HitWicket-Assignment/assets/90952998/167637b5-cce2-4807-bdd4-7f9f44b6fbb1)

Score as character moved to third platform:
![image](https://github.com/sumitpoonia57/HitWicket-Assignment/assets/90952998/ca495053-abd2-4bd4-b7ad-047472689845)


LEVEL 3: Created the "Start" screen which comes before our game starts and "Game Over" screen as our character falls from any platform.

Image of START screen:
![image](https://github.com/sumitpoonia57/HitWicket-Assignment/assets/90952998/9b9e86b5-6136-4feb-af01-37bf12534cb4)

Image of GAME OVER screen:
![image](https://github.com/sumitpoonia57/HitWicket-Assignment/assets/90952998/0bcd3bae-de51-491a-8027-b73b85e989e1)


Key Expectations were also met:
1. The code written was modular and robust code.
2. Proper code structuring, readability and adaptability was met.
3. All levels were completed.
4. Did handling of the specified exceptions and edge cases gracefully.

Some Edge conditions which I followed:

- The Player Speed and The Pulpit Data are retrieved from a JSON File stored in a web server.
- The new Pulpit will not spawn on the last pulpit location.
- The Pulpit have a random life span Ranging between two numbers given in the JSON File.
- The Pulpit will also fall down when the timer reaches 0.
- At a given time only 2 Pulpit will only be present and new Pulpit will spawn the the old Pulpit's timer reached 2.5 seconds.
- The Player moves at the speed which is given in the JSON File.                                                                            
                                                                        
                                                                            
