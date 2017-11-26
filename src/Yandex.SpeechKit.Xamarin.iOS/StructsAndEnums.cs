namespace YandexSpeechKit
{
    public enum YSKLogLevel : uint
    {
        Error = 0,
        Warn = 1,
        Info = 2,
        Debug = 3
    }

    public enum _YSKSpeechErrorCode : uint
    {
        Ok = 0,
        APIKey,
        Recording,
        Playing,
        RecordingPermissions,
        AudioInterrupted,
        Encoding,
        Network,
        Server,
        Cancelled,
        NoSpeech,
        NoTextToSynthesize,
        NotAvailable,
        Busy,
        Unknown,
        LanguageNotSupportedForModel
    }
}