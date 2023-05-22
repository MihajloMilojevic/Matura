<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="./slike/LOGO.ico" type="image/x-icon">
    <link rel="stylesheet" href="./css/global.css">
    <link rel="stylesheet" href="./css/pocetna.css">
    <title>B22 - Efekti tabele</title>
</head>
<body>
    <?php 
        require "./components/header.php";
    ?>
    <main>
        <h1>Efekti tabele</h1>
        <div class="hr"></div>
        <table>
            <thead>
                <tr>
                    <th>Rbr</th>
                    <th>Ime</th>
                    <th>Prezime</th>
                    <th>Škola</th>
                    <th>Poeni</th>
                </tr>
            </thead>
            <tbody id="tbody">
                
            </tbody>
        </table>
        <div class="hr"></div>
        <div>
            <button id="sortirajBtn">Sortiraj</button>
            <button id="nepraniBtn">Oboji neparne</button>
            <button id="poloziliBtn">Položili</button>
            <button id="paliBtn">Nisu položili</button>
            <button id="izdvojBtn">Izdvoj one koji su položili</button>
        </div>
    </main>
    <?php 
        require "./components/footer.php";
    ?>
    <script src="./js/pocetna.js"></script>
</body>
</html>



<!--
                <tr>
                    <td>1.</td>
                    <td>Pera</td>
                    <td>Mikić</td>
                    <td>OŠ “Vuk Karadžić”</td>
                    <td>54</td>
                </tr>
                <tr>
                    <td>2.</td>
                    <td>Mika</td>
                    <td>Žikić</td>
                    <td>OŠ “Ivo Andrić”</td>
                    <td>20</td>
                </tr>
                <tr>
                    <td>3.</td>
                    <td>Milan</td>
                    <td>Marković</td>
                    <td>OŠ “Mika Antić”</td>
                    <td>73</td>
                </tr>
                <tr>
                    <td>4.</td>
                    <td>Ivan</td>
                    <td>Tošić</td>
                    <td>OŠ “Bubanjski heroji”</td>
                    <td>21</td>
                </tr>
                <tr>
                    <td>5.</td>
                    <td>Jelena</td>
                    <td>Perić</td>
                    <td>OŠ “Milan Milutinović”</td>
                    <td>68</td>
                </tr>
                -->