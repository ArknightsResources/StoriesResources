namespace ArknightsResources.Stories.Resources.Test
{
    public class ResourceHelperTest
    {
        [Fact]
        public void GetVideo_Success()
        {
            byte[] video = ResourceHelper.Instance.GetVideo("video_event_ic01");
            Assert.True(video != null);
        }
    }
}