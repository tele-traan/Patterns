namespace Observer;

public class MusicBand
{
    public event HandleAlbumRelease? NotifyAlbumRelease;
    public string Name { get; }

    public MusicBand(string name)
    {
        Name = name;
    }

    public void ReleaseNewAlbum(string albumName)
    {
        Console.WriteLine($"Группа {Name} выпустила новый альбом {albumName}");
        NotifyAlbumRelease?.Invoke(albumName);
    }
}