class Program
{
    static void Main(string[] args)
    {
        SmartTextReader smartTextReader = new SmartTextReader();
        SmartTextChecker smartTextChecker = new SmartTextChecker(smartTextReader);
        SmartTextReaderLocker smartTextReaderLocker = new SmartTextReaderLocker(smartTextChecker, @"^C:\\doc\\");

        char[][] text = smartTextReaderLocker.ReadText("C:\\doc\\file.txt");
    }
}
