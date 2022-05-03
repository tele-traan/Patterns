namespace Observer;

public class BandFan
{
    protected string Name { get; }
    protected MusicBand Band { get; }

    public BandFan(string name, MusicBand band)
    {
        Name = name;
        Band = band;
        band.NotifyAlbumRelease += OnBandAlbumReleased;
    }

    protected virtual void OnBandAlbumReleased(string albumName)
    {
        Console.WriteLine($"{Name} послушал новый альбом {albumName} группы {Band.Name}.");
    }
}