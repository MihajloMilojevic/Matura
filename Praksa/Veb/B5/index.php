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
    <h2>Zvuci insturmenata</h2>
    <main>
        <div style="display: flex">
            <div class="naziv glow">
                <span>M</span>
                <span>U</span>
                <span>Z</span>
                <span>I</span>
                <span>Č</span>
                <span>K</span>
                <span>A</span>
            </div>
            <div class="naziv glow">
                <span>K</span>
                <span>U</span>
                <span>L</span>
                <span>T</span>
                <span>U</span>
                <span>R</span>
                <span>A</span>
            </div>
        </div>
        <table>
            <thead>
                <tr>
                    <th>Naziv instrumenta</th>
                    <th>Slika instumenta</th>
                    <th>Zvuk instrumenta</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Gitara</td>
                    <td><div class="insturment"><img src="./slike/gitara.jpg" alt=""></div></td>
                    <td>
                        <div class="zvucnik"><img src="./slike/zvucnik.svg" alt="zvucnik"></div>
                        <a href="https://www.google.com/" target="_blank" class="saznaj-vise">Saznaj više</a>
                    </td>
                </tr>
                <tr>
                    <td>Violina</td>
                    <td><div class="insturment"><img src="./slike/violina.jpg" alt=""></div></td>
                    <td>
                        <div class="zvucnik"><img src="./slike/zvucnik.svg" alt="zvucnik"></div>
                        <a href="https://www.google.com/" target="_blank" class="saznaj-vise">Saznaj više</a>
                    </td>
                </tr>
                <tr>
                    <td>Klavir</td>
                    <td><div class="insturment"><img src="./slike/klavir.jpg" alt=""></div></td>
                    <td>
                        <div class="zvucnik"><img src="./slike/zvucnik.svg" alt="zvucnik"></div>
                        <a href="https://www.google.com/" target="_blank" class="saznaj-vise">Saznaj više</a>
                    </td>
                </tr>
                <tr>
                    <td>Bubnjevi</td>
                    <td><div class="insturment"><img src="./slike/bubnjevi.jpg" alt=""></div></td>
                    <td>
                        <div class="zvucnik"><img src="./slike/zvucnik.svg" alt="zvucnik"></div>
                        <a href="https://www.google.com/" target="_blank" class="saznaj-vise">Saznaj više</a>
                    </td>
                </tr>
                <tr>
                    <td>Harmonika</td>
                    <td><div class="insturment"><img src="./slike/harmonika.jpg" alt=""></div></td>
                    <td>
                        <div class="zvucnik"><img src="./slike/zvucnik.svg" alt="zvucnik"></div>
                        <a href="https://www.google.com/" target="_blank" class="saznaj-vise">Saznaj više</a>
                    </td>
                </tr>
                <tr>
                    <td>Kontrafagot</td>
                    <td><div class="insturment"><img src="./slike/kontrafagot.webp" alt=""></div></td>
                    <td>
                        <div class="zvucnik"><img src="./slike/zvucnik.svg" alt="zvucnik"></div>
                        <a href="https://www.google.com/" target="_blank" class="saznaj-vise">Saznaj više</a>
                    </td>
                </tr>
            </tbody>
        </table>
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