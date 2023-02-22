CREATE TABLE zanr
(ZanrID INT PRIMARY KEY,
Naziv_zanra NVARCHAR(30) NOT NULL);

CREATE TABLE film
(FilmID INT PRIMARY KEY,
Naziv NVARCHAR(30) NOT NULL,
Datum_izlaska DATE NOT NULL,
Trajanje NVARCHAR(10) NOT NULL,
ZanrID INT NOT NULL,
FOREIGN KEY (ZanrID) REFERENCES zanr (ZanrID),
Opis_radnje NVARCHAR(300));

CREATE TABLE producent
(ProducentID INT PRIMARY KEY,
Ime NVARCHAR(30) NOT NULL,
Email NVARCHAR(30) NOT NULL,
Veb_sajt NVARCHAR(30) NOT NULL);

CREATE TABLE producirao
(FilmID INT NOT NULL,
FOREIGN KEY (FilmID) REFERENCES film(FilmID),
ProducentID INT NOT NULL,
FOREIGN KEY (ProducentID) REFERENCES producent(ProducentID));

CREATE TABLE tip_uloge
(TipUlogeID INT PRIMARY KEY,
Tip NVARCHAR(15) NOT NULL);

CREATE TABLE glumac
(GlumacID INT PRIMARY KEY,
Ime NVARCHAR(20) NOT NULL,
Prezime NVARCHAR(20) NOT NULL,
Datum_rodjenja DATE NOT NULL,
Mesto_rodjenja NVARCHAR(30) NOT NULL);

CREATE TABLE uloga
(FilmID INT NOT NULL,
FOREIGN KEY (FilmID) REFERENCES film(FilmID),
GlumacID INT NOT NULL,
FOREIGN KEY (GlumacID) REFERENCES glumac(GlumacID),
TipUlogeID INT NOT NULL,
FOREIGN KEY (TipUlogeID) REFERENCES tip_uloge(TipUlogeID),
Ime_lika NVARCHAR(20) PRIMARY KEY,
Opis_lika NVARCHAR(300));

CREATE TABLE nagrada
(NagradaID INT PRIMARY KEY,
Naziv NVARCHAR(50) NOT NULL,
Godina_od_kada_se_dodeljuje NVARCHAR(5) NOT NULL);

CREATE TABLE festival
(NagradaID INT NOT NULL,
FOREIGN KEY (NagradaID) REFERENCES nagrada(NagradaID),
FilmID INT NOT NULL,
FOREIGN KEY (FilmID) REFERENCES film(FilmID),
Godina_dobijanja_nagrade NVARCHAR(5) NOT NULL);


INSERT INTO zanr
VALUES(1, 'Drama');

INSERT INTO zanr
VALUES(2, 'Triler');

INSERT INTO zanr
VALUES(3, 'Avantura');

INSERT INTO zanr
VALUES(4, 'Akcija');

INSERT INTO zanr
VALUES(5, 'Komedija');

INSERT INTO zanr
VALUES(6, 'Fantazija');

INSERT INTO zanr
VALUES(7, 'Biografski');

INSERT INTO zanr
VALUES(8, 'Vestern');

INSERT INTO zanr
VALUES(9, 'Sci-Fi');

INSERT INTO zanr
VALUES(10, 'Ratni');

INSERT INTO zanr
VALUES(11, 'Horor');


INSERT INTO film
VALUES (1, 'Paklene ulice 1', convert(date,'06.22.2001'), '106 minuta', 4, 'Paklene ulice (engl. The Fast and the Furious) je američki akcioni film o uličnim auto trakama iz 2001. godine.');

