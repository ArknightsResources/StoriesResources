namespace ArknightsResources.Stories.Resources.Test
{
    public class ResourceHelperTest
    {
        [Fact]
        public void GetVideo_Success()
        {
            byte[] video = ResourceHelper.Instance.GetVideo("video_event_ic01", ResourceHelper.ChineseSimplifiedCultureInfo);
            Assert.True(video != null);
        }

        [Fact]
        public void GetStoryRawText_Success()
        {
            string text = ResourceHelper.Instance.GetStoryRawText("story_event_whoisreal_8_end", ResourceHelper.ChineseSimplifiedCultureInfo);
            Assert.True(!string.IsNullOrWhiteSpace(text));
        }
    }
}