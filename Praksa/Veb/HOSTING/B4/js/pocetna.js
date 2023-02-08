const opisi = {
	"slika1": {
		naziv: "Stari gitarista",
		opis: "Stari gitarista je uljana slika Pabla Pikasa, koju je stvorio krajem 1903. i početkom 1904. Na njoj je prikazan stariji muzičar, iznemoglog čoveka sa izlizanom odećom, koji je pogrbljen nad gitarom dok svira na ulicama Barselone u Španiji.",
		godina: 1903
	},
	"slika2": {
		naziv: "San",
		opis: "San je slika ulje na platnu iz 1932. Pabla Pikasa, tada 50-godišnjaka, koji prikazuje njegovu 22-godišnju ljubavnicu Mari-Terez Valter. Priča se da je naslikana za jedno popodne, 24. januara 1932. godine.",
		godina: 1932
	},
	"slika3": {
		naziv: "Devojka pred ogledalom",
		opis: "Devojka pred ogledalom je slika ulja na platnu Pabla Pikasa koju je stvorio 1932. Slika je portret Pikasove ljubavnice i muze, Mari-Terez Valter, koja je prikazana kako stoji ispred ogledala i gleda u svoj odraz. Smešten je u kolekciji Muzeja moderne umetnosti u Njujorku.", 
		godina: 1932
	},
	"slika4": {
		naziv: "Devojka na lopti",
		opis: "Devojka na lopti ili Mladi akrobat na lopti je slika Pabla Pikasa iz ulja na platnu iz 1905. godine, koju je napravio tokom svog perioda ruže. Prikazuje grupu putujućih cirkuskih izvođača tokom probe, sa primarnim fokusom na dve kontrastne figure. Od 1948. godine nalazi se u zbirci Puškinovog muzeja u Moskvi.",
		godina: 1905
	},
	"slika5": {
		naziv: "Dečak sa lulom",
		opis: "Dečak sa lulom je delo španskog slikara Pabla Pikasa. Naslikana je 1905. godine, kada je Pikaso imao 24 godine i bio u svojoj, tzv. Ružičastoj fazi, neposredno nakon što se preselio u Monmartr, severno deo Pariza. Delo se danas nalazi u privatnoj kolekciji.",
		godina: 1905
	}
}
const slike = Array.from(document.querySelectorAll("#slike img"));
const indikatori = Array.from(document.querySelectorAll(".indikator"));

let index = 0;

setInterval(() => {
	index = (index + 1) % slike.length;
	for (const slika of slike) {
		slika.classList.remove("active");
	}
	for (const indikator of indikatori) {
		indikator.classList.remove("active");
	}
	slike[index].classList.add("active");
	indikatori[index].classList.add("active");
	const podaci = opisi[`slika${index+1}`];
	document.getElementById("naziv").innerText = podaci.naziv;
	document.getElementById("godina").innerText = podaci.godina;
	document.getElementById("opis").innerText = podaci.opis;
}, 3 * 1000);