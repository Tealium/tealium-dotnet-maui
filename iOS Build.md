# iOS Build

In order to make this project work for iOS, a TealiumSwift and a TealiumWrapperCocoapods framework need to be in the `APIs/Tealium.Platform.iOS/tealium-xcframeworks` folder.
Installing them is as easy as running the `xcframeworks.sh` script in the `Bindings/iOS/TealiumWrapperCocoapods` directory.
```bash
Bindings/iOS/TealiumWrapperCocoapods/xcframeworks.sh
```
This will compile both frameworks for device and simulator, merge them in two fat frameworks and place them in the correct place.

## Troubleshooting

In case you see some errors in Visual Studio, be sure to clean and rebuild `Tealium.Platform.iOS` and then `Tealium.iOS` after you generated the native libraries, just to be sure that they are being correctly referenced by those libraries.