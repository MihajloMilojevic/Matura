<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="./slike/LOGO.ico" type="image/x-icon">
    <link rel="stylesheet" href="./css/global.css">
    <link rel="stylesheet" href="./css/uputstva.css">
    <title>B3 - Osnovna škola "Sonja Marinković" | Uputstvo</title>
</head>
<body>
    <header>
        <h1>Osnovna škola "Sonja Marinković" - Uputstvo</h1>
        <?php 
            $url = "uputstvo";
            require "./components/nav.php";
        ?>
    </header>
    <main>
        <section>
            <h2>Početna</h2>
            <p>
                Na početnoj stranici možete videti kartu srbije sa njenim susedima. <br>
                Na teritoriji svake od država nalazi se zastava i naziv države. <br>
                Klikom na zastavu ili naziv države otvara se prozor sa osnovnim podacima države. <br>
                Prelaskom miša preko zastave države pušta se himna te zemlje.
            </p>
        </section>
        <section>
            <h2>Autor</h2>
            <p>Na stranici o autoru možete videti ko je autor ove aplikacije i kako ga možete kontaktirati.</p>
        </section>
        <section>
            <h2>Uputstvo</h2>
            <p>Na stranici uputstvo možete videti uputstva aplikacije.</p>
        </section>
    </main>
<?php
require "./components/footer.php";
?>
</body>
</html>