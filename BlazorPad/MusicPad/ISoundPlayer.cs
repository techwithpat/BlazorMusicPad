using System.Threading.Tasks;

namespace BlazorPad.MusicPad
{
    public interface ISoundPlayer
    {
        Task Play(string sound, string pressedPadId);
    }
}
