<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="./slike/LOGO.ico" type="image/x-icon">
    <link rel="stylesheet" href="./css/global.css">
    <link rel="stylesheet" href="./css/pocetna.css">
    <title>B11 - Vremenska prognoza</title>
</head>
<body>
    <header>
        <h1>Turistička agencija "Planinar"</h1>
        <?php 
            $url = "index";
            require "./components/nav.php";
        ?>
    </header>
    <main>
        <div>
            <label for="grad">Izaberite grad: </label>
            <select id="grad" name="grad">
                <option value="beograd" selected>Beograd</option>
                <option value="novi-sad">Novi Sad</option>
                <option value="kraljevo">Kraljevo</option>
                <option value="nis">Niš</option>
                <option value="kragujevac">Kragujevac</option>
            </select>
        </div>
        <iframe src="https://naslovi.net/vremenska-prognoza/beograd"></iframe>
    </main>
    <?php 
            $url = "index";
            require "./components/footer.php";
        ?>
    <script src="./js/pocetna.js"></script>
</body>
</html>