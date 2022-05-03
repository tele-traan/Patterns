namespace Observer;

public class RegularFan : BandFan
{
    public RegularFan(string name, MusicBand band) : base(name, band) { }

    protected override void OnBandAlbumReleased(string albumName)
    {
        base.OnBandAlbumReleased(albumName);
        Console.WriteLine("\"Среднячок\", - подумал он.\n");
    }
}