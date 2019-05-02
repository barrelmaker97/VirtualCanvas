# VirtualCanvas

This repository, produced as part of a Senior Honors Capstone Research project conducted by Nolan Cooper ([@barrelmaker97](https://www.github.com/barrelmaker97)) and Ryan Lewis ([@LuckierDodge](https://www.github.com/LuckierDodge)), explores the creation and use of 3D-printed trackable objects for use with Augmented Reality (AR) applications. The repository contains the following:

1. A Unity3D application, located under `/HoloLens Virtual Canvas`, which demonstrates the ability to use 3D trackables to generate a "Virtual Canvas" in Augmented Reality. Versions of the Application targetted for Microsoft HoloLens and Android 8.1 'Oreo' are available on the `master` and `android` branches, respectively.
1. The model files we 3D printed for our project, located under `/Meshes`.

A video demo of the Android version of tbe application can be found [here](https://youtu.be/Y6zBJy-AGNw).

## Building and Deploying
In order to run these projects, you will need both Unity and Visual Studio. If you've got those, then you're all set, just follow these steps:

### Export to Visual Studio
1. Open Unity, click **Open**, navigate to the project you'd like to open, and click **Select Folder**
2. In Unity, go to **File > Build Settings**
3. In Build Settings, make sure there is a scene listed in **Scenes to Build**
4. Change **Platform** to **Windows Store** and click **Switch Platform**
5. Under **Windows Store**, ensure **SDK** is **Universal 10**
6. For **Target Device**, select **Hololens**
7. **UWP Build Type** should be **D3D**
8. **UWP SDK** should be **Latest Installed**
9. **Build and Run on** should be **Local Machine**
10. Check **Unity C# Projects** under Debugging
11. Click **Build**
12. When Unity is done building, a Windows File Explorer window will appear
13. In the file explorer, click **New Folder** and name the folder **App**
14. Open the **App** folder in the file explorer and open the generated Visual Studio solution

### Compile and Deploy
1. Using the top toolbar in Visual Studio, change the target from **Debug** to **Release** and from **ARM** to **X86**
2. Click on the arrow next to the **Local Machine** button, and change the deployment target to **Remote Machine**
3. Enter the IP address of your Hololens and change **Authentication Mode** to Universal (Unencrypted Protocol)
4. Click **Debug > Start without debugging**
5. The first time you deploy to your HoloLens from your PC, you will be prompted for a PIN. Follow the **Pairing** instructions below

### Pairing
The first time you deploy an app from Visual Studio to your HoloLens, you will be prompted for a PIN. On the HoloLens, generate a PIN by launching the Settings app, go to **Update & Security > For Developers** and tap on **Pair**. A PIN will be displayed on your HoloLens; type this PIN in Visual Studio. After pairing is complete, tap **Done** on your HoloLens to dismiss the dialog. This PC is now paired with the HoloLens and you will be able to deploy apps automatically.

### Additional Documentation
If you're having trouble, check out Microsoft's Documentation on [Using Visual Studio](https://developer.microsoft.com/en-us/windows/mixed-reality/using_visual_studio) or [Deploying to Hololens](https://developer.microsoft.com/en-us/windows/mixed-reality/holograms_100#chapter_6_-_build_and_deploy_to_device_from_visual_studio)

## Notes for 3D printing
The models we tested for this project are available in the `/Meshes` directory of this repository, as well as one model located on Thingiverse, a [Voronoi Klein Bottle](https://www.thingiverse.com/thing:145694). We experimented with various print properties and model characteristics to determine optimal traits for a 3D printed trackable object. The following were our general conclusions:

* Nontrivial shape (Something like the Reticles located under `/Meshes/Complexs` is far preferable to a simple cube or cylinder.
* Surface Contrast and Variety (A Dual Extrusion 3D printer can help with this, but a sharpie marker could suffice in a pinch. See the Dual Extrusion example under `/Meshes/Complexs`).
* Complex Perforated Surface Pattern (See the Klein Bottle above for an example).
* **A Matte, Opaque, Non-transclucent Material.** PLA or ABS will serve you well, transclucent or flexible filaments will in some cases make tracking difficult or impossible.

We used a [BCN3D Sigma Dual Extrusion Printer](https://www.bcn3dtechnologies.com/en/3d-printer/bcn3d-sigma/) for most of our testing, but almost any desktop 3D printer should work. Print settings varied from model to model, but in most cases Cura's "Draft" Quality should be acceptable.


*Special thanks for the support of Northern Illinois University, the NIU Honors Program, Dr. Michael Papka, the Data, Devices and Interactions Laboratory, and the Honors Council of the Illinois Region.*
