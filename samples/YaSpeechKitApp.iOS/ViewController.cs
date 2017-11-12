using System;

using UIKit;
using YandexSpeechKit;

namespace YaSpeechKitApp.iOS
{
    public partial class ViewController : UIViewController
    {
        private YSKSpeechRecognitionViewController _recognizerViewController;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            StartSpeechRecogrision();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }


        private void StartSpeechRecogrision()
        {
            _recognizerViewController = new YSKSpeechRecognitionViewController("ru-RU", "general");

            PresentViewController(_recognizerViewController, true, () =>
            {
            
            });

            _recognizerViewController.Start();

        }
    }
}
