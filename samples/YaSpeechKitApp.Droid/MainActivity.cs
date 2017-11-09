using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

using RU.Yandex.Speechkit;
using RU.Yandex.Speechkit.Gui;

namespace YaSpeechKitApp.Droid
{
    // Port of official example
    // https://github.com/yandexmobile/yandex-speechkit-samples-android/blob/master/vocalizer/src/main/java/com/yandex/speechkit/vocalizersample/VocalizerSampleFragment.java
    [Activity(Label = "YaSpeechKitApp", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity, IVocalizerListener
    {
        private const string API_KEY_FOR_TESTS_ONLY = "069b6659-984b-4c5f-880e-aaedcfd84102";

        private const int REQUEST_CODE = 31;

        private Vocalizer vocalizer;

        public void OnPlayingBegin(Vocalizer p0)
        {
        }

        public void OnPlayingDone(Vocalizer p0)
        {
        }

        public void OnSynthesisBegin(Vocalizer p0)
        {
        }

        public void OnSynthesisDone(Vocalizer p0, Synthesis p1)
        {
        }

        public void OnVocalizerError(Vocalizer p0, Error p1)
        {
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);


            // Configure SpeechKit
            SpeechKit.Instance.Configure(ApplicationContext, API_KEY_FOR_TESTS_ONLY);


            // Get our button from the layout resource,
            // and attach an event to it
            var button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate {

                StartRecognize();

            };
        }

        protected override void OnPause()
        {
            base.OnPause();
            resetVocalizer();
        }

        private void resetVocalizer()
        {
            if (vocalizer != null)
            {
                vocalizer.Cancel();
                vocalizer = null;
            }
        }

        private void StartVocalizer()
        {
            // Reset the current vocalizer.
            resetVocalizer();
            // To create a new vocalizer, specify the language, the text to be vocalized, the auto play parameter
            // and the voice.
            vocalizer = Vocalizer.CreateVocalizer(Vocalizer.Language.Russian, "Привет мир!", true, Vocalizer.Voice.Ermil);
            // Set the listener.
            vocalizer.SetListener(this);
            // Don't forget to call start.
            vocalizer.Start();
        }

        private void StartRecognize()
        {
            // To start recognition create an Intent with required extras.
            Intent intent = new Intent(this, typeof(RecognizerActivity));
            // Specify the model for better results.
            intent.PutExtra(RecognizerActivity.ExtraModel, Recognizer.Model.Queries);
            // Specify the language.
            intent.PutExtra(RecognizerActivity.ExtraLanguage, Recognizer.Language.Russian);
            // To get recognition results use startActivityForResult(),
            // also don't forget to override onActivityResult().
            StartActivityForResult(intent, REQUEST_CODE);
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (requestCode == REQUEST_CODE)
            {
                if ((int)resultCode == RecognizerActivity.ResultOk && data != null)
                {
                    var result = data.GetStringExtra(RecognizerActivity.ExtraResult);
                }
                else if ((int)resultCode == RecognizerActivity.ResultError)
                {
                    string error = data.GetSerializableExtra(RecognizerActivity.ExtraError).ToString();
                }
            }
        }
    }
}

