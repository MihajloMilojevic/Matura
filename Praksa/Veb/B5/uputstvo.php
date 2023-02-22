<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="./slike/LOGO.ico" type="image/x-icon">
    <link rel="stylesheet" href="./css/global.css">
    <link rel="stylesheet" href="./css/uputstva.css">
    <title>B5 - Osnovna škola "Sonja Marinković" | Uputstvo</title>
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
                Na početnoj stranici možete videti tabelu sa nekoliko insturmenata. <br>
                Klikom na sliku instrumenta otvara se prozor sa osnovnim podacima o instrumentu sa Wikipedije. <br>
                Klikom na "Saznaj više" otvara se prozor sa osnovnim podacima grupe kojoj taj instrument pripada. <br>
                Prelaskom miša preko slike zvučnika pušta se zvuk tog instrumenta.
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