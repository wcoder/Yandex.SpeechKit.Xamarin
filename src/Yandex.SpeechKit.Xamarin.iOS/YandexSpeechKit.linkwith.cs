using ObjCRuntime;
[assembly: LinkWith("YandexSpeechKit.framework",
Frameworks = "SystemConfiguration CoreLocation AudioToolbox CoreAudio QuartzCore UIKit Foundation CoreGraphics AVFoundation",
LinkerFlags = "-lz -lc++",
IsCxx = true,
SmartLink = true,
ForceLoad = true)]
