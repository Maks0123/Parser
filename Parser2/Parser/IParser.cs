using AngleSharp.Dom.Html;

namespace Parser2.Parser
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
