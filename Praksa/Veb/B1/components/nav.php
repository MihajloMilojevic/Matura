<!DOCTYPE html>
<html lang="sr-RS">
<head>
    <link rel="stylesheet" href="../css/nav.css">
</head>
<body>
    <nav>
        <div class="links">
            <a href="/" class="link <?php echo ($url == "index" ? "active" : "") ?>">Početna</a>
            <a href="./autor.php" class="link <?php echo ($url == "autor" ? "active" : "") ?>">O autoru</a>
            <a href="./uputstvo.php" class="link <?php echo ($url == "uputstvo" ? "active" : "") ?>">Uputstvo</a>
        </div>
        <span class="zavrsni-ispit">Završni ispit</span>
    </nav>
</body>
</html>