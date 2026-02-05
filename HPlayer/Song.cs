

using Un4seen.Bass.AddOn.Tags;

namespace AudioPlayer
{
    public class Song
    {


        public string Album { get; set; }

        public string Artist { get; set; }

        public string Title { get; set; }

        public string Path { get; set; }

        public string CustomDisplayMember { get; set; }

        public TagPicture TagPicture { get; set; }
    }
}
