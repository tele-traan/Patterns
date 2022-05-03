using Observer;

MusicBand motorhead = new("Motörhead");
MusicBand rammstein = new("Rammstein");
MusicBand acdc = new("AC/DC");

RegularFan ivan = new("Иван Моторов", motorhead);
RegularFan vasya = new("Василий Рамменко", rammstein);
RegularFan sasha = new("Александр Эйсидисевич", acdc);

BigFan lesha = new("Алексей Моторноголовый", motorhead);
BigFan egor = new("Егор Штайнраммов", rammstein);
BigFan ruslan = new("Руслан Эйсидисенко", acdc);

HugeFan timur = new ("Тимур Моторхедов", motorhead);
HugeFan grisha = new("Григорий Линдеманн", rammstein);
HugeFan sergey = new("Сергей Электрик", acdc);

motorhead.ReleaseNewAlbum("Motorizer");
rammstein.ReleaseNewAlbum("Herzeleid");
acdc.ReleaseNewAlbum("Rock or Bust");