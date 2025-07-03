using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text;

namespace BORIS.Helpers
{
    public static class HTMLHelperExtensions
    {
        public static IHtmlContent Footer(this IHtmlHelper htmlHelper, List<string> cssClasses)
        {
            var classStr = new StringBuilder();
            foreach (var cl in cssClasses) {
                classStr.Append(cl);
                classStr.Append(" ");
            }

            var privacyLink = htmlHelper.ActionLink("Privacy", "Privacy", "Home");

            string html =
                $"<footer class=\"{classStr.ToString()}\">" +
                $"  <div class=\"container\">" +
                $"      {privacyLink}" +
                $"  </div>" +
                $"</footer>";

            var hcBuilder = new HtmlContentBuilder();

            hcBuilder.AppendHtml($"<footer class=\"{classStr.ToString()}\"><div class=\"container\">");
            hcBuilder.AppendHtml(privacyLink);
            hcBuilder.AppendHtml($"  </div>" +
                $"</footer>");

            return hcBuilder;
            
        }
    }
}
