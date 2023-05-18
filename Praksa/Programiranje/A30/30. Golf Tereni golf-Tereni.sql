CREATE TABLE grad (
	grad_id INT PRIMARY KEY,
	grad NVARCHAR(50) NOT NULL,
	pozivni_broj NVARCHAR(3) NOT NULL,
	postanski_broj INT  NOT NULL,
	broj_stanovnika INT NOT NULL
);

CREATE TABLE igrac (
	igrac_id INT PRIMARY KEY,
	ime NVARCHAR(15) NOT NULL,
	prezime NVARCHAR(20) NOT NULL,
	adresa NVARCHAR(50) NOT NULL,
	grad_id INT NOT NULL REFERENCES grad(grad_id),
	email NVARCHAR(50) NOT NULL,
	telefon NVARCHAR(20) NOT NULL
);

CREATE TABLE teren (
	teren_id INT PRIMARY KEY,
	teren NVARCHAR(30) NOT NULL,
	adresa NVARCHAR(50) NOT NULL,
	grad_id INT NOT NULL REFERENCES grad(grad_id),
	kontakt_telefon NVARCHAR(20) NOT NULL
);

CREATE TABLE partija (
	partija_id INT PRIMARY KEY,
	teren_id INT NOT NULL REFERENCES teren(teren_id),
	datum DATE NOT NULL,
	vreme_pocetka DATETIME,
	vreme_kraja DATETIME,
	uslovi NVARCHAR(15),
	CHECK(vreme_pocetka <= vreme_kraja)
);

CREATE TABLE igraju (
	partija_id INT REFERENCES partija(partija_id),
	igrac_id INT REFERENCES igrac(igrac_id),
	PRIMARY KEY(partija_id,igrac_id)
);

CREATE TABLE rupa (
	br_rupe INT PRIMARY KEY,
	pozicija NVARCHAR(20) NOT NULL,
	udaljenost INT NOT NULL,
	udarci INT NOT NULL,
	teren_id INT NOT NULL REFERENCES teren(teren_id)
);

CREATE TABLE rezultat (
	igrac_id INT REFERENCES igrac(igrac_id),
	br_rupe INT REFERENCES rupa(br_rupe),
	partija_id INT REFERENCES partija(partija_id),
	skor INT NOT NULL,
	PRIMARY KEY(igrac_id,br_rupe,partija_id)
);

/*    PROSIRENJE     */
CREATE TABLE Sudija (
  ID INT PRIMARY KEY,
  ime VARCHAR(50),
  prezime VARCHAR(50),
  adresa VARCHAR(100),
  telefon VARCHAR(20),
  email VARCHAR(50)
);

/*    PROSIRENJE     */
CREATE TABLE Sudija_Teren (
  Sudija_ID INT,
  Teren_ID INT,
  PRIMARY KEY (sudija_id, teren_id),
  FOREIGN KEY (Sudija_ID) REFERENCES Sudija(ID),
  FOREIGN KEY (Teren_ID) REFERENCES Teren(teren_id)
);

/*    PROSIRENJE     */
ALTER TABLE Teren ADD kategorija VARCHAR(50);

INSERT INTO grad
VALUES (1,'Kragujevac',034,34000,150835);
INSERT INTO grad
VALUES (2,'Niš', 018, 18101, 183164);
INSERT INTO grad
VALUES (3,'Novi Sad', 021, 21101, 277522);
INSERT INTO grad
VALUES (4,'Beograd', 011, 11000, 1233796);
INSERT INTO grad
VALUES (5,'Kraljevo',036,36000,68749);
INSERT INTO grad
VALUES (6,'Čačak', 032, 32101, 73331);
INSERT INTO grad
VALUES (7,'Subotica', 024, 24000, 105681);
INSERT INTO grad
VALUES (8,'Novi Pazar', 020, 36300, 66527);
INSERT INTO grad
VALUES (9,'Zrenjanin', 023, 23101, 76511);
INSERT INTO grad
VALUES (10,'Jagodina', 035, 35000, 76712);


