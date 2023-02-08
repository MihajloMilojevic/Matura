<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="./slike/LOGO.ico" type="image/x-icon">
    <link rel="stylesheet" href="./css/global.css">
    <link rel="stylesheet" href="./css/pocetna.css">
    <title>B1 - Domaće životinje</title>
</head>
<body>
    <header>
        <h1>Domaće životinje</h1>
        <?php 
            $url = "index";
            require "./components/nav.php";
        ?>
    </header>
    <main class="image-list">
        <div class="image"><img src="./slike/pas.jpg" alt="Pas" id="pas"></div>
        <div class="image"><img src="./slike/pace.jpg" alt="Pače" id="patka"></div>
        <div class="image"><img src="./slike/macka.jpg" alt="Mače" id="macka"></div>
        <div class="image"><img src="./slike/pile.jpg" alt="Pile" id="kokoska"></div>
        <div class="image"><img src="./slike/krava.jpg" alt="Krava" id="krava"></div>
    </main>
<?php 
require "./components/footer.php";
?>
    <script src="./js/pocetna.js"></script>
</body>
</html>