0x05. Unity - Assets: Models, Textures

0. Primitive player mandatory
Create a new Scene called Level01. Create a capsule GameObject called Player which will be a placeholder for this project.

1. Primitive prototype mandatory
In the Level01 scene, create a layout of floating platforms of different sizes and positions using only Unity Cube GameObjects.

2. Pole position mandatory
At the end point of the platforms, create a placeholder cylinder GameObject called WinFlag to designate the end of the path.

3. Jump man mandatory
Create a new folder called Scripts. Inside that folder, create a new C# script called PlayerController and attach it to Player.

4. Camera ready mandatory
Position the Main Camera at an offset behind the player.

5. Steady cam mandatory
In the Scripts folder, create a new C# script called CameraController that allows the camera to follow the player and rotate around it.

6. Falling up mandatory
Currently if the player falls off a platform, it falls infinitely. Respawn player.

7. Time trial mandatory
Create a new Canvas and UI Text element that displays a timer on screen.

8. Clock's ticking mandatory
Create a script called Timer and attach to the Player. Timer should have a public Text variable called Timer Text for the TimerText Text object.

9. Finish line mandatory
Create a script to stop the timer and change font color and size.

10. The sky's the limit mandatory
Create a skybox with the CloudyCrown_Midday material.
Credits to:  Skyboxes: Farland Skies - Cloudy Crown
you could find it here: https://assetstore.unity.com/packages/2d/textures-materials/sky/farland-skies-cloudy-crown-60004

11. The great outdoors mandatory
Replace your cube placeholders with the 3D models. The 3D models need mesh colliders otherwise the player cannot jump on them. 
credits: Models: Kenney's Nature Pack Extended
found: https://kenney.nl/assets/nature-pack-extended

12. Environmental awareness mandatory
From the Nature Pack asset package in your Models folder, add trees, rocks, flowers, etc. to the platforms as you like. Organize your objects in your Hierarchy using empty GameObjects.

13. What's left of the flag mandatory
Download this flag model. Place it in the Models directory. Add Flag to your scene and make it a child of the WinFlag GameObject.

14. (Sea)horse race mandatory
Download this flag texture. Place it in a new directory called Textures.

15. Under development mandatory
Create three builds of Level01 in a directory called Builds.