INSERT INTO igrac
VALUES (1, 'Miloš', 'Perić', 'Dositejeva 36', 1, 'milosp@gmail.com', '0645322541');
INSERT INTO igrac
VALUES (2, 'Gordana', 'Perović', 'Karađorđeva 75', 1, 'gordanap@gmail.com', '066787656');
INSERT INTO igrac
VALUES (3, 'Miloš', 'Atanasković', 'Aleksinačka 11', 2, 'milosa@gmail.com', '062564512');
INSERT INTO igrac
VALUES (4, 'Biljana', 'Milošević', 'Fruškogorska 37', 3, 'biljanam@gmail.com', '069563423');
INSERT INTO igrac
VALUES (5, 'Dejan', 'Aleksić', 'Trg slobode 4', 3, 'dejana@gmail.com', '0623211268');
INSERT INTO igrac
VALUES (6, 'Geret', 'Bejl', 'Bulevar kralja Aleksandra', 5, 'gbale@gmail.com', '0678456135');
INSERT INTO igrac
VALUES (7, 'Nikola', 'Avramović', 'Generala Bože Jankovića 4', 4, 'nikolaa@gmail.com', '060312323');
INSERT INTO igrac
VALUES (8, 'Milutin', 'Savić', 'Bulevar Vuka Karadžića', 6, 'milutins@gmail.com', '06233675');
INSERT INTO igrac
VALUES (9, 'Aleksandar', 'Dačić', 'Bulevar Mihajla Pupina', 5, 'aleksd@gmail.com', '069678608');
INSERT INTO igrac
VALUES (10, 'Stefan', 'Janković', 'Stevana Nemanje 2', 7, 'stefanj@gmail.com', '0685123136');
INSERT INTO igrac
VALUES (11, 'Janko', 'Stojković', 'Bose Milićević 31', 8, 'jankos@gmail.com', '0632167698');
INSERT INTO igrac
VALUES (12, 'Matija', 'Milunović', 'Omladinskih brigada', 5, 'matijam@gmail.com', '0632348962');
INSERT INTO igrac
VALUES (13, 'Bojan', 'Pejović', 'Mane Majstorović 6', 9, 'bojanp@gmail.com', '0687156332');
INSERT INTO igrac
VALUES (14, 'Nemanja', 'Stevanović', 'Kralja Petra Prvog 6', 10, 'nemanjas@gmail.com', '0645441325');
INSERT INTO igrac
VALUES (15, 'Zdravko', 'Milošević', 'Fruškogorska 37', 3, 'zdravkom@gmail.com', '0692334423');


INSERT INTO teren
VALUES (1, 'Karadjordje', 'Kraljevacka', 1, '0645214369');
INSERT INTO teren
VALUES (2, 'Jagodina kantri klub', 'Makedonska', 2, '0622236532');
INSERT INTO teren
VALUES (3, 'Novosadskih', 'Zmaj Jovina 4', 3, '0632136594');
INSERT INTO teren
VALUES (4, 'Sveti Jovan', 'Mlavska 1', 4, '0612653652');
INSERT INTO teren
VALUES (5, 'Aleksandar Veliki', 'Strahinjića Bana', 5, '0665984213');
INSERT INTO teren
VALUES (6, 'Pobednik', 'Avalska 12', 6, '0621544852');
INSERT INTO teren
VALUES (7, 'Nacional', 'Nemanjina', 7, '0678544213');
INSERT INTO teren
VALUES (8, 'Brdašce', 'Stevana Nemanje', 8, '0645523659');
INSERT INTO teren
VALUES (9, 'Novoseoski', 'Adačka', 9, '0632236585');
INSERT INTO teren
VALUES (10, 'Kablar', 'Melenačka', 10, '0695564235');




