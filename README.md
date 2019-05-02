# VirtualCanvas

This repository, produced as part of a Senior Honors Capstone Research project conducted by Nolan Cooper ([@barrelmaker97](https://www.github.com/barrelmaker97)) and Ryan Lewis ([@LuckierDodge](https://www.github.com/LuckierDodge)), explores the creation and use of 3D-printed trackable objects for use with Augmented Reality (AR) applications. The repository contains the following:

1. A Unity3D application, located under `/HoloLens Virtual Canvas`, which demonstrates the ability to use 3D trackables to generate a "Virtual Canvas" in Augmented Reality. Versions of the Application targetted for Microsoft HoloLens and Android 8.1 'Oreo' are available on the `master` and `android` branches, respectively.
1. The model files we 3D printed for our project, located under `/Meshes`.

A video demo of the Android version of tbe application can be found [here](https://youtu.be/Y6zBJy-AGNw).

## Notes for 3D printing
The models we tested for this project are available in the `/Meshes` directory of this repository, as well as one model located on Thingiverse, a [Voronoi Klein Bottle](https://www.thingiverse.com/thing:145694). We experimented with various print properties and model characteristics to determine optimal traits for a 3D printed trackable object. The following were our general conclusions:

* Nontrivial shape (Something like the Reticles located under `/Meshes/Complexs` is far preferable to a simple cube or cylinder.
* Surface Contrast and Variety (A Dual Extrusion 3D printer can help with this, but a sharpie marker could suffice in a pinch. See the Dual Extrusion example under `/Meshes/Complexs`).
* Complex Perforated Surface Pattern (See the Klein Bottle above for an example).
* **A Matte, Opaque, Non-transclucent Material.** PLA or ABS will serve you well, transclucent or flexible filaments will in some cases make tracking difficult or impossible.

We used a [BCN3D Sigma Dual Extrusion Printer](https://www.bcn3dtechnologies.com/en/3d-printer/bcn3d-sigma/) for most of our testing, but almost any desktop 3D printer should work. Print settings varied from model to model, but in most cases Cura's "Draft" Quality should be acceptable.


*Special thanks for the support of Northern Illinois University, the NIU Honors Program, Dr. Michael Papka, the Data, Devices and Interactions Laboratory, and the Honors Council of the Illinois Region.*
