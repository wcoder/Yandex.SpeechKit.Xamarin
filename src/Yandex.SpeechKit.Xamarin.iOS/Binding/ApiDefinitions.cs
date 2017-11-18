using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace YandexSpeechKit
{
    [Static]
    partial interface Constants
    {
    	// extern NSString *const YSKSoundFormat;
    	[Field ("YSKSoundFormat", "__Internal")]
    	NSString YSKSoundFormat { get; }

    	// extern NSString *const YSKEncodingQuality;
    	[Field ("YSKEncodingQuality", "__Internal")]
    	NSString YSKEncodingQuality { get; }

    	// extern NSString *const YSKDisableAntimat;
    	[Field ("YSKDisableAntimat", "__Internal")]
    	NSString YSKDisableAntimat { get; }

    	// extern NSString *const YSKEnablePunctuation;
    	[Field ("YSKEnablePunctuation", "__Internal")]
    	NSString YSKEnablePunctuation { get; }

    	// extern NSString *const YSKSilenceBetweenUtterances;
    	[Field ("YSKSilenceBetweenUtterances", "__Internal")]
    	NSString YSKSilenceBetweenUtterances { get; }

        // extern NSString *const YSKSpeechKitErrorDomain;
        [Field("YSKSpeechKitErrorDomain", "__Internal")]
        NSString YSKSpeechKitErrorDomain { get; }

        // extern NSString *const YSKVocalizerVoiceErmil;
        [Field("YSKVocalizerVoiceErmil", "__Internal")]
        NSString YSKVocalizerVoiceErmil { get; }

        // extern NSString *const YSKVocalizerVoiceZahar;
        [Field("YSKVocalizerVoiceZahar", "__Internal")]
        NSString YSKVocalizerVoiceZahar { get; }

        // extern NSString *const YSKVocalizerVoiceJane;
        [Field("YSKVocalizerVoiceJane", "__Internal")]
        NSString YSKVocalizerVoiceJane { get; }

        // extern NSString *const YSKVocalizerVoiceAlyss;
        [Field("YSKVocalizerVoiceAlyss", "__Internal")]
        NSString YSKVocalizerVoiceAlyss { get; }

        // extern NSString *const YSKVocalizerVoiceOmazh;
        [Field("YSKVocalizerVoiceOmazh", "__Internal")]
        NSString YSKVocalizerVoiceOmazh { get; }

        // extern NSString *const YSKVocalizerLanguageEnglish;
        [Field("YSKVocalizerLanguageEnglish", "__Internal")]
        NSString YSKVocalizerLanguageEnglish { get; }

        // extern NSString *const YSKVocalizerLanguageTurkish;
        [Field("YSKVocalizerLanguageTurkish", "__Internal")]
        NSString YSKVocalizerLanguageTurkish { get; }

        // extern NSString *const YSKVocalizerLanguageUkrainian;
        [Field("YSKVocalizerLanguageUkrainian", "__Internal")]
        NSString YSKVocalizerLanguageUkrainian { get; }

        // extern NSString *const YSKVocalizerLanguageRussian;
        [Field("YSKVocalizerLanguageRussian", "__Internal")]
        NSString YSKVocalizerLanguageRussian { get; }

        // extern NSString *const YSKRecognitionModelBuying;
        [Field("YSKRecognitionModelBuying", "__Internal")]
        NSString YSKRecognitionModelBuying { get; }

        // extern NSString *const YSKRecognitionModelDates;
        [Field("YSKRecognitionModelDates", "__Internal")]
        NSString YSKRecognitionModelDates { get; }

        // extern NSString *const YSKRecognitionModelFreeform;
        [Field("YSKRecognitionModelFreeform", "__Internal")]
        NSString YSKRecognitionModelFreeform { get; }

        // extern NSString *const YSKRecognitionModelGeneral;
        [Field("YSKRecognitionModelGeneral", "__Internal")]
        NSString YSKRecognitionModelGeneral { get; }

        // extern NSString *const YSKRecognitionModelMaps;
        [Field("YSKRecognitionModelMaps", "__Internal")]
        NSString YSKRecognitionModelMaps { get; }

        // extern NSString *const YSKRecognitionModelMusic;
        [Field("YSKRecognitionModelMusic", "__Internal")]
        NSString YSKRecognitionModelMusic { get; }

        // extern NSString *const YSKRecognitionModelNames;
        [Field("YSKRecognitionModelNames", "__Internal")]
        NSString YSKRecognitionModelNames { get; }

        // extern NSString *const YSKRecognitionModelNotes;
        [Field("YSKRecognitionModelNotes", "__Internal")]
        NSString YSKRecognitionModelNotes { get; }

        // extern NSString *const YSKRecognitionModelNumbers;
        [Field("YSKRecognitionModelNumbers", "__Internal")]
        NSString YSKRecognitionModelNumbers { get; }

        // extern NSString *const YSKRecognitionModelQueries;
        [Field("YSKRecognitionModelQueries", "__Internal")]
        NSString YSKRecognitionModelQueries { get; }

        // extern NSString *const YSKRecognitionLanguageEnglish;
        [Field("YSKRecognitionLanguageEnglish", "__Internal")]
        NSString YSKRecognitionLanguageEnglish { get; }

        // extern NSString *const YSKRecognitionLanguageRussian;
        [Field("YSKRecognitionLanguageRussian", "__Internal")]
        NSString YSKRecognitionLanguageRussian { get; }

        // extern NSString *const YSKRecognitionLanguageTurkish;
        [Field("YSKRecognitionLanguageTurkish", "__Internal")]
        NSString YSKRecognitionLanguageTurkish { get; }

        // extern NSString *const YSKRecognitionLanguageUkrainian;
        [Field("YSKRecognitionLanguageUkrainian", "__Internal")]
        NSString YSKRecognitionLanguageUkrainian { get; }
    }

    // @interface YSKSpeechKit : NSObject
    [BaseType (typeof(NSObject))]
    interface YSKSpeechKit
    {
    	// +(NSString *)speechkitVersion;
    	[Static]
    	[Export ("speechkitVersion")]
    	string SpeechkitVersion { get; }

    	// +(instancetype)sharedInstance;
    	[Static]
    	[Export ("sharedInstance")]
    	YSKSpeechKit SharedInstance ();

    	// -(void)configureWithAPIKey:(NSString *)apiKey;
    	[Export ("configureWithAPIKey:")]
    	void ConfigureWithAPIKey (string apiKey);

    	// -(void)configureWithAPIKey:(NSString *)apiKey andLocationProvider:(id<YSKLocationProvider>)locationProvider;
    	[Export ("configureWithAPIKey:andLocationProvider:")]
    	void ConfigureWithAPIKey (string apiKey, YSKLocationProvider locationProvider);

    	// -(void)setParameter:(NSString *)name withValue:(NSString *)value;
    	[Export ("setParameter:withValue:")]
    	void SetParameter (string name, string value);

    	// -(NSString *)getParameterValue:(NSString *)name;
    	[Export ("getParameterValue:")]
    	string GetParameterValue (string name);

    	// -(NSString *)getAPIKey;
    	[Export ("getAPIKey")]
    	string APIKey { get; }

    	// -(NSArray *)getSupportedLanguages:(NSString *)model;
    	[Export ("getSupportedLanguages:")]
    	NSObject[] GetSupportedLanguages (string model);

    	// -(NSString *)getUuid;
    	[Export ("getUuid")]
    	string Uuid { get; }

    	// -(void)setLogLevel:(YSKLogLevel)logLevel;
    	[Export ("setLogLevel:")]
    	void SetLogLevel (int logLevel);
    }


    // @interface YSKError : NSError
    [BaseType (typeof(NSError))]
    interface YSKError
    {
    	// +(NSError *)errorWithErrorCode:(enum YSKSpeechErrorCode)code;
    	//[Static]
    	[Export ("errorWithErrorCode:")]
    	NSError ErrorWithErrorCode (YSKSpeechErrorCode code);
    }

    // @interface YSKInitializer : NSObject
    [BaseType (typeof(NSObject))]
    interface YSKInitializer
    {
    	[Wrap ("WeakDelegate")]
    	YSKInitializerDelegate Delegate { get; set; }

    	// @property (nonatomic, weak) id<YSKInitializerDelegate> delegate;
    	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    	NSObject WeakDelegate { get; set; }

    	// -(void)dealloc;
    	[Export ("dealloc")]
    	void Dealloc ();

    	// -(void)start;
    	[Export ("start")]
    	void Start ();

    	// +(BOOL)isInitializationCompleted;
    	[Static]
    	[Export ("isInitializationCompleted")]
    	bool IsInitializationCompleted { get; }
    }

    // @protocol YSKInitializerDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface YSKInitializerDelegate
    {
    	// @optional -(void)initializerDidBegin:(YSKInitializer *)initializer;
    	[Export ("initializerDidBegin:")]
    	void InitializerDidBegin (YSKInitializer initializer);

    	// @optional -(void)initializerDidFinish:(YSKInitializer *)initializer;
    	[Export ("initializerDidFinish:")]
    	void InitializerDidFinish (YSKInitializer initializer);

    	// @optional -(void)initializer:(YSKInitializer *)initializer didFailWithError:(NSError *)error;
    	[Export ("initializer:didFailWithError:")]
    	void Initializer (YSKInitializer initializer, NSError error);
    }

    // @protocol YSKLocationProvider <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface YSKLocationProvider
    {
    	// @required -(CLLocation *)getLocation;
    	[Abstract]
    	[Export ("getLocation")]
    	CLLocation Location { get; }
    }

    // @interface YSKPhraseSpotter : NSObject
    [BaseType (typeof(NSObject))]
    interface YSKPhraseSpotter
    {
    	// +(NSError *)setModel:(YSKPhraseSpotterModel *)model;
    	[Static]
    	[Export ("setModel:")]
    	NSError SetModel (YSKPhraseSpotterModel model);

    	// +(NSError *)start;
    	[Static]
    	[Export ("start")]
    	NSError Start { get; }

    	// +(NSError *)stop;
    	[Static]
    	[Export ("stop")]
    	NSError Stop { get; }

    	// +(BOOL)isRunning;
    	[Static]
    	[Export ("isRunning")]
    	bool IsRunning { get; }

    	// +(void)setDelegate:(id<YSKPhraseSpotterDelegate>)delegate;
    	[Static]
    	[Export ("setDelegate:")]
    	void SetDelegate (YSKPhraseSpotterDelegate @delegate);
    }

    // @protocol YSKPhraseSpotterDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface YSKPhraseSpotterDelegate
    {
    	// @optional -(void)phraseSpotterDidStarted;
    	[Export ("phraseSpotterDidStarted")]
    	void PhraseSpotterDidStarted ();

    	// @optional -(void)phraseSpotterDidStopped;
    	[Export ("phraseSpotterDidStopped")]
    	void PhraseSpotterDidStopped ();

    	// @optional -(void)phraseSpotterDidSpotPhrase:(NSString *)phrase withIndex:(int)phraseIndex;
    	[Export ("phraseSpotterDidSpotPhrase:withIndex:")]
    	void PhraseSpotterDidSpotPhrase (string phrase, int phraseIndex);

    	// @optional -(void)phraseSpotterDidFailWithError:(NSError *)error;
    	[Export ("phraseSpotterDidFailWithError:")]
    	void PhraseSpotterDidFailWithError (NSError error);
    }

    // @interface YSKPhraseSpotterModel : NSObject
    [BaseType (typeof(NSObject))]
    interface YSKPhraseSpotterModel
    {
    	// -(id)initWithConfigDirectory:(NSString *)configDirectory;
    	[Export ("initWithConfigDirectory:")]
    	IntPtr Constructor (string configDirectory);

    	// -(NSError *)load;
    	[Export ("load")]
    	NSError Load { get; }

    	// -(NSError *)unload;
    	[Export ("unload")]
    	NSError Unload { get; }

    	// -(void)finalize;
    	[Export ("finalize")]
    	void Finalize ();
    }

    // @interface YSKRecognition : NSObject
    [BaseType (typeof(NSObject))]
    interface YSKRecognition
    {
    	// @property (readonly, copy, nonatomic) NSArray * hypotheses;
    	[Export ("hypotheses", ArgumentSemantic.Copy)]
    	NSObject[] Hypotheses { get; }

    	// @property (readonly, retain, nonatomic) NSString * bestResultText;
    	[Export ("bestResultText", ArgumentSemantic.Retain)]
    	string BestResultText { get; }

    	// -(instancetype)initWithHypotheses:(NSArray *)hypotheses;
    	[Export ("initWithHypotheses:")]
    	IntPtr Constructor (NSObject[] hypotheses);

    	// -(NSString *)description;
    	[Export ("description")]
    	string Description { get; }
    }

    // @interface YSKRecognitionHypothesis : NSObject
    [BaseType (typeof(NSObject))]
    interface YSKRecognitionHypothesis
    {
    	// @property (readonly, assign, nonatomic) float confidence;
    	[Export ("confidence")]
    	float Confidence { get; }

    	// @property (readonly, copy, nonatomic) NSString * normalized;
    	[Export ("normalized")]
    	string Normalized { get; }

    	// @property (readonly, copy, nonatomic) NSArray * words;
    	[Export ("words", ArgumentSemantic.Copy)]
    	NSObject[] Words { get; }

    	// -(instancetype)initWithWords:(NSArray *)words normalizedText:(NSString *)normalized confidence:(float)confidence;
    	[Export ("initWithWords:normalizedText:confidence:")]
    	IntPtr Constructor (NSObject[] words, string normalized, float confidence);

    	// -(NSString *)description;
    	[Export ("description")]
    	string Description { get; }
    }

    // @interface YSKRecognitionWord : NSObject
    [BaseType (typeof(NSObject))]
    interface YSKRecognitionWord
    {
    	// @property (readonly, copy, nonatomic) NSString * text;
    	[Export ("text")]
    	string Text { get; }

    	// @property (readonly, assign, nonatomic) float confidence;
    	[Export ("confidence")]
    	float Confidence { get; }

    	// -(instancetype)initWithText:(NSString *)text confidence:(float)confidence;
    	[Export ("initWithText:confidence:")]
    	IntPtr Constructor (string text, float confidence);

    	// -(NSString *)description;
    	[Export ("description")]
    	string Description { get; }
    }

    // @interface YSKRecognizer : NSObject
    [BaseType (typeof(NSObject))]
    interface YSKRecognizer
    {
    	[Wrap ("WeakDelegate")]
    	YSKRecognizerDelegate Delegate { get; set; }

    	// @property (nonatomic, weak) id<YSKRecognizerDelegate> delegate;
    	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    	NSObject WeakDelegate { get; set; }

    	// -(instancetype)initWithLanguage:(NSString *)language model:(NSString *)model;
    	[Export ("initWithLanguage:model:")]
    	IntPtr Constructor (string language, string model);

    	// -(instancetype)initWithLanguage:(NSString *)language model:(NSString *)model continuousMode:(BOOL)continuousMode;
    	[Export ("initWithLanguage:model:continuousMode:")]
    	IntPtr Constructor (string language, string model, bool continuousMode);

    	// -(void)dealloc;
    	[Export ("dealloc")]
    	void Dealloc ();

    	// +(BOOL)isRecognitionAvailable;
    	[Static]
    	[Export ("isRecognitionAvailable")]
    	bool IsRecognitionAvailable { get; }

    	// -(void)start;
    	[Export ("start")]
    	void Start ();

    	// -(void)finishRecording;
    	[Export ("finishRecording")]
    	void FinishRecording ();

    	// -(void)cancel;
    	[Export ("cancel")]
    	void Cancel ();

    	// -(void)mute;
    	[Export ("mute")]
    	void Mute ();

    	// -(void)unmute;
    	[Export ("unmute")]
    	void Unmute ();

    	// @property (readonly, getter = getLanguge, assign, nonatomic) NSString * language;
    	[Export ("language")]
    	string Language { [Bind ("getLanguge")] get; }

    	// @property (readonly, getter = getModel, assign, nonatomic) NSString * model;
    	[Export ("model")]
    	string Model { [Bind ("getModel")] get; }

    	// @property (getter = isVADEnabled, assign, readwrite, nonatomic) BOOL VADEnabled;
    	[Export ("VADEnabled")]
    	bool VADEnabled { [Bind ("isVADEnabled")] get; set; }
    }

    // @protocol YSKRecognizerDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface YSKRecognizerDelegate
    {
    	// @optional -(void)recognizerDidStartRecording:(YSKRecognizer *)recognizer;
    	[Export ("recognizerDidStartRecording:")]
    	void RecognizerDidStartRecording (YSKRecognizer recognizer);

    	// @optional -(void)recognizerDidDetectSpeech:(YSKRecognizer *)recognizer;
    	[Export ("recognizerDidDetectSpeech:")]
    	void RecognizerDidDetectSpeech (YSKRecognizer recognizer);

    	// @optional -(void)recognizerDidDetectSpeechEnd:(YSKRecognizer *)recognizer;
    	[Export ("recognizerDidDetectSpeechEnd:")]
    	void RecognizerDidDetectSpeechEnd (YSKRecognizer recognizer);

    	// @optional -(void)recognizerDidFinishRecording:(YSKRecognizer *)recognizer;
    	[Export ("recognizerDidFinishRecording:")]
    	void RecognizerDidFinishRecording (YSKRecognizer recognizer);

    	// @optional -(void)recognizer:(YSKRecognizer *)recognizer didRecordSoundData:(NSData *)data;
    	[Export ("recognizer:didRecordSoundData:")]
    	void Recognizer (YSKRecognizer recognizer, NSData data);

    	// @optional -(void)recognizer:(YSKRecognizer *)recognizer didUpdatePower:(float)power;
    	[Export ("recognizer:didUpdatePower:")]
    	void Recognizer (YSKRecognizer recognizer, float power);

    	// @optional -(void)recognizer:(YSKRecognizer *)recognizer didReceivePartialResults:(YSKRecognition *)results withEndOfUtterance:(BOOL)endOfUtterance;
    	[Export ("recognizer:didReceivePartialResults:withEndOfUtterance:")]
    	void Recognizer (YSKRecognizer recognizer, YSKRecognition results, bool endOfUtterance);

    	// @optional -(void)recognizer:(YSKRecognizer *)recognizer didCompleteWithResults:(YSKRecognition *)results;
    	[Export ("recognizer:didCompleteWithResults:")]
    	void Recognizer (YSKRecognizer recognizer, YSKRecognition results);

    	// @optional -(void)recognizer:(YSKRecognizer *)recognizer didFailWithError:(NSError *)error;
    	[Export ("recognizer:didFailWithError:")]
    	void Recognizer (YSKRecognizer recognizer, NSError error);
    }

    // @interface YSKSpeechRecognitionViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface YSKSpeechRecognitionViewController
    {
        [Wrap("WeakDelegate")]
        YSKSpeechRecognitionViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<YSKSpeechRecognitionViewControllerDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) BOOL partialResultsDisplayEnabled;
        [Export("partialResultsDisplayEnabled")]
        bool PartialResultsDisplayEnabled { get; set; }

        // @property (assign, nonatomic) BOOL resultsListDisplayEnabled;
        [Export("resultsListDisplayEnabled")]
        bool ResultsListDisplayEnabled { get; set; }

        // -(instancetype)initWithLanguage:(NSString *)language model:(NSString *)model;
        [Export("initWithLanguage:model:")]
        IntPtr Constructor(string language, string model);

        // -(instancetype)initWithModel:(NSString *)model;
        [Export("initWithModel:")]
        IntPtr Constructor(string model);

        // +(BOOL)isRecognitionAvailable;
        [Static]
        [Export("isRecognitionAvailable")]
        bool IsRecognitionAvailable { get; }

        // -(void)cancel;
        [Export("start")]
        void Start();

        // -(void)cancel;
        [Export("cancel")]
        void Cancel();
    }

    // @protocol YSKSpeechRecognitionViewControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface YSKSpeechRecognitionViewControllerDelegate
    {
    	// @required -(void)speechRecognitionViewController:(YSKSpeechRecognitionViewController *)speechRecognitionViewController didFinishWithResult:(NSString *)result;
    	[Abstract]
    	[Export ("speechRecognitionViewController:didFinishWithResult:")]
    	void DidFinishWithResult (YSKSpeechRecognitionViewController speechRecognitionViewController, string result);

    	// @required -(void)speechRecognitionViewController:(YSKSpeechRecognitionViewController *)speechRecognitionViewController didChangeLanguage:(NSString *)language;
    	[Abstract]
    	[Export ("speechRecognitionViewController:didChangeLanguage:")]
    	void DidChangeLanguage (YSKSpeechRecognitionViewController speechRecognitionViewController, string language);

    	// @required -(void)speechRecognitionViewController:(YSKSpeechRecognitionViewController *)speechRecognitionViewController didFailWithError:(NSError *)error;
    	[Abstract]
    	[Export ("speechRecognitionViewController:didFailWithError:")]
    	void DidFailWithError (YSKSpeechRecognitionViewController speechRecognitionViewController, NSError error);
    }

    // @interface YSKVocalizer : NSObject
    [BaseType (typeof(NSObject))]
    interface YSKVocalizer
    {
    	[Wrap ("WeakDelegate")]
    	YSKVocalizerDelegate Delegate { get; set; }

    	// @property (assign, nonatomic) id<YSKVocalizerDelegate> delegate;
    	[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
    	NSObject WeakDelegate { get; set; }

    	// @property (retain, nonatomic) NSString * text;
    	[Export ("text", ArgumentSemantic.Retain)]
    	string Text { get; set; }

    	// -(id)initWithText:(NSString *)text language:(NSString *)language;
    	[Export ("initWithText:language:")]
    	IntPtr Constructor (string text, string language);

    	// -(id)initWithText:(NSString *)text language:(NSString *)language autoPlay:(BOOL)autoPlay;
    	[Export ("initWithText:language:autoPlay:")]
    	IntPtr Constructor (string text, string language, bool autoPlay);

    	// -(id)initWithText:(NSString *)text language:(NSString *)language autoPlay:(BOOL)autoPlay voice:(NSString *)voice;
    	[Export ("initWithText:language:autoPlay:voice:")]
    	IntPtr Constructor (string text, string language, bool autoPlay, string voice);

    	// -(void)start;
    	[Export ("start")]
    	void Start ();

    	// -(void)cancel;
    	[Export ("cancel")]
    	void Cancel ();

    	// -(void)play;
    	[Export ("play")]
    	void Play ();
    }

    // @protocol YSKVocalizerDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface YSKVocalizerDelegate
    {
    	// @optional -(void)vocalizerDidBeginSynthesis:(YSKVocalizer *)vocalizer;
    	[Export ("vocalizerDidBeginSynthesis:")]
    	void VocalizerDidBeginSynthesis (YSKVocalizer vocalizer);

    	// @optional -(void)vocalizer:(YSKVocalizer *)vocalizer didFinishSynthesisWithResult:(NSData *)result markerIds:(NSArray *)markerIds markerMsecs:(NSArray *)markerMsecs;
    	[Export ("vocalizer:didFinishSynthesisWithResult:markerIds:markerMsecs:")]
    	void Vocalizer (YSKVocalizer vocalizer, NSData result, NSObject[] markerIds, NSObject[] markerMsecs);

    	// @optional -(void)vocalizerDidStartPlaying:(YSKVocalizer *)vocalizer;
    	[Export ("vocalizerDidStartPlaying:")]
    	void VocalizerDidStartPlaying (YSKVocalizer vocalizer);

    	// @optional -(void)vocalizerDidFinishPlaying:(YSKVocalizer *)vocalizer;
    	[Export ("vocalizerDidFinishPlaying:")]
    	void VocalizerDidFinishPlaying (YSKVocalizer vocalizer);

    	// @optional -(void)vocalizer:(YSKVocalizer *)vocalizer didFailWithError:(NSError *)error;
    	[Export ("vocalizer:didFailWithError:")]
    	void Vocalizer (YSKVocalizer vocalizer, NSError error);
    }

}
