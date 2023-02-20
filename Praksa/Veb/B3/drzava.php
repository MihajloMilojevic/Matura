<?php 
	$drzave = array(
		"srbija" => array(
			"naziv" => "SRBIJA",
			"glavni_grad" => "Beograd",
			"stanovnici" => "6,834 miliona",
			"povrsina" => "88.499 km²"
		),
		"madjarska" => array(
			"naziv" => "MAĐARSKA",
			"glavni_grad" => "Budimpešta",
			"stanovnici" => "9,730 miliona",
			"povrsina" => "93,030 km²"
		),
		"hrvatska" => array(
			"naziv" => "HRVATSKA",
			"glavni_grad" => "Zagreb",
			"stanovnici" => "3,899 miliona",
			"povrsina" => "56.594 km²"
		),
		"bih" => array(
			"naziv" => "BOSNA I HERCEGOVINA",
			"glavni_grad" => "Sarajevo",
			"stanovnici" => "3,271 miliona",
			"povrsina" => "51.209 km²"
		),
		"crna_gora" => array(
			"naziv" => "CRNA GORA",
			"glavni_grad" => "Podgorica",
			"stanovnici" => "619.211",
			"povrsina" => "13.812 km²"
		),
		"albanija" => array(
			"naziv" => "ALBANIJA",
			"glavni_grad" => "Tirana",
			"stanovnici" => "2,812 miliona",
			"povrsina" => "28.748 km²"
		),
		"makedonija" => array(
			"naziv" => "MAKEDONIJA",
			"glavni_grad" => "Skoplje",
			"stanovnici" => "2,065 miliona",
			"povrsina" => "25.713 km²"
		),
		"bugarska" => array(
			"naziv" => "BUGARSKA",
			"glavni_grad" => "Sofija",
			"stanovnici" => "6,863 miliona",
			"povrsina" => "110.993 km²"
		),
		"rumunija" => array(
			"naziv" => "RUMUNIJA",
			"glavni_grad" => "Bukurešt",
			"stanovnici" => "19,12 miliona",
			"povrsina" => "238.397 km²"
		),
	);

	if(empty($_GET["drzava"])) {
		header("location: /");
		exit(0);
	}
	$drzava = $drzave[$_GET["drzava"]];
	if(empty($drzava)) {
		header("location: /");
		exit(0);
	}
?>
<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<link rel="shortcut icon" href="./slike/LOGO.ico" type="image/x-icon">
	<link rel="stylesheet" href="./css/global.css">
	<link rel="stylesheet" href="./css/drzava.css">
	<title><?php echo $drzava["naziv"]; ?></title>
</head>
<body>
	<h1><?php echo $drzava["naziv"]; ?></h1>
	<p>Glavni grad: <?php echo $drzava["glavni_grad"]; ?></p>
	<p>Broj stanovnika: <?php echo $drzava["stanovnici"]; ?></p>
	<p>Površina: <?php echo $drzava["povrsina"]; ?></p>
</body>
</html>