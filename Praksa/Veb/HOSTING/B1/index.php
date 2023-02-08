<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="./slike/LOGO.ico" type="image/x-icon">
    <link rel="stylesheet" href="./css/global.css">
    <link rel="stylesheet" href="./css/pocetna.css">
    <title>B1 - Foto Galerija</title>
</head>
<body>
    <header>
        <h1>Foto galerija</h1>
        <?php 
            $url = "index";
            require "./components/nav.php";
        ?>
    </header>
    <main class="gallery-container">
        <div class="gallery">
            <textarea readonly>Lorem ipsum dolor sit amet, consectetur adipiscing elit. In vel velit lorem. Sed eget dignissim purus, sit amet elementum mi. Fusce viverra sapien libero, vel posuere neque accumsan at. Sed elementum luctus augue quis feugiat. Nunc vel volutpat mauris, non sodales justo. Mauris imperdiet volutpat massa, sed consequat nulla aliquet in. Duis in massa tincidunt, imperdiet dui nec, porttitor lacus. Ut aliquet mollis ante eget pulvinar. Suspendisse venenatis sagittis est mattis aliquam. Donec augue sapien, molestie quis mattis non, posuere vel ligula. Aliquam finibus neque vel luctus ornare. Pellentesque ac lectus gravida, vestibulum enim ut, aliquet elit. Maecenas tincidunt leo molestie nisl fringilla, in mattis mauris sodales.</textarea>
            <div class="center-image">
                <img src="./slike/slika1.jpg" alt="Centralna slika">
            </div>
            <div class="small-image-list">
                <div class="small-image"><img src="./slike/slika1.jpg" alt="slika 1" id="slika1"></div>
                <div class="small-image"><img src="./slike/slika2.jpg" alt="slika 2" id="slika2"></div>
                <div class="small-image"><img src="./slike/slika3.jpg" alt="slika 3" id="slika3"></div>
                <div class="small-image"><img src="./slike/slika4.jpg" alt="slika 4" id="slika4"></div>
                <div class="small-image"><img src="./slike/slika5.jpg" alt="slika 5" id="slika5"></div>
                <div class="small-image"><img src="./slike/slika6.jpg" alt="slika 6" id="slika6"></div>
                <div class="small-image"><img src="./slike/slika7.jpg" alt="slika 7" id="slika7"></div>
                <div class="small-image"><img src="./slike/slika8.jpg" alt="slika 8" id="slika8"></div>
                <div class="small-image"><img src="./slike/slika9.jpg" alt="slika 9" id="slika9"></div>
                <div class="small-image"><img src="./slike/slika10.jpg" alt="slika 10" id="slika10"></div>
            </div>
        </div>
    </main>
    <script src="./js/pocetna.js"></script>
</body>
</html>