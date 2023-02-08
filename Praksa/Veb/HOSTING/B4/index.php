<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="./slike/LOGO.ico" type="image/x-icon">
    <link rel="stylesheet" href="./css/global.css">
    <link rel="stylesheet" href="./css/pocetna.css">
    <title>B4 - Osnovna škola "Sonja Marinković"</title>
</head>
<body>
    <header>
        <h1>Osnovna škola "Sonja Marinković"</h1>
        <?php 
            $url = "index";
            require "./components/nav.php";
        ?>
    </header>
    <main>
        <div class="pikaso glow">
            <span>P</span>
            <span>I</span>
            <span>K</span>
            <span>A</span>
            <span>S</span>
            <span>O</span>
        </div>
        <div class="galerija">
            <div class="info">
                <div id="slike">
                    <img src="./slike/001.jpg" class="active" id="slika1"></img>
                    <img src="./slike/002.jpg" id="slika2"></img>
                    <img src="./slike/003.jpg" id="slika3"></img>
                    <img src="./slike/004.jpg" id="slika4"></img>
                    <img src="./slike/005.jpg" id="slika5"></img>
                </div>
                <div class="podaci">
                    <h2 id="naziv" class="glow">Stari gitarista</h2>
                    <h4 id="godina">1903</h4>
                    <p id="opis">Stari gitarista je uljana slika Pabla Pikasa, koju je stvorio krajem 1903. i početkom 1904. Na njoj je prikazan stariji muzičar, iznemoglog čoveka sa izlizanom odećom, koji je pogrbljen nad gitarom dok svira na ulicama Barselone u Španiji.</p>
                </div>
            </div>
            <div class="indikatori">
                <div class="indikator active" id="slika1-indikator"></div>
                <div class="indikator" id="slika2-indikator"></div>
                <div class="indikator" id="slika3-indikator"></div>
                <div class="indikator" id="slika4-indikator"></div>
                <div class="indikator" id="slika5-indikator"></div>
            </div>
        </div>
    </main>
<?php
require "./components/footer.php";
?>
    <script src="./js/pocetna.js"></script>
</body>
</html>