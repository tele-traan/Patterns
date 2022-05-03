namespace Observer;

public class HugeFan : BandFan
{
    public HugeFan(string name, MusicBand band) : base(name, band) { }

    protected override void OnBandAlbumReleased(string albumName)
    {
        base.OnBandAlbumReleased(albumName);
        Console.WriteLine("Альбом настолько ему понравился, что он тут же купил билеты на концерт группы.\n");
    }
}