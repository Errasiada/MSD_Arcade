# MSD_Arcade

### Moñeco's Adventure

Creating an Arcade Game in Unity, here is the documentation about the process, results and code used during the development.

1.) Creating a character sprite for the player named "Moñeco" with an Idle animation.

![MoñecoIdle-export](https://user-images.githubusercontent.com/114673717/211805613-4ef4a610-9be1-4760-ac3a-91cd88425201.gif)


2.) Adding ground and background. I created several sprites for the ground, the grass and the background loop. This way the camera stays with the player while the background makes the visual effect of movement in a constant loop.

![Background](https://user-images.githubusercontent.com/114673717/211805696-6c8bb6e6-3ca3-43c8-bf1f-604c0a149d6b.png)

3.) Creating the player movement and jump as the basic character controllers. Player is allowed to move the character with A and D, and jump by pressing Spacebar. Also, I added a double jump feature that allows the player to double jump if the character is not on the ground. Here's the example and portion of the code.

![aprite3](https://user-images.githubusercontent.com/114673717/211806363-fe2b0576-3d23-48c7-abd2-e5f196e0df7e.gif)

4.) Adding a Bird spawner. For the enemies I created an item spawner that will drop the birds sprites in three different locations in the *y*

5.) Adding a Item spawner. Similar to the bird spawner, but with the Star collectibles. Added yellow shiny sparkles as particles when the item is collected.

![aprite4](https://user-images.githubusercontent.com/114673717/211806879-d974be88-4712-4890-b7b6-6ca96eb5ddd6.gif)


6.) Adding an HP system. The player looses one heart after being hit, when hit multiple times and losing all the hearts it's a Game Over.


