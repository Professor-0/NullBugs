# NullBugs

## Installation

Android Debug Bridge is required for installation

1. Connect an android device (Android 7 or higher) via USB to your computer.
2. Run `adb install clairvoyance.apk`

## Compilation

A prepackaged binary is provided for ease of installation, however compiling from source is possible.
Unity 2020.3.40f1 with Android Build Tools and Java 1.8 JDK are required for compilation.

1. Open the NullBugs folder from Unity Hub
2. Go to *File -> Build Settings*. Under platform select Android. Then select *Change Platform* at the bottom.
3. Go to *Edit -> Project Settings -> Player -> Publishing Settings*. Select Keystore Manager. Select *Keystore -> Create New -> Anywhere...*. Save the file as debug.keystore. Choose a password for the keystore and for the new key. These will need to be entered again everytime you restart Unity. Give the new key an Alias of *androiddebugkey*. Select Add Key. When prompted to use the keystore, accept.
4. Connect an android device (Android 7 or higher) via USB to your computer.
5. Select *File -> Build And Run*.

## Troubleshooting

- If prompted to install a higher level sdk, accept. If this fails make sure your computer has java 1.8 installed as its default.

## Dependencies

Clairvoyance leverages the [Unity engine](https://unity.com/) and the [Google Cardboard for Unity XR plugin](https://github.com/googlevr/cardboard-xr-plugin).
