using System;
using Foundation;
using UIKit;
using YandexSpeechKit;

namespace YaSpeechKitApp.iOS
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }


        partial void OnStartRecognizer(UIButton sender)
        {
            StartVocalizer();
        }

       


        // Swift sample:
        // https://github.com/yandexmobile/yandex-speechkit-samples-ios/blob/master/VocalizerSwiftSample/VocalizerSwiftSample/YSKVocalizerViewController.swift
        // TODO:
        void StartVocalizer()
        {
            var vocalizer = new YSKVocalizer(
                                    text: "Привет мир!",
                                    language: Constants.YSKVocalizerLanguageRussian,
                                    autoPlay: true,
                                    voice: Constants.YSKVocalizerVoiceOmazh);
            vocalizer.Delegate = new CustomVocalizerDelegate();
            vocalizer.Start();
        }


        // Swift sample:
        // https://github.com/yandexmobile/yandex-speechkit-samples-ios/blob/master/RecognizerUISwiftSample/RecognizerUISwiftSample/YSKRecognizerViewController.swift#L46
        // TODO:
        void ShowSpeechRecognisionGUI()
        {
            var recognizerViewController = new YSKSpeechRecognitionViewController(
                                            language: Constants.YSKRecognitionLanguageRussian,
                                            model: Constants.YSKRecognitionModelGeneral);
            recognizerViewController.Delegate = new CustomSpeechRecognitionViewControllerDelegate();

            PresentViewController(recognizerViewController, true, () =>
            {

            });
        }

        // Swift sample:
        // https://github.com/yandexmobile/yandex-speechkit-samples-ios/blob/master/RecognizerSwiftSample/RecognizerSwiftSample/YSKRecognizerViewController.swift
        // TODO:
        void StartSpeechRecognizer()
        {
            var recognizer = new YSKRecognizer(
                            language: Constants.YSKRecognitionLanguageRussian,
                            model: Constants.YSKRecognitionModelGeneral);
            recognizer.Delegate = new CustomRecognizerDelegate();
            recognizer.VADEnabled = true;
            recognizer.Start();
        }
    }

    public class CustomVocalizerDelegate : YSKVocalizerDelegate
    {
        public override void VocalizerDidStartPlaying(YSKVocalizer vocalizer)
        {
            
        }

        public override void Vocalizer(YSKVocalizer vocalizer, NSError error)
        {
            
        }
    }

    public class CustomSpeechRecognitionViewControllerDelegate : YSKSpeechRecognitionViewControllerDelegate
    {
        public override void DidChangeLanguage(YSKSpeechRecognitionViewController speechRecognitionViewController, string language)
        {
            
        }

        public override void DidFailWithError(YSKSpeechRecognitionViewController speechRecognitionViewController, NSError error)
        {
            
        }

        public override void DidFinishWithResult(YSKSpeechRecognitionViewController speechRecognitionViewController, string result)
        {
            
        }
    }

    public class CustomRecognizerDelegate : YSKRecognizerDelegate
    {
        public override void Recognizer(YSKRecognizer recognizer, YSKRecognition results)
        {
            
        }

        public override void Recognizer(YSKRecognizer recognizer, NSError error)
        {
            
        }
    }
}
