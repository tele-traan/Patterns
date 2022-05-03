namespace Observer;

public class BigFan : BandFan
{
    public BigFan(string name, MusicBand band) : base(name, band) {}
    protected override void OnBandAlbumReleased(string albumName)
    {
        base.OnBandAlbumReleased(albumName);
        Console.WriteLine($"Ещё несколько раз его послушав, он рассказал о нём всем своим друзьям.\n");
    }
}