CREATE TABLE tip_sobe
(
    tip_sobe_id INT PRIMARY KEY,
    tip_sobe VARCHAR(20) NOT NULL
)

CREATE TABLE gost
(
    gost_id INT PRIMARY KEY,
    ime VARCHAR(20) NOT NULL,
    prezime VARCHAR(20) NOT NULL,
    adresa VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL,
    telefon VARCHAR(20) NOT NULL,
    datum_rodjenja DATETIME NOT NULL
)
CREATE TABLE musterija
(
    musterija_id INT PRIMARY KEY,
    ime VARCHAR(20) NOT NULL,
    prezime VARCHAR(20) NOT NULL,
    adresa VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL,
    telefon VARCHAR(20) NOT NULL,
    datum_rodjenja DATETIME NOT NULL
)

CREATE TABLE nacin_placanja 
(
    nacin_placanja_id INT PRIMARY KEY,
    nacin_placanja VARCHAR(20) NOT NULL
)

CREATE TABLE rezervacija
(
    rezervacija_id INT PRIMARY KEY,
    musterija_id INT REFERENCES musterija(musterija_id),
    datum_rezervisanja DATE NOT NULL,
	pocetak_rezervacije DATE NOT NULL,
	CONSTRAINT pocetak CHECK (datum_rezervisanja<=pocetak_rezervacije),
    kraj_rezervacije DATE NOT NULL,
	CONSTRAINT kraj CHECK(pocetak_rezervacije<=kraj_rezervacije),
    rok_za_uplatu DATE NOT NULL,
    suma_za_uplatu INT NOT NULL
)
CREATE TABLE uplata
(
    uplata_id INT IDENTITY(1,1) PRIMARY KEY,
    rezervacija_id INT REFERENCES rezervacija(rezervacija_id),
    nacin_placanja_id INT REFERENCES dbo.nacin_placanja(nacin_placanja_id),
    iznos INT NOT NULL
)

CREATE TABLE soba
(
    soba_id INT PRIMARY KEY,
    tip_sobe_id INT REFERENCES tip_sobe(tip_sobe_id),
    sprat INT NOT NULL,
    napomena VARCHAR(70) NOT NULL
)

CREATE TABLE rezervacija_sobe
(
    rezervacija_id INT REFERENCES rezervacija(rezervacija_id),
    soba_id INT REFERENCES soba(soba_id),
    gost_id INT REFERENCES dbo.gost(gost_id),
	PRIMARY KEY (rezervacija_id, soba_id, gost_id)
)

CREATE TABLE dodatak
(
    dodatak_id INT PRIMARY KEY,
    soba_id INT REFERENCES soba(soba_id),
    dodatak VARCHAR(70) NOT NULL
)

--ALTER TABLE uplata
--ADD datum_uplate DATE