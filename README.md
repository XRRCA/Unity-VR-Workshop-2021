# Unity-VR-Workshop-2021
Workshop project and materials for getting started with VR development in Unity

Template is from [Unity Learn's Create with VR Course](https://learn.unity.com/course/create-with-vr)
  
  ## Getting Started

### Dependencies and version numbers

+ Unity version: >= 2021.3.16f1
  + Requires Android build system, see [this document for install process](https://docs.unity3d.com/Manual/android-sdksetup.html)
+ XR Plugin Management >= 4.2.1, Released Jan 5,2022
+ XR Interaction Toolkit >= 2.0.4, Released Nov 3, 2022
+ Oculus Integration Version: >= 49.0, Released Feb 7, 2023

### Downloading the project

* Download this project repository to your local machine using *one* of the following methods:
  * Git clone the repository with `git clone https://github.com/VizRCA/Template-VRTK_OculusGoQuest.git`
  * Download the zip file using the button above and **extract it**.

### Opening the downloaded project in the Unity software

> *Do not* drag and drop the project download into an existing Unity project. The repository download *is a Unity project* already and you should not nest a Unity project inside another Unity project. Follow the instructions below to open the Unity project.

#### Using the Unity Hub

* Open the [Unity Hub] panel.
* Click the `Add` Button:
* Browse to the local directory where the repository was downloaded to and click `Select Folder`:
* The Template project will now show up in the Unity Hub project window, so select it to open the Unity project in the Unity software:
* The Template project will now open within the Unity software.

#### Opening from within the Unity software

* Select `Main Menu -> File -> Open Project` within the Unity software.
* Browse to the local directory where the repository was downloaded to and click `Select Folder`.
* The Template project will now open within the Unity software.


### Building the example scene

* Set up your Oculus Go for development, see below.
* Set up a `Builds` directory outside the project `Assets` folder
* Open `File` > `Build Settings`
  * Make sure example scene is added to scenes in build list.
  * Refresh the `Run Device` list, pick your Oculus Quest from the list.
* Press `Build and Run`, put build into previously made `Builds` folder.

#### Set up your Android Device (Oculus Quest) for builds

+ On the Oculus phone app, make sure the Oculus Quest you are using has developer mode enabled

## License

Code released under the [MIT License][License]. Check other integrations licenses.

## Disclaimer

These materials are not sponsored by or affiliated with Unity Technologies or its affiliates. "Unity" is a trademark or registered trademark of Unity Technologies or its affiliates in the U.S. and elsewhere.

[Unity]: https://unity3d.com/
[License]: LICENSE.md
[Unity Hub]: https://docs.unity3d.com/Manual/GettingStartedUnityHub.html
