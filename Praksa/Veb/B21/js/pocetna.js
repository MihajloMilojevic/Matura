class Red {
	constructor({rbr, ime, prezime,styles = {}}) {
		this.rbr = rbr;
		this.ime = ime;
		this.prezime = prezime;
		this.styles = styles
	}
	render() {
		const tr = document.createElement("tr");
		for (const style in this.styles) {
			tr.style[style] = this.styles[style]
		}
		const rbr = document.createElement("td");
		rbr.innerText = this.rbr + ".";
		const ime = document.createElement("td");
		ime.innerText = this.ime;
		const prezime = document.createElement("td");
		prezime.innerText = this.prezime;
		tr.append(rbr, ime, prezime);
		return tr;
	}
}

class Kolona {
	constructor(ime) {
		this.ime = ime;
		this.sorted = 0;
	}
}

class Tabela {
	constructor(podaci, kolone, tbody) {
		this.element = tbody;
		this.redovi = podaci.map(red => new Red(red))
		this.kolone = kolone.map(kol => new Kolona(kol))
		this.sort(0);
	}
	render() {
		this.element.innerHTML = "";
		this.element.append(...this.redovi.map(red => red.render()))
		console.log(this);
	}
	sort(kolInd) {
		const kol = this.kolone[kolInd];
		this.redovi = this.redovi.sort((a, b) => b[kol.ime] > a[kol.ime] ? -1 : 1);
		if(kol.sorted === 1) {
			this.redovi.reverse();
			kol.sorted = -1;
		}
		else {
			kol.sorted = 1;
		}
		this.kolone.forEach(k => {
			if(k.ime !== kol.ime) k.sorted = 0;
		});
	}
}

const podaci = [
	{
		rbr: 1,
		ime: "Pera",
		prezime: "Mikić"
	},
	{
		rbr: 2,
		ime: "Mika",
		prezime: "Žikić"
	},
	{
		rbr: 3,
		ime: "Žika",
		prezime: "Perić"
	},
	{
		rbr: 4,
		ime: "Dragan",
		prezime: "Milenković"
	},
	{
		rbr: 5,
		ime: "Pavle",
		prezime: "Tošić"
	}
]

const kolone = ["rbr", "ime", "prezime"]

const tabela = new Tabela(podaci, kolone, document.getElementById("tbody"));
tabela.render();

Array.from(document.querySelectorAll("th")).forEach((th, ind) => th.onclick = () => {tabela.sort(ind); tabela.render();})