class Red {
	constructor({rbr, ime, prezime, skola, poeni, styles = {}}) {
		this.rbr = rbr;
		this.ime = ime;
		this.prezime = prezime;
		this.skola = skola;
		this.poeni = poeni;
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
		const skola = document.createElement("td");
		skola.innerText = this.skola;
		const poeni = document.createElement("td");
		poeni.innerText = this.poeni;
		tr.append(rbr, ime, prezime, skola, poeni);
		return tr;
	}
}

class Tabela {
	constructor(podaci, tbody) {
		this.element = tbody;
		this.redovi = podaci.map(red => new Red(red))
	}
	render() {
		this.element.innerHTML = "";
		this.element.append(...this.redovi.map(red => red.render()))
		console.log(this);
	}
	sort() {
		this.redovi = this.redovi.sort((a, b) => b.poeni - a.poeni)
	}
	neparni() {
		for(let i = 0; i < this.redovi.length; i++) 
			this.redovi[i].styles = {...this.redovi[i].styles, background: (i+1) % 2 === 0 ? "gray" : "white"}
	}
	polozili() {
		for (const red of this.redovi) {
			if(red.poeni >= 50) red.styles = {...red.styles, color: "green"}
		}
	}
	pali() {
		for (const red of this.redovi) {
			if(red.poeni < 50) red.styles = {...red.styles, color: "red"}
		}
	}
	izdvoj() {
		this.redovi = this.redovi.filter(red => red.poeni >= 50);
		this.sort();
	}
}

const podaci = [
	{
		rbr: 1,
		ime: "Pera",
		prezime: "Mikić",
		skola: "Oš \"Vuk Karadžić\"",
		poeni: 54
	},
	{
		rbr: 2,
		ime: "Mika",
		prezime: "Žikić",
		skola: "Oš \"Ivo Andrić\"",
		poeni: 20
	},
	{
		rbr: 3,
		ime: "Milan",
		prezime: "Marković",
		skola: "Oš \"Mika Antić\"",
		poeni: 73
	},
	{
		rbr: 4,
		ime: "Ivan",
		prezime: "Tošić",
		skola: "Oš \"Bubanjski heroji\"",
		poeni: 21
	},
	{
		rbr: 5,
		ime: "Jelena",
		prezime: "Perić",
		skola: "Oš \"Milan Milutinovič\"",
		poeni: 68
	}
]

const tabela = new Tabela(podaci, document.getElementById("tbody"));
tabela.render();

document.getElementById("sortirajBtn").onclick = () => {
	tabela.sort();
	tabela.render();
}
document.getElementById("nepraniBtn").onclick = () => {
	tabela.neparni();
	tabela.render();
}
document.getElementById("poloziliBtn").onclick = () => {
	tabela.polozili();
	tabela.render();
}
document.getElementById("paliBtn").onclick = () => {
	tabela.pali();
	tabela.render();
}
document.getElementById("izdvojBtn").onclick = () => {
	tabela.izdvoj();
	tabela.render();
}