INSERT INTO film
VALUES (2, 'Južni vetar 1', convert(date,'08.25.2018'), '125 minuta', 4, 'Južni vetar je
srpski film iz 2018. gpdine, prpducentskih kuća Režim, Art Vista i Arhangel studips,
režisera Milpщa Avrampvića, pp scenariju Petra Mihajlpvića i Milpša Avrampvića.');

INSERT INTO film
VALUES (3, 'Kum 1', convert(date,'04.15.1972'), '153 minuta', 1, 'Starosna patrijarh
organizovanog kriminala dinastije transfera kontrole njegovog tajnog carstva do njegovog nevoljnog
sina.');

INSERT INTO film
VALUES (4, 'Gospodar Prstenova',convert(date,'12.17.2018'), '182 minuta', 2, null);

INSERT INTO film
VALUES (5, 'Valter brani Sarajevo',convert(date,'11.24.1972'), '142 minuta', 2, null);

INSERT INTO film
VALUES (6, 'Borba titana',convert(date,'04.14.2012'), '65 minuta', 1, null);

INSERT INTO film
VALUES (7, 'Kum 2', convert(date,'03.14.1972'), '178 minuta', 1, 'Film je adaptacija
istpimenpg rpmana, kpji je napisap Marip Puzp.');

INSERT INTO film
VALUES (8, 'Serpiko', convert(date,'12.05.1973'), '130 minuta', 1, null);

INSERT INTO film
VALUES (9, 'Karlitov put',convert(date,'11.07.1993'),  '145 minuta', 4, 'Karlitpv put je
gangsterski film iz 1993. snimljen pp rpmanima Karlitpv put i Sitni sati sudije Edvina
Tpresa.');

INSERT INTO film
VALUES (10, 'Doni Brasko',convert(date,'02.28.1997'), '147 minuta', 1, null);

INSERT INTO film
VALUES (11, 'Hrabro srce',convert(date,'03.14.1996'), '182 minuta', 1, null)
INSERT INTO film
VALUES (12, 'Patriota',convert(date,'06.27.2000'), '175 minuta', 4, null);

INSERT INTO film 
VALUES (13, 'Smrtonosno oružje', convert(date,'03.06.1987'), '117 minuta', 4, 'Smrtpnpsnp
pružje je ameriški akcipni film iz 1987. kpji je režirap Rišard Dpner.');

INSERT INTO film
VALUES (14, 'Galipolje', convert(date,'08.13.1981'), '111 minuta', 1, null);

INSERT INTO film
VALUES (15, 'Čovek bez lica',convert(date,'08.25.1993'), '116 minuta', 1, null);

INSERT INTO film
VALUES (16, 'Zauvek mlad',convert(date,'12.16.1993'), '102 minuta', 1, 'Zauvek mlad je
ameriški film iz 1992. kpji je režirap Stiv Majner.');

INSERT INTO film
VALUES (17, 'Desperado',convert(date,'08.25.1995'), '107 minuta', 4, null);

INSERT INTO film
VALUES (18, 'Maska Zoroa', convert(date,'07.17.1998'), '136 minuta', 1, 'Maska Zprpa je
film iz 1998. kpji je režirap Martin Kembel.');

INSERT INTO film
VALUES (19, 'Atentatori',convert(date,'10.06.1995'), '133 minuta', 2, null);

INSERT INTO film
VALUES (20, 'Mačak u čizmama',convert(date,'10.16.2011'), '96 minuta', 3, null);

INSERT INTO film
VALUES (21, 'Filadelfija',convert(date,'12.22.1993'), '126 minuta', 1, null);

INSERT INTO film
VALUES (22, 'Forest Gamp', convert(date,'06.23.1994'), '142 minuta', 1, 'Fprest Gamp je
ameriški film iz 1994. režisera Rpberta Zemekisa, snimljen pp rpmanu Vinstpna Gruma iz
1985.');

INSERT INTO film
VALUES (23, 'Izgnanik',convert(date,'12.07.2000'), '153 minuta', 1, null);

INSERT INTO film
VALUES (24, 'Polarni ekspres',convert(date,'10.30.2004'), '100 minuta', 6, 'Radoa prati
Čaka Nplanda zappslenpg u kurirskpj službi, šiji se avipn tpkpm jednpg ppslpvnpg zadatka
ruщi na pustpm pstrvu, gde pstaje zatpšen gpdinama ppkuщavajući da preživi.');

INSERT INTO film
VALUES (25, 'Spasavanje redova Rajana',convert(date,'07.24.1998'), '170 minuta', 1,
'Bliži se kraj Drugpg svetskpg rata. Amerikanci ulaze u Nemašku. U ratu ušestvuju i trpjica
braće Rajan. Kakp dvpjica braće ginu u bprbi, vpjnici kapetana Džpna Milera ppkuщavaju da
izvuku jedinpg prepstalpg Rajana iz bitke.');

INSERT INTO film
VALUES (26, 'Čudo sa Hadsona',convert(date,'09.06.2016'), '96 minuta', 1, 'Čudp sa
Hadspna je ameriški drama film iz 2016. gpdine reditelja Klinta Istvuda.');

INSERT INTO film
VALUES (27, 'Apolo 13',convert(date,'06.22.2004'), '140 minuta', 1, 'Scenarip filma je
napisan na psnpvu istinitpg dpgađaja iz 1971. gpdine.');

INSERT INTO film
VALUES (28, 'Dobri Vil Hanting',convert(date,'12.02.1997'), '126 minuta', 1, 'Dpbri Vil
Hanting (engl. Good Will Hunting) je ameriška filmska drama iz 1997. kpju je režirap Gas Van
San.');

INSERT INTO film
VALUES (29, 'Marsovac',convert(date,'09.24.2004'), '151 minuta', 6, 'Marspvac:
Spasilaška misija ameriški je naušnpfantastišni film iz 2015. u režiji Ridlija Skpta.
Snimljen je pp scenariju Drua Gpdarda napisanpm pp mptivima rpmana Marspvac Endija
Vira.');

INSERT INTO film
VALUES (30, 'Bornov identitet',convert(date,'06.06.2002'), '119 minuta', 2, 'Bprnpv
identitet je akcipni triler iz 2002. baziran na istpimenpm rpmanu Rpberta Ladluma.');

INSERT INTO film
VALUES (31, 'Dvostruka igra',convert(date,'09.26.2006'), '151 minuta', 5, 'Dvpstruka igra
je ameriški kriminalistiški film Martina Skprsezea iz 2006. Film je dpbitnik Oskara za
najbplji film 2007.');

INSERT INTO film
VALUES (32, 'Zelena zona',convert(date,'03.12.2010'), '115 minuta', 1, null);

INSERT INTO film
VALUES (33, 'Igraj svoju igru',convert(date,'12.07.2001'),'117 minuta', 2, 'Nekplikp sati
nakpn щtp je puщten iz zatvpra, Deni Ouщan (Džprč Kluni) ppšioe birati uvežbanu ekipu
jedanaesterp pljaškaщa kpji će ppljaškati centralni trezpr kpji dele tri velika kasina u Las
Vegasu: Bellagio, The Mirage i MGM Grand.');

INSERT INTO film
VALUES (34, 'Argo',convert(date,'10.22.2012'), '130 minuta', 1, 'Argp ameriški je film
iz 2012. gpdine kpji je režirap Ben Aflek.');

INSERT INTO film
VALUES (35, 'Armagedon',convert(date,'07.01.1998'), '153 minuta', 2, null);

INSERT INTO film
VALUES (36, 'Borilački klub',convert(date,'09.21.1999'), '151 minuta', 1, 'Bprilaški klub
je ameriški film iz 1999, zasnpvan na istpimenpm rpmanu Čaka Pplanika iz 1996.');

INSERT INTO film
VALUES (37, 'Sedam', convert(date,'06.06.1996'), '128 minuta', 2, 'Sedam je ameriški
triler iz 1995. Glavne ulpge igraju: Mprgan Friman, Bred Pit, Gvinet Paltrpu i Kevin
Spejsi.');

INSERT INTO film
VALUES (38, 'Bes', convert(date,'10.15.2014'), '134 minuta', 4, null);

INSERT INTO film
VALUES (39, 'Top Gan',convert(date,'05.12.1996'), '110 minuta', 4, 'Tpp gan je ameriški
film iz 1986. Režirap ga je Tpni Skpt, a prpducenti su bili Dpn Simpspn i Džeri Brakhajmer u
saradoi sa prpducentskpm kućpm „Paramaunt pikšers“.');

INSERT INTO film
VALUES (40, 'Kišni čovek', convert(date,'12.12.1988'), '133 minuta', 1, 'Kiщni špvek je
drama iz 1988. Glavne ulpge u filmu igraju Tpm Kruz, Dastin Hpfman i Valerija Gplinp.');

INSERT INTO film
VALUES (41, 'Nekoliko dobrih ljudi',convert(date,'12.09.1992'), '138 minuta', 2, 'Nekplikp
dpbrih ljudi je film iz 1992.');

INSERT INTO film
VALUES (42, 'Širom zatvorenih očiju',convert(date,'07.16.1999'), '165 minuta', 1, 'Širpm
zatvprenih pšiju je ameriškp-britanska drama iz 1999. bazirana na npveli Traumnovelle
austrijskpg koiževnika Artura Šniclera iz 1926. Režiser, prpducent i kpscenarista filma
je Stenli Kjubrik kpjemu je pvp ppsledoi film.');

INSERT INTO film
VALUES (43, 'Povratnik',convert(date,'01.21.2016'), '156 minuta', 1, 'Ppvratnik
ameriški je vestern triler film iz 2015. gpdine u režiji Alehandra Gpnzaleza Ioaritua.');

INSERT INTO film
VALUES (44, 'Vuk sa Vol strita',convert(date,'12.26.2013'), '180 minuta', 1, 'Vuk sa Vpl
Strita ameriška je crna kpmedija u režiji Martina Skprsezea snimljena pp istpimenpj koizi
mempara Džprdana Belfprta.');

INSERT INTO film
VALUES (45, 'Ispovest opasnog uma',convert(date,'12.31.2002'), '113 minuta', 1,
'Isppvest ppasnpg uma je ameriški bipgrafski film iz 2002. gpdine, kpji je režirap Džprč
Kluni. Sem Rpkvel je za svpju glumu dpbip „Srebrnpg medveda“ na Berlinskpm filmskpm
festivalu.');

INSERT INTO film
VALUES (46, 'Od sumraka do svitanja',convert(date,'01.19.1996'), '108 minuta', 2, 'Od
sumraka dp svitaoa je akcipni/hprpr film iz 1996. kpji je režirap Rpbert Rpdrigez.');

INSERT INTO film
VALUES (47, 'Ali',convert(date,'12.25.2001'), '159 minuta', 7, 'Ali (engl. Ali) je film iz
2001. gpdine p bpkseru Muhamedu Aliju. Režiser filma je Majkl Man, a glavne ulpge igraju:
Vil Smit, Džpn Vpjt, Džejmi Fpks, Marip Van Pibls i Džejda Pinket Smit.');

INSERT INTO film
VALUES (48, 'Bilo koji metak',convert(date,'09.04.2018'), '106 minuta', 8, null);

INSERT INTO film
VALUES (49, 'Venom',convert(date,'10.05.2018'), '140 minuta', 9, 'Venpm (engl. Venom)
ameriški je superherpjski film iz 2018. gpdine sa istpimenim likpm Marvel Comics-a,
prpducenta Columbia Pictures-a u saradoi sa Marvel-pm i Tencent Pictures-pm.');

INSERT INTO film
VALUES (50, 'Dunkirk',convert(date,'07.19.2017'), '106 minuta', 10, 'Denkerk (engl.
Dunkirk) je ameriškp-britanskp-francuskp-hplandski ratni film iz 2017. gpdine reditelja i
scenariste Kristpfera Nplana. Prpducenti filma su Kristpfer Nplan i Ema Tpmas.');

INSERT INTO film
VALUES (51, 'Prizivanje zla',convert(date,'09.26.2013'), '112 minuta', 11, 'Prizivaoe zla
(engl. The Conjuring) je ameriški hprpr film iz 2013. gpdine. Predstavlja inauguralni film u
franщizi Univerzum Prizivaoa zla. Tp je ujednp i film sa najviщpm zaradpm u 2013. gpdini,
u kategpriji hprpra.');



INSERT INTO producent
VALUES (1, 'Paramount Pictures', 'robert@gmail.com', 'htpps://www.paramountrobert.rs');

INSERT INTO producent
VALUES (2, 'Miloš Avramovic', 'avram@gmail.com', 'htpps://www.avramovic.rs');

INSERT INTO producent
VALUES (3, 'New Line Cinema', 'kventin@gmail.com', 'htpp://www.kventin.org');

INSERT INTO producent
VALUES (4, 'Bosna film', 'bender@videos.uk', 'htpps://www.bosna-film.co.org');

INSERT INTO producent
VALUES (5, 'Warner Bros Pictures', 'stivens@yahoo.com', 'htpps://www.warner.rs');

INSERT INTO producent
VALUES (6, 'Columbia Pictures', 'martins@hotmail.com', 'htpps://www.columbia.net');

INSERT INTO producent
VALUES (7, 'Universal Pictures', 'eonardodk@gmail.com', 'htpps://www.universalpic.net');

INSERT INTO producent
VALUES (8, 'Sony Pictures Releasing', 'alehandr@hotmail.com', 'htpps://www.sony.com');

INSERT INTO producent
VALUES (9, 'Columbia Tri Star', 'rob_reiner@yahoo.com', 'htpps://www.reiner.co');

INSERT INTO producent
VALUES (10, 'Icon Productions', 'guber@gmail.com', 'htpp://www.icon-production.org');

INSERT INTO producent
VALUES (11, 'TriStar Pictures', 'dzeri@gmail.com', 'htpps://www.dzeri.com');

INSERT INTO producent
VALUES (12, 'Rob Koher', 'koher@gmail.com', 'htpps://www.robkoher.co ');

INSERT INTO producent
VALUES (13, 'DreamWorks Animation', 'palma@gmail.com', 'htpp://www.dreamworks.org');

INSERT INTO producent
VALUES (14, '20th Century Pictures, Inc', 'grejzer@gotmail.com', 'htpps://www.grejer.com');

INSERT INTO producent
VALUES (15, 'Imagine Entertainment', 'spilberg@gmail.com', 'htpp://www.imagine.com');

INSERT INTO producent
VALUES (16, 'Miramax', 'ridley@yahoo.com', 'htpps://www.miramax.org');

INSERT INTO producent
VALUES (17, 'Touchstone Pictures', 'clint@hotmail.com', 'htpp://www.clint.me');

INSERT INTO producent
VALUES (18, 'MGM/UA Communications', 'doner@gmail.com', 'htpps://www.mgm.ua.info');

INSERT INTO producent
VALUES (19, 'Džoel Silver', 'silver@yahoo.com', 'htpps://www.silver.co');

INSERT INTO producent
VALUES (20, 'Piter Boldman', 'boldman@hotmail.com', 'htpp://www.piterboldman.co.org');

INSERT INTO producent
VALUES (21, 'Dino de Lauentis', 'dinolaur@gmail.com', 'htpp://www.dinolaur.rs ');

INSERT INTO producent
VALUES (22, 'Džon Piters', 'piters@hotmail.com', 'htpp://www.piters.org');

INSERT INTO producent
VALUES (23, 'Džastin Li', 'lee@live.com', 'htpps://www.dzastinlee.com');

INSERT INTO producent
VALUES (24, 'Avi Arad', 'aarad@gmail.com', 'htpps://www.aarad.co');

INSERT INTO producent
VALUES (25, 'Kristofer Nolan', 'nolan@gmail.com', 'htpp://www.nolan.org');

INSERT INTO producent
VALUES (26, 'Toni Derona-Grand', 'derona.grand@hotmail.com', 'htpps://www.grand.com');





INSERT INTO producirao
VALUES (1, 12);

INSERT INTO producirao
VALUES (2, 2);

INSERT INTO producirao
VALUES (3, 1);

INSERT INTO producirao
VALUES (4, 3);

INSERT INTO producirao
VALUES (5, 4);

INSERT INTO producirao
VALUES (6, 5);

INSERT INTO producirao
VALUES (7, 1);

INSERT INTO producirao
VALUES (8, 1);

INSERT INTO producirao
VALUES (9, 7);

INSERT INTO producirao
VALUES (10, 8);

INSERT INTO producirao
VALUES (11, 1);

INSERT INTO producirao
VALUES (12, 6);

INSERT INTO producirao
VALUES (13, 5);

INSERT INTO producirao
VALUES (14, 1);

INSERT INTO producirao
VALUES (15, 10);

INSERT INTO producirao
VALUES (16, 5);

INSERT INTO producirao
VALUES (17, 9);

INSERT INTO producirao
VALUES (18, 11);

INSERT INTO producirao
VALUES (19, 5);

INSERT INTO producirao
VALUES (20, 13);

INSERT INTO producirao
VALUES (21, 11);

INSERT INTO producirao
VALUES (22, 1);

INSERT INTO producirao
VALUES (23, 20);

INSERT INTO producirao
VALUES (24, 5);

INSERT INTO producirao
VALUES (25, 13);

INSERT INTO producirao
VALUES (26, 5);

INSERT INTO producirao
VALUES (27, 15);

INSERT INTO producirao
VALUES (28, 16);

INSERT INTO producirao
VALUES (29, 14);

INSERT INTO producirao
VALUES (30, 7);

INSERT INTO producirao
VALUES (31, 5);

INSERT INTO producirao
VALUES (32, 5);

INSERT INTO producirao
VALUES (33, 8);

INSERT INTO producirao
VALUES (34, 5);

INSERT INTO producirao
VALUES (35, 17);

INSERT INTO producirao
VALUES (36, 14);

INSERT INTO producirao
VALUES (37, 3);

INSERT INTO producirao
VALUES (38, 6);

INSERT INTO producirao
VALUES (39, 1);

INSERT INTO producirao
VALUES (40, 18);

INSERT INTO producirao
VALUES (41, 6);

INSERT INTO producirao
VALUES (42, 5);

INSERT INTO producirao
VALUES (43, 14);

INSERT INTO producirao
VALUES (44, 1);

INSERT INTO producirao
VALUES (45, 16);

INSERT INTO producirao
VALUES (46, 16);

INSERT INTO producirao
VALUES (47, 22);

INSERT INTO producirao
VALUES (48, 23);

INSERT INTO producirao
VALUES (49, 24);

INSERT INTO producirao
VALUES (50, 25);

INSERT INTO producirao
VALUES (51, 26);

INSERT INTO tip_uloge
VALUES (1, 'Glavna');

INSERT INTO tip_uloge
VALUES (2, 'Sporedna');

INSERT INTO tip_uloge
VALUES (3, 'Dodatak');



INSERT INTO glumac
VALUES (1, 'Džoni', 'Dep',convert(date,'06.09.1963'), 'Ovensboro, Kentaki');

INSERT INTO glumac
VALUES (2, 'Mel', 'Gibson', convert(date,'01.03.1956'), 'Piksil, Njujork');

INSERT INTO glumac
VALUES (3, 'Antonio', 'Banderas', convert(date,'08.10.1960'), 'Malaga, Španija');

INSERT INTO glumac
VALUES (4, 'Tom', 'Henks',convert(date,'07.09.1956'), 'Konkord, Kalifornija');

INSERT INTO glumac
VALUES (5, 'Met', 'Dejmon', convert(date,'10.08.1970'), 'Kemridž, Masačusets');

INSERT INTO glumac
VALUES (6, 'Vin', 'Dizel',convert(date,'07.18.1967'), 'Alamenda Coudy, Kalifornija');

INSERT INTO glumac
VALUES (7, 'Miloš', 'Bikovic', convert(date,'01.13.1988'), 'Beograd, Srbija');

INSERT INTO glumac
VALUES (8, 'Tom', 'Hardi', convert(date,'09.15.1977'), 'London, UK');

INSERT INTO glumac
VALUES (9, 'Vira', 'Harmiga',convert(date,'08.06.1973'), 'Klifton, Njudžersi');

INSERT INTO glumac
VALUES (10, 'Vil', 'Smit',convert(date,'09.26.1968'), 'Filadelfija, SAD');

INSERT INTO glumac
VALUES (11, 'Hari', 'Stajls',convert(date,'02.01.1992'), 'Redič, UK');

INSERT INTO glumac
VALUES (12, 'Ben', 'Aflek',convert(date,'08.15.1972'), 'Berkli, Kalifornija');

INSERT INTO glumac
VALUES (13, 'Bred', 'Pit',convert(date,'12.18.1963'), 'Šani, Oklahoma');

INSERT INTO glumac
VALUES (14, 'Tom', 'Kruz',convert(date,'07.03.1962'), 'Sirakjuz, Njujork');

INSERT INTO glumac
VALUES (15, 'Leonardo', 'Di Kaprio',convert(date,'11.11.1974') , 'Los Anđeles, Kalifornija');

INSERT INTO glumac
VALUES (16, 'Džordž', 'Kluni',convert(date,'10.30.2004'), 'Leksington, Kentaki');

INSERT INTO glumac
VALUES (17, 'Al', 'Pačino',convert(date,'04.25.1940'), 'Istočni Harlem, Njujork');


INSERT INTO glumac
VALUES (18, 'Sandra', 'Bulok',convert(date,'07.26.1964'), 'Arlington');

INSERT INTO glumac 
VALUES (19, 'Arnold', 'Švaceneger',convert(date,'07.30.1947'), 'Tal, Austrija');

INSERT INTO glumac
VALUES (20, 'Džulija', 'Roberts',convert(date,'12.28.1967'), 'Smirna, Džordžija');


INSERT INTO uloga
VALUES (1, 6, 1, 'Dominik Toreto', 'Jedan, od glavnih likova i negativaca koju organizuju ulične trke.');

INSERT INTO uloga
VALUES (2, 7, 1, 'Petar Maraš', 'Mlad i ambiciozan momak, koji polako stasava na beogradskom
podzemlju.');

INSERT INTO uloga
VALUES (49, 8, 1, 'Edi Brok', null);

INSERT INTO uloga
VALUES (47, 10, 1, 'Muhamed Ali', 'Vil smit glumi boksera Muhameda Alija u biografskom filmu Ali');

INSERT INTO uloga
VALUES (50, 11, 1, 'Aleks', null);

INSERT INTO uloga
VALUES (3, 1, 1, 'Christopher', 'Magia Boss');

INSERT INTO uloga
VALUES (3, 17, 1, 'Majkl Korleone', 'Најмлађи син Вита Кпрлепнеа');

INSERT INTO uloga
VALUES (4, 13, 2, 'Hurin', null);

INSERT INTO uloga
VALUES (5, 5, 1, 'Gladius', null);

INSERT INTO uloga 
VALUES (6, 13, 1, 'Zeus', null);

INSERT INTO uloga
VALUES (8, 17, 1, 'Serpiko', 'Nepotkupljivi policajac');

INSERT INTO uloga
VALUES (9, 17, 1, 'Karlito', 'Mafijaš');

INSERT INTO uloga
VALUES (10, 1, 1, 'Doni Brasko', 'FBI agent ubačen u mafiju');

INSERT INTO uloga
VALUES (10, 17, 2, 'Bendžamin', 'Sitni kriminalac');

INSERT INTO uloga
VALUES (11, 2, 1, 'Vilijam Volas', 'Škotski junak');

INSERT INTO uloga
VALUES (12, 2, 1, 'Nendžamin Martin', 'Borac za nezavisnost');

INSERT INTO uloga
VALUES (13, 2, 1, 'Martin Rigs', 'Ludi policajac');

INSERT INTO uloga
VALUES (14, 2, 1, 'Frenk Dan', 'Australijski vojnik u prvom svetskom ratu');

INSERT INTO uloga
VALUES (15, 2, 1, 'Džastin Mek Leod', null);

INSERT INTO uloga
VALUES (16, 2, 1, 'Danijel Makormik', null);

INSERT INTO uloga
VALUES (17, 3, 1, 'El Marijači', 'Osvetnik');

INSERT INTO uloga
VALUES (18, 3, 1, 'Zoro', 'Meksički junak');

INSERT INTO uloga
VALUES (21, 3, 2, 'Migel Alvarez', null);

INSERT INTO uloga
VALUES (21, 4, 1, 'Endrju Beket', 'Oboleo od side');

INSERT INTO uloga
VALUES (22, 4, 1, 'Forest Gamp', 'Legenda');

INSERT INTO uloga
VALUES (24, 4, 2, 'Santa Klaus', 'Crtani lik');

INSERT INTO uloga
VALUES (28, 5, 1, 'Vil Hanting', 'Genijalni matematičar');

INSERT INTO uloga
VALUES (28, 12, 2, 'Čaki Saliven', 'Vilov drug');

INSERT INTO uloga
VALUES (29, 5, 1, 'Mark Vitni', 'Astronaut');

INSERT INTO uloga
VALUES (30, 5, 1, 'Džems Born', ' Born,Džems Born');

INSERT INTO uloga
VALUES (32, 5, 1, 'Roj Miler', 'Marinac');

INSERT INTO uloga
VALUES (33, 16, 1, 'Deni Oušan', 'Vođa ekipe');

INSERT INTO uloga
VALUES (34, 12, 1, 'Toni Mendez', 'Mozak ekipe');

INSERT INTO uloga
VALUES (37, 13, 1, 'Detektiv Mils', null);

INSERT INTO uloga
VALUES (39, 14, 1, 'Pit "Maverik" Mičel', 'Pilot');

INSERT INTO uloga
VALUES (40, 14, 2, 'Čarli', 'Brat glavnog junaka Rejmonda');

INSERT INTO uloga
VALUES (40, 14, 2, 'Poručnik Daniel Kaf', 'Poručnik Daniel Kafi brani dvojicu tvrdoglavih marinaca koji
su optuženi za ubistvo');

INSERT INTO uloga
VALUES (42, 14, 1, 'Bil Hartford', 'Doktor Bil Harford oženjen je lepom Alis koja radi kao kustos. Alis
jedne večeri priznaje svom suprugu.');

INSERT INTO uloga
VALUES (43, 15, 1, 'Hju Glas', 'Hju Glas je vpjni izviđaš. On i oegpv pplu-indijanski sin Jastreb,
pripadaju istpj grupi zajednp sa Džpn Ficčeraldpm, Džim Bričerpm ppd kpmandpm Endru
Henrija, uglavnpm zbpg lpva na živptioskp krznp. Oni su stalnp supšeni sa Indijancima i
Francuzima.');

INSERT INTO uloga
VALUES (44, 15, 1, 'Džordan Belfort', 'Лепнардп Дикаприп тумаши улпгу Белфпрта, оујпрщкпг
брпкера шија је кпмпанија умещана у мнпге илегалне акције на Впл стриту тпкпм деведесетих
гпдина прпщлпг века.');


INSERT INTO nagrada
VALUES (1, 'Nagrada za najbolji scenario', '1977');

INSERT INTO nagrada
VALUES (2, 'Oskar za najboljeg glumca', '1928');

INSERT INTO nagrada
VALUES (3, 'Oskar za najbolju fotografiju', '1928');

INSERT INTO nagrada
VALUES (4, 'Oskar za najbolji muzički broj', '1934');

INSERT INTO nagrada
VALUES (5, 'Saturn', '1972');

INSERT INTO nagrada
VALUES (6, 'Oskar za najbolju scenografiju', '1928');

INSERT INTO nagrada
VALUES (7, 'Oskar za najbolji film', '1928');

INSERT INTO nagrada
VALUES (8, 'Oskar za najboljeg režisera', '1928');

INSERT INTO nagrada
VALUES (9, 'Oskar za najbolju montažu', '1928');

INSERT INTO nagrada
VALUES (10, 'Nagrada za najbolju glumačku postavu', '1995');

INSERT INTO nagrada
VALUES (11, 'Zlatni globus za najbolji igrani film', '1951');

INSERT INTO nagrada
VALUES (12, 'Zlatni globus za najboljeg glumca', '1951');

INSERT INTO nagrada
VALUES (13, 'Empajer za najboljeg glumca', '1996');

INSERT INTO nagrada
VALUES (14, 'BAFT za najbolji film', '1947');

INSERT INTO nagrada
VALUES (15, 'MTV za najbolji film', '1992');

INSERT INTO festival
VALUES (1, 2, '2018');

INSERT INTO festival
VALUES (3, 4, '2002');

INSERT INTO festival
VALUES (4, 4, '2002');

INSERT INTO festival
VALUES (5, 4, '2002');

INSERT INTO festival
VALUES (2, 7, '1975');

INSERT INTO festival
VALUES (7, 22, '1995');

INSERT INTO festival
VALUES (2, 22, '1995');

INSERT INTO festival
VALUES (8, 22, '1995');

INSERT INTO festival
VALUES (10, 27, '1996');

INSERT INTO festival
VALUES (9, 27, '1996');

INSERT INTO festival
VALUES (11, 29, '2016');

INSERT INTO festival
VALUES (12, 29, '2016');

INSERT INTO festival
VALUES (13, 29, '2016');

INSERT INTO festival
VALUES (7, 34, '2013');

INSERT INTO festival
VALUES (14, 34, '2013');

INSERT INTO festival
VALUES (11, 34, '2013');

INSERT INTO festival
VALUES (9, 34, '2013');

INSERT INTO festival
VALUES (4, 39, '1987');

INSERT INTO festival
VALUES (13, 36, '2000');

INSERT INTO festival
VALUES (7, 40, '1989');

INSERT INTO festival
VALUES (2, 40, '1989');

INSERT INTO festival
VALUES (11, 40, '1989');

INSERT INTO festival
VALUES (15, 41, '1993');

INSERT INTO festival
VALUES (7, 31, '2007');
INSERT INTO festival
VALUES (9, 31, '2007');


