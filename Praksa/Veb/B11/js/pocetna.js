const URL = "https://naslovi.net/vremenska-prognoza/"

document.getElementById("grad").onchange = (e) => {
	document.querySelector("iframe").src = URL + e.currentTarget.value;
	window.open("/gradovi.php?grad=" + e.currentTarget.value, `Grad`, `width=500,height=300,left=100,top=100,menubar=no,toolbar=no`)
}