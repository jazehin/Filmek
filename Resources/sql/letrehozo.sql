-- CREATE DATABASE mozgokep COLLATE Hungarian_CI_AS;
-- USE mozgokep;

-- Táblák létrehozása

CREATE TABLE filmek (
	filmID INT IDENTITY(1, 1),
	filmCim VARCHAR(100) NOT NULL,
	bemutatasEve INT NOT NULL,
	hosszPercben INT NOT NULL,
	ertekeles DECIMAL(3,1) NOT NULL, -- értékelés 0-10 között egy tizedeshely pontossággal, én az IMDB-s értékelést használom
	leiras TEXT NULL, -- magyar leírások forrása: mafab.hu
	boritokepURL VARCHAR(100) NULL -- képek forrása: mafab.hu, mert az imdb.com-on nem a "hagyományos" módon vannak belinkelve a képek
	CONSTRAINT PK_filmek PRIMARY KEY (filmID)
);

CREATE TABLE mufajok (
	mufajID INT IDENTITY(1, 1),
	mufajNev VARCHAR(30) NOT NULL,
	CONSTRAINT PK_mufajok PRIMARY KEY (mufajID)
)

CREATE TABLE filmek_mufajok (
	fmID INT IDENTITY(1, 1),
	filmID INT FOREIGN KEY REFERENCES filmek(filmID),
	mufajID INT FOREIGN KEY REFERENCES mufajok(mufajID)
);

CREATE TABLE rendezok (
	rendezoID INT IDENTITY(1, 1),
	rendezoNev VARCHAR(50),
	CONSTRAINT PK_rendezok PRIMARY KEY (rendezoID)
);

CREATE TABLE filmek_rendezok (
	frID INT IDENTITY(1, 1),
	filmID INT FOREIGN KEY REFERENCES filmek(filmID),
	rendezoID INT FOREIGN KEY REFERENCES rendezok(rendezoID)
);

-- megjegyzés: minden filmnél 3-4 főbb szereplőt tüntetek fel 
CREATE TABLE szineszek (
	szineszID INT IDENTITY(1, 1),
	szineszNev VARCHAR(50),
	CONSTRAINT PK_szineszek PRIMARY KEY (szineszID)
);

CREATE TABLE filmek_szineszek (
	fszID INT IDENTITY(1, 1),
	filmID INT FOREIGN KEY REFERENCES filmek(filmID),
	szineszID INT FOREIGN KEY REFERENCES szineszek(szineszID),
	szereploNev VARCHAR(50)
);