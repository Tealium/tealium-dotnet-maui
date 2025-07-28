#!/bin/bash

#######################################################
# xcframework builder script for tealium-swift
#######################################################

cd "$(dirname "$0")" || { echo "cd failure"; exit 1; }

# variable declarations
XCFRAMEWORK_PATH="tealium-xcframeworks"
CERTIFICATE="Apple Distribution: Tealium (XC939GDC9P)"

# zip all the xcframeworks
function zip_xcframeworks {
    if [[ -d "${XCFRAMEWORK_PATH}" ]]; then
        ditto -ck --rsrc --sequesterRsrc --keepParent "${XCFRAMEWORK_PATH}" "${ZIP_PATH}" 
        rm -rf "${XCFRAMEWORK_PATH}"
    fi
}

cd Example || exit 1;

pod install

# do the work
surmagic xcf

# Code Sign
for frameworkname in "$XCFRAMEWORK_PATH"/*.xcframework; do
    echo "Codesigning $frameworkname"
    codesign --timestamp -s "$CERTIFICATE" "$frameworkname" --verbose
    codesign -v "$frameworkname" --verbose
done

rm -rf "../../../../APIs/Tealium.Platform.iOS/${XCFRAMEWORK_PATH}"
mv "./${XCFRAMEWORK_PATH}" "../../../../APIs/Tealium.Platform.iOS/"

echo ""
echo "Done!"

open "../../../../APIs/Tealium.Platform.iOS/"