INSERT INTO partija
VALUES (1, 1, convert(date,'2020-04-30'), convert(datetime,'30-04-20 10:50:09 AM',5), convert(datetime,'30-04-20 11:50:09 AM',5), 'Kiša');
INSERT INTO partija
VALUES (2, 1, convert(date,'2020-05-14'), convert(datetime,'14-05-20 09:05:00 AM',5), convert(datetime,'14-05-20 11:25:39 AM',5), 'Oblačno');
INSERT INTO partija
VALUES (3, 1, convert(date,'2020-05-05'), convert(datetime,'05-05-20 10:00:00 AM',5), convert(datetime,'05-05-20 11:24:38 PM',5), 'Sunčano');
INSERT INTO partija
VALUES (4, 3, convert(date,'2020-04-25'), convert(datetime,'25-04-20 11:25:00 AM',5), convert(datetime,'25-04-20 11:32:41 PM',5), 'Kiša');
INSERT INTO partija
VALUES (5, 3, convert(date,'2020-04-30'), convert(datetime,'30-04-20 11:00:00 AM',5), convert(datetime,'30-04-20 11:32:39 PM',5), 'Oblačno');
INSERT INTO partija
VALUES (6, 6, convert(date,'2020-05-14'), convert(datetime,'14-05-20 08:15:20 AM',5), convert(datetime,'14-05-20 11:52:45 PM',5), 'Sunčano');
INSERT INTO partija
VALUES (7, 7, convert(date,'2020-05-23'), convert(datetime,'23-05-20 10:30:00 AM',5), convert(datetime,'23-05-20 11:34:12 PM',5), 'Sunčano');
INSERT INTO partija
VALUES (8, 5, convert(date,'2020-05-24'), convert(datetime,'24-05-20 8:00:00 AM',5), convert(datetime,'25-05-20 10:39:24 AM',5), 'Sunčano');
INSERT INTO partija
VALUES (9, 6, convert(date,'2020-05-01'), convert(datetime,'01-05-20 11:10:00 AM',5), convert(datetime,'01-05-20 5:56:43 PM',5), 'Sunčano');
INSERT INTO partija
VALUES (10, 6, convert(date,'2020-05-31'), convert(datetime,'31-05-20 07:30:00 AM',5), convert(datetime,'31-05-20 11:48:23 AM',5), 'Kiša');
INSERT INTO partija
VALUES (11, 10, convert(date,'2020-06-12'), convert(datetime,'12-06-20 09:20:00 AM',5), convert(datetime,'06-12-20 9:01:43 PM',5), 'Oblačno');
INSERT INTO partija
VALUES (12, 7, convert(date,'2020-05-18'), convert(datetime,'18-05-20 11:00:00 AM',5), convert(datetime,'18-05-20 5:02:49 PM',5), 'Oblačno');
INSERT INTO partija
VALUES (13, 8, convert(date,'2020-05-04'), convert(datetime,'04-05-20 7:20:00 AM',5), convert(datetime,'04-05-20 10:47:32 PM',5), 'Sunčano');
INSERT INTO partija
VALUES (14, 8, convert(date,'2020-05-17'), convert(datetime,'17-05-20 10:30:00 AM',5), convert(datetime,'17-05-20 3:00:35 PM',5), 'Sunčano');
INSERT INTO partija
VALUES (15, 9, convert(date,'2020-05-12'), convert(datetime,'12-05-20 11:45:12 AM',5), convert(datetime,'12-05-20 2:32:42 PM',5), 'Sunčano');
INSERT INTO partija
VALUES (16, 10, convert(date,'2020-06-20'), convert(datetime,'20-05-20 09:30:00 AM',5), convert(datetime,'20-05-20 10:14:36 PM',5), 'Kiša');
INSERT INTO partija
VALUES (18, 10, convert(date,'2020-08-05'), convert(datetime,'05-08-20 11:25:00 AM',5), convert(datetime,'05-08-20 4:12:54 PM',5), 'Oblačno');


