0x06. Unity - Assets: UI

0. Leveling up mandatory
We’ll be adding on to the last project to add a menu and UI. And add 2 new levels

1. Choose your own adventure mandatory
The next few tasks will be creating UI elements using imported images to build a menu that allows the player to choose a level.

2. Option in mandatory
Create a new Scene called Options.

3. Pushing buttons mandatory
Create a new C# script called MainMenu.cs. In the MainMenu scene, script the level buttons scene so that choosing Level01, Level02, or Level03 loads the corresponding scene.

4. Wait, hold on, time out mandatory
Inside the Level01 Scene, create a new Canvas and using the image as a guide, create a pause screen.

5. Es-ca-pé mandatory
Create a new C# script called PauseMenu.cs. Add a method to this script so that when the player presses Esc while playing the game, the game should pause and the PauseCanvas should become active. The timer should also pause.

6. Even more button pushing mandatory
In the PauseMenu and PauseMenu.cs, script the RestartButton so that it reloads the level scene that the player is currently on.

7. Up is down, down is up mandatory
In the CameraController.cs script, add the ability to invert the Y axis.

Create a public bool called isInverted.

8. But Y? mandatory
In Options and OptionsMenu.cs, script it so that checking the InvertYToggle in the menu and applying the changes reverses the camera/mouse movements in the level scene.

9. A winner is you mandatory
In the Level01 Scene, create a new Canvas and using the image as a guide, create a win screen.

10. Winning isn't everything mandatory
Edit WinTrigger.cs so that when the player touches the flag, WinCanvas becomes active.

11. Still under development mandatory
Create three builds of all scenes in the Builds directory.

Credits to:  Skyboxes: Farland Skies - Cloudy Crown
you could find it here: https://assetstore.unity.com/packages/2d/textures-materials/sky/farland-skies-cloudy-crown-60004


credits: Models: Kenney's Nature Pack Extended
found: https://kenney.nl/assets/nature-pack-extended



