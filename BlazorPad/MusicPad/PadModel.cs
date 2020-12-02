namespace BlazorPad.MusicPad
{
    public class PadModel
    {
        public PadModel(string soundName, string soundLocation, string key)
        {
            SoundName = soundName;
            SoundLocation = soundLocation;
            Key = key;
        }

        public string Id => $"pad-{Key}";
        public string SoundName { get; set; }
        public string SoundLocation { get; set; }
        public string Key { get; set; }
    }
}
