<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="./slike/LOGO.ico" type="image/x-icon">
    <link rel="stylesheet" href="./css/global.css">
    <link rel="stylesheet" href="./css/uputstva.css">
    <title>B1 - Foto Galerija | Uputstvo</title>
</head>
<body>
    <header>
        <h1>Foto galerija - Uputstvo</h1>
        <?php 
            $url = "uputstvo";
            require "./components/nav.php";
        ?>
    </header>
    <main>
        <section>
            <h2>Početna</h2>
            <p>
                Na početnoj stranici možete videti galeriju slika. <br>
                Galerija se sastoji iz jedne centralne slike, sa svojim opisom iznad nje i 10 malih slika ispod. <br>
                Klikom na jednu od malih slika postavljate je za centralnu te će ona zameniti trenutnu centralnu sliku i njen opis svojim.
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
</body>
</html>