<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="shortcut icon" href="./slike/LOGO.ico" type="image/x-icon">
    <link rel="stylesheet" href="./css/global.css">
    <link rel="stylesheet" href="./css/autor.css">
    <title>B1 - Domaće životinje | Autor</title>
</head>
<body>
    <header>
        <h1>Domaće životinje - Autor</h1>
        <?php 
            $url = "autor";
            require "./components/nav.php";
        ?>
    </header>
    <main>
        <div class="info">
            <img class="logo" src="./slike/LOGO BEZ POZADINE.png" alt="Logo">
            <div class="name">
                <h2>Mihajlo Milojević</h2>
                <h4>IV<span>3</span></h4>
            </div>
        </div>
        <div class="contact">
            <a href="mailto:milojevicm374@gmail.com"><i class="fa fa-envelope" style="font-size:24px"></i><span>milojevicm374@gmail.com</span></a>
            <a href="tel:+381649781191"><i class="fa fa-phone" style="font-size:24px"></i><span>+38164978191</span></a>
            <a href="https://www.instagram.com/milojevicmihajlo/"><i class="fa fa-instagram" style="font-size:24px"></i><span>milojevicmihajlo</span></a>
            <a href="https://github.com/MihajloMilojevic"><i class="fa fa-github" style="font-size:24px"></i><span>MihajloMilojevic</span></a>
        </div>
    </main>
<?php 
require "./components/footer.php";
?>
</body>
</html>