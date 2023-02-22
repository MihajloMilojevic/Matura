<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="./slike/LOGO.ico" type="image/x-icon">
    <link rel="stylesheet" href="./css/global.css">
    <link rel="stylesheet" href="./css/pocetna.css">
    <title>B3 - Osnovna škola "Sonja Marinković"</title>
</head>
<body>
    <header>
        <h1>Osnovna škola "Sonja Marinković"</h1>
        <?php 
            $url = "index";
            require "./components/nav.php";
        ?>
    </header>
    <h2>Srbija i njeni susedi</h2>
    <main>
        <div class="naziv glow">
            <span>G</span>
            <span>E</span>
            <span>O</span>
            <span>G</span>
            <span>R</span>
            <span>A</span>
            <span>F</span>
            <span>I</span>
            <span>J</span>
            <span>A</span>
        </div>
        <div class="galerija">
            <img id="mapa" src="./slike/mapa.svg" alt="mapa">
            <div id="srbija" class="zastava">
                <img src="./slike/srbija.svg" alt="srbija-zastava">
                <p>Srbija</p>
            </div>
            <div id="madjarska" class="zastava">
                <img src="./slike/madjarska.svg" alt="madjarska-zastava">
                <p>Madjarska</p>
            </div>
            <div id="hrvatska" class="zastava">
                <img src="./slike/hrvatska.svg" alt="hrvatska-zastava">
                <p>Hrvatska</p>
            </div>
            <div id="bih" class="zastava">
                <img src="./slike/bih.svg" alt="bih-zastava">
                <p>Bosna i Hercegovina</p>
            </div>
            <div id="crna_gora" class="zastava">
                <img src="./slike/crna_gora.svg" alt="crna_gora-zastava">
                <p>Crna Gora</p>
            </div>
            <div id="albanija" class="zastava">
                <img src="./slike/albanija.svg" alt="albanija-zastava">
                <p>Albanija</p>
            </div>
            <div id="makedonija" class="zastava">
                <img src="./slike/makedonija.svg" alt="makedonija-zastava">
                <p>Makedonija</p>
            </div>
            <div id="bugarska" class="zastava">
                <img src="./slike/bugarska.svg" alt="bugarska-zastava">
                <p>Bugarska</p>
            </div>
            <div id="rumunija" class="zastava">
                <img src="./slike/rumunija.svg" alt="rumunija-zastava">
                <p>rumunija</p>
            </div>
        </div>
    </main>
    <audio src="./audio/srbija.mp3" id="audio-srbija"></audio>
    <audio src="./audio/madjarska.mp3" id="audio-madjarska"></audio>
    <audio src="./audio/hrvatska.mp3" id="audio-hrvatska"></audio>
    <audio src="./audio/bih.mp3" id="audio-bih"></audio>
    <audio src="./audio/crna gora.mp3" id="audio-crna_gora"></audio>
    <audio src="./audio/albanija.mp3" id="audio-albanija"></audio>
    <audio src="./audio/makedonija.mp3" id="audio-makedonija"></audio>
    <audio src="./audio/bugarska.mp3" id="audio-bugarska"></audio>
    <audio src="./audio/rumunija.mp3" id="audio-rumunija"></audio>
<?php
require "./components/footer.php";
?>
    <script src="./js/pocetna.js"></script>
</body>
</html>