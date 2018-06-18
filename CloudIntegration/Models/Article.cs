// This code was generated by a cloud-generators-net tool 
// (see https://github.com/Kentico/cloud-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System.Collections.Generic;
using KenticoCloud.Delivery;

namespace CloudIntegration.Models
{
    public partial class Article
    {
        public const string Codename = "article";
        public const string BodyCodename = "body";
        public const string BlocksCodename = "blocks";
        public const string TitleCodename = "title";
        public const string DisplayTitleCodename = "display_title";

        public string Body { get; set; }
        public IEnumerable<Block> Blocks { get; set; }
        public string Title { get; set; }
        public ContentItemSystemAttributes System { get; set; }
        public string DisplayTitle { get; set; }
    }
}