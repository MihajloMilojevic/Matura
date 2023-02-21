Array.from(document.querySelectorAll(".zastava")).forEach(zas => {
	zas.addEventListener("mouseenter", () => document.getElementById(`audio-${zas.id}`)?.play())
	zas.addEventListener("mouseleave", () => {const audio = document.getElementById(`audio-${zas.id}`); audio.pause(); audio.currentTime = 0;})
	zas.addEventListener("click", () => window.open("/drzava.php?drzava=" + zas.id, `Srbija i susedi | ${zas.id}`, `width=500,height=300,left=100,top=100,menubar=no,toolbar=no`))
})
