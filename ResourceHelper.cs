using ArknightsResources.CustomResourceHelpers;
using System;
using System.Globalization;
using StoryResources = ArknightsResources.Stories.Resources.Properties.Resources;

namespace ArknightsResources.Stories.Resources
{
    /// <summary>
    /// 为ArknightsResources.Stories.Resources的资源访问提供帮助的类
    /// </summary>
    public class ResourceHelper : StoryResourceHelper
    {
        /// <summary>
        /// <seealso cref="ResourceHelper"/>的实例
        /// </summary>
        public static readonly ResourceHelper Instance = new ResourceHelper();

        /// <inheritdoc/>
        /// <exception cref="ArgumentException"></exception>
        public override string GetStoryText(string codename, CultureInfo cultureInfo)
        {
            if (string.IsNullOrWhiteSpace(codename))
            {
                throw new ArgumentException($"“{nameof(codename)}”不能为 null 或空白。", nameof(codename));
            }

            try
            {
                string text = StoryResources.ResourceManager.GetString(codename, cultureInfo);
                return text;
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"使用给定的参数\"{codename}\"时找不到资源", ex);
            }
        }
    }
}
