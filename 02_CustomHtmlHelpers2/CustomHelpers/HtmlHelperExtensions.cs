using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_CustomHtmlHelpers2.CustomHelpers
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlContent Button(this IHtmlHelper helper, string text)
        {
            string buttonHTML = $"<button>{text}</button>";
            HtmlString button = new HtmlString(buttonHTML);
            return button;
        }

        public static IHtmlContent Button(this IHtmlHelper helper, string text, string color)
        {
            string buttonHTML = $"<button style='color:{color}'>{text}</button>";
            HtmlString button = new HtmlString(buttonHTML);
            return button;
        }

        public static IHtmlContent Image(this IHtmlHelper helper, string source, int width, int height)
        {
            //string imageHTML = $"<img src='{source}' width='{width}' height='{height}'/>";
            //return new HtmlString(imageHTML);

            TagBuilder imgBuilder = new TagBuilder("img");
            imgBuilder.Attributes.Add("src", source);
            imgBuilder.Attributes.Add("width", width.ToString());
            imgBuilder.Attributes.Add("height", height.ToString());

            return imgBuilder;
        }
    }
}
