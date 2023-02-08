Array.from(document.querySelectorAll(".image img")).forEach(img => {
	img.addEventListener("click", () => {
		window.open("/B2/zivotinja.php?zivotinja=" + img.id, `Domaće životinje | ${img.id}`, `width=500,height=300,left=100,top=100,menubar=no,toolbar=no`)
	})
})