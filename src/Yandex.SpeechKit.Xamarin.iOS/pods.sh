


# download and init
sharpie pod init ios YandexSpeechKit


# prepare
cd Pods/YandexSpeechKit/YandexSpeechKit.framework/Versions/A/Headers
mv SpeechKit.h YandexSpeechKit.h
cd ../../../../../../

# bind
sharpie pod bind -v

