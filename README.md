

# Tim20-RTJ

Članovi tima:

1. Rasim Šabanović  
2. Haris Osmanbegović
3. Esmer Turković

# Opis Teme

Aplikacija za cilj ima olakšavanje procesa rezervacije i dogovaranja termina za rekreativne sportove. Znamo da je jako teško uskladiti i rezervisati baš onaj termin koji vama odgovara, zato sa ovom aplikacijom to mozete da zavrsite za 5 minuta. Ovaj sistem ce koristiti bilo ko sa prostorom za koristenje u svrhu sportskih termina, moguce su velike ustede vremena i efikasnije koristenje prostorija. U demonstrativnom okruzenju, aplikaciju koristi sasvim tipicni covjek koji nema dovoljno vremena da prodje kroz sve ponude sarajevskih sportskih centara i da odabere ponudu koja odgovara njemu a i ostatku tima. U tom slucaju problem predstavlja i mogucnost drugih ljudi da rezervisu taj termin prije njega. Sve ovo je rijeseno aplikacijom FIFO (Federation Internazionale de Football Organization) sa kojom u par klikova mozete da posaljete zahtjev za rezervaciju mnostva sala, sportova i termina po cijelom Sarajevu, a i sire.

# Procesi

### Registracija novog korisnika

Korisnik unosi svoje podatke i dobija profil koji moze koristiti u ovoj aplikaciji.

### Registracija novog uposlenog

Administrator postavlja podatke i permisije osobi koja je novi uposleni u sistemu, sada ta osoba ima mogucnost odobravanja termina koji su specificirani od strane krajnjih korisnika.

### Pretraga termina

Korisnik unosi datume, sport i lokacije koji mu odgovaraju te se iz baze selektuju termini koji zadovoljavaju sve postavljene uslove.

### Rezervisanje termina

Kada je korisnik pronasao termin koji mu odgovara, pomocu interfejsa rezervise taj termin, te ceka da neki od uposlenika taj termin odobri.

### Skupljanje bodova

Cestim koristenjem aplikacije i zakupljivanjem termina korisnik skuplja bodove koje moze da iskoristi za popuste za usluge.

# Funkcionalnosti

- Biranje termina, sale i sporta za zeljeni termin
- Slanje notifikacija korisniku o potencijalnom pomjeranju termina ili potvrđenom terminu
- Dodavanje novih termina i sala
- Editovanje vec postojecih termina
- Mogucnost prijave u sistem sa razlicitim privilegijama (obicni korisnik, uposlenik kompleksa i admin)
- Mogucnost dodavanja komentara uz zahtjev za rezervisanje termina
- Automatsko pronalazenje najblizih sala koristenjem GPS usluge
- Mogucnost pretrage termina glasom (speech to text)
- Automatsko kreiranje i izdavanje racuna

# Akteri

- Korisnik - osoba koja koristi aplikaciju i ima mogucnost registracije, pretrage, pregleda i biranja termina
- Uposlenik - osoba koja radi za firmu u kojoj se izdaje termin, ima mogucnost odobravanja termina i ubacivanje novih termina
- Administrator - kreator aplikacije koji ima sve privilegije (editovanje termina, dodavanje novih sala, registrovanje uposlenika)