INSERT INTO igraju
VALUES (1, 1);
INSERT INTO igraju
VALUES (1, 2);


INSERT INTO rupa
VALUES (1, 'Brdo', 45, 2, 1);
INSERT INTO rupa
VALUES (2, 'Livada', 122, 9, 1);
INSERT INTO rupa
VALUES (3, 'Jezero', 298, 15, 1);
INSERT INTO rupa
VALUES (4, 'Šuma', 104, 7, 1);
INSERT INTO rupa
VALUES (5, 'Reka', 77, 5, 1);
INSERT INTO rupa
VALUES (6, 'Livada', 24, 1, 3);
INSERT INTO rupa
VALUES (7, 'Šuma', 55, 4, 3);
INSERT INTO rupa
VALUES (8, 'Reka', 140, 6, 3);
INSERT INTO rupa
VALUES (9, 'Jezero', 200, 14, 4);
INSERT INTO rupa
VALUES (10, 'Šuma', 57, 5, 4);
INSERT INTO rupa
VALUES (12, 'Šuma', 70, 5, 5);
INSERT INTO rupa
VALUES (13, 'Jezero', 50, 4, 5);
INSERT INTO rupa
VALUES (14, 'Brdo', 25, 1, 5);
INSERT INTO rupa
VALUES (15, 'Brdo', 230, 13, 6);
INSERT INTO rupa
VALUES (16, 'Ravnica', 167, 9, 6);
INSERT INTO rupa
VALUES (17, 'Livada', 123, 6, 6);
INSERT INTO rupa
VALUES (18, 'Brdo', 420, 22, 7);
INSERT INTO rupa
VALUES (19, 'Jezero', 200, 15, 8);
INSERT INTO rupa
VALUES (20, 'Šuma', 102, 7, 8);
INSERT INTO rupa
VALUES (21, 'Ravnica', 300, 19, 9);
INSERT INTO rupa
VALUES (22, 'Ravnica', 240, 12, 9);
INSERT INTO rupa
VALUES (23, 'Reka', 50, 3, 10);
INSERT INTO rupa
VALUES (24, 'Šuma', 200, 20, 10);
INSERT INTO rupa
VALUES (25, 'Livada', 190, 10, 10);
INSERT INTO rupa
VALUES (26, 'Brdo', 100, 3, 10);


INSERT INTO rezultat
VALUES (1, 1, 1, 24);
INSERT INTO rezultat
VALUES (1, 2, 1, 12);
INSERT INTO rezultat
VALUES (1, 3, 1, 42);
INSERT INTO rezultat
VALUES (1, 4, 1, 32);
INSERT INTO rezultat
VALUES (1, 5, 1, 14);
INSERT INTO rezultat
VALUES (2, 6, 3, 42);
INSERT INTO rezultat
VALUES (2, 7, 3, 12);
INSERT INTO rezultat
VALUES (2, 8, 3, 47);
INSERT INTO rezultat
VALUES (3, 22, 9, 13);
INSERT INTO rezultat
VALUES (4, 12, 5, 44);
INSERT INTO rezultat
VALUES (4, 26, 10, 5);
INSERT INTO rezultat
VALUES (5, 21, 9, 30);
INSERT INTO rezultat
VALUES (6, 4, 1, 24);
INSERT INTO rezultat
VALUES (7, 16, 6, 13);
INSERT INTO rezultat
VALUES (8, 19, 8, 49);
INSERT INTO rezultat
VALUES (9, 2, 1, 55);
INSERT INTO rezultat
VALUES (10, 17, 6, 23);
INSERT INTO rezultat
VALUES (11, 13, 5, 25);
INSERT INTO rezultat
VALUES (12, 26, 10, 32);
INSERT INTO rezultat
VALUES (13, 18, 7, 21);
INSERT INTO rezultat
VALUES (14, 23, 10, 23);