

namespace Parser2.Parser.PlazaKh
{
    public class KhPlazaSettings : IParserSettings
    {
        public KhPlazaSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public string BaseUrl { get; set; } = "http://www.plaza.kh.ua/notebooks";

        public string Prefix { get; set; } = "page{CurrentId}";

        public int StartPoint { get; set; }

        public int EndPoint { get; set; }
    }
}
