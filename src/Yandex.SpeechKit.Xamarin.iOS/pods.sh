


# download and init
sharpie pod init ios YandexSpeechKit


# prepare
cd Pods/YandexSpeechKit/YandexSpeechKit.framework/Versions/A/Headers
mv SpeechKit.h YandexSpeechKit.h
cd ../../../../../../

cp -R Pods/YandexSpeechKit/YandexSpeechKit.framework Binding/

# bind
sharpie pod bind -v

