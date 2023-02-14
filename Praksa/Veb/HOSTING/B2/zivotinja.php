<?php 
	$zivotinje = array(
		"pas" => array(
			"naslov" => "Pas",
			"opis" => "Pas (lat. Canis lupus familiaris) je pripitomljeni sisar iz porodice Canidae. Arheološki nalazi dokazuju da pas najmanje 9000 godina živi uz čoveka, iako postoje indicije da se taj period produži na čitavih 14.000 godina. Fosilni ostaci pokazuju da su preci modernog psa živeli uz čoveka još pre 10.000 godina."
		),
		"patka" => array(
			"naslov" => "Patka",
			"opis" => "Patka je opšti naziv za veliki broj vrsta ptica iz familije Anatidae koja uključuje i labudove i guske. Patke su podeljenje u više podfamilija u okviru familije Anatidae, one nisu monofilična grupa (grupa potomaka koja ima jednog zajedničkog pretka) već čine takson pošto se labudovi i guske ne smatraju patkama. Patke su uglavnom vodene ptice uglavnom manje od labudova i guski i mogu se naći u rečnim i morskim vodama."
		),
		"macka" => array(
			"naslov" => "Mačka",
			"opis" => "Mačka, takođe zvana i domaća mačka ili kućna mačka (lat. Felis catus), mali je mesožder, vrsta sisara iz roda Felis. Veruje se da je njen predak bila afrička divlja mačka (Felis silvestris lybica). Mačke žive u bliskoj vezi sa ljudima najmanje 9.500 godina."
		),
		"kokoska" => array(
			"naslov" => "Kokoška",
			"opis" => "Kokoška, kokoš ili domaća kokoš (lat. Gallus gallus domesticus) je podvrsta ptice koja se često gaji kao živina. Smatra se da je poreklom iz jugoistočne Azije, i da je evoluirala od divljih podvrsta vrste Gallus gallus. Ova ptica je najrasprostranjenija na zemlji, sa totalnom populacijom od preko 19 milijardi po proceni iz 2011. godine. Ljudi uzgajaju kokoške prvenstveno kao izvor hrane, konzumirajući njihovo meso i jaja."
		),
		"krava" => array(
			"naslov" => "Krava",
			"opis" => "Krava je odrasla ženka. Mliječna krava se uzgaja zbog proizvodnje mlijeka, koje se prerađuje u brojne prehrambene proizvode: konzumno mlijeko, pavlaka, kajmak, razne vrste sireva, puter i slično. Domesticiranje je počelo prvo radi mesa, a kasnije radi mlijeka i njihove snage korištene za vuču. Mladunče krave se zove tele."
		),
	);

	if(empty($_GET["zivotinja"])) {
		header("location: /");
		exit(0);
	}
	$zivotinja = $zivotinje[$_GET["zivotinja"]];
?>
<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<link rel="shortcut icon" href="./slike/LOGO.ico" type="image/x-icon">
	<link rel="stylesheet" href="./css/global.css">
	<link rel="stylesheet" href="./css/zivotinja.css">
	<title><?php echo $zivotinja["naslov"]; ?></title>
</head>
<body>
	<h1><?php echo $zivotinja["naslov"]; ?></h1>
	<p><?php echo $zivotinja["opis"]; ?></p>
</body>
</html>