<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="./slike/LOGO.ico" type="image/x-icon">
    <link rel="stylesheet" href="./css/global.css">
    <link rel="stylesheet" href="./css/uputstva.css">
    <title>B2 - Domaće životinje | Uputstvo</title>
</head>
<body>
    <header>
        <h1>Domaće životinje - Uputstvo</h1>
        <?php 
            $url = "uputstvo";
            require "./components/nav.php";
        ?>
    </header>
    <main>
        <section>
            <h2>Početna</h2>
            <p>
                Na početnoj stranici možete videti slike 5 domaćih životinja (pas, patka, mačka, kokoska, krava)<br>
                Klikom na bilo koju sliku otvoriće se prozor sa nazivom i opisom te životinje. <br>
                Prelaskom miša preko slike čućete zvuk koji ta životinja pravi (ne radi).
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