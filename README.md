# Ripple-GUI-Scripts

## Script Overview

### DimLight.cs
This script is in charge of the point light halo glow effect that is placed on icons inside of the environment. As the player controlled fish gets close to an icon, the glow will fade away, and when the fish swims away from the icon

### GUI_Manager.cs
This script manages the GUI implementation and all visual and game elements that relate to it. It talks to the GUI_Trigger script in order to know when to activate. Upon activation it will populate the screen with the information prompt and then the fact information along with associated imagery. This include dimming, and blurring the screen, and managing layouts for all bodies of text.

### GUI_Trigger.cs
This script checks if the game object that enters the trigger zone of an icon is the player controlled fish, and if so makes a call to the GUI_Manager script in order to turn on the gui functionality.

### IconFollow.cs
This script makes it so that the image plane of an icon is always following the camera.

### KnowledgeDrop.cs
This script declares all of the public variables that store text and images for the GUI.