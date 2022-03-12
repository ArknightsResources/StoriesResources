using System;
using System.Globalization;
using StoryResources = ArknightsResources.Stories.Resources.Properties.Resources;

namespace ArknightsResources.Stories.Resources
{
    /// <summary>
    /// 为ArknightsResources.Stories.Resources的资源访问提供帮助的类
    /// </summary>
    public static class ResourceHelper
    {
        /// <summary>
        /// 通过剧情文件的代号获取该剧情的原始剧情文本
        /// </summary>
        /// <param name="codename">剧情文件的代号</param>
        /// <param name="cultureInfo"></param>
        /// <returns>原始剧情文本</returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetStoryText(string codename, CultureInfo cultureInfo)
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
