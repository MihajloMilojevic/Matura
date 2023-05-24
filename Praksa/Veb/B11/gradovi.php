<?php 
	$gradovi = array(
		"beograd" => array(
			"ime" => "Beograd",
			"tekst" => "Beograd, Beograd, Beograd......"
		),
		"novi-sad" => array(
			"ime" => "Novi Sad",
			"tekst" => "Novi Sad, Novi Sad, Novi Sad......"
		),
		"kraljevo" => array(
			"ime" => "Kraljevo",
			"tekst" => "Kraljevo, Kraljevo, Kraljevo......"
		),
		"nis" => array(
			"ime" => "Niš",
			"tekst" => "Niš, Niš, Niš......"
		),
		"kragujevac" => array(
			"ime" => "Kragujevac",
			"tekst" => "Kragujevac, Kragujevac, Kragujevac......"
		)
	);

	if(empty($_GET["grad"])) {
		header("location: /");
		exit(0);
	}
	$grad = $gradovi[$_GET["grad"]];
	if(empty($grad)) {
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
	<link rel="stylesheet" href="./css/grad.css">
	<title><?php echo $grad["ime"]; ?></title>
</head>
<body>
	<h1><?php echo $grad["ime"]; ?></h1>
	<p><?php echo $grad["tekst"]; ?></p>
</body>
</html>