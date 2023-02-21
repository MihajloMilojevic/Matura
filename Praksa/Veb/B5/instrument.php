<?php 
	$instrumenti = array(
		"zicani" => array(
			"naziv" => "Žičani instrumenti",
			"opis" => "Žičani instrumenti su muzički instrumenti kod kojih se zvuk proizvodi treperenjem njegovih žica. Muzičar može proizvoditi zvuk pomoću prstiju, trzalice ili gudalom (gudački instrumenti), a drugi udaranjem po strunama lakim drvenim čekićem. Kod nekih klavijaturnih instrumenata, kao što je čembalo, muzičar pritisne tipku čime se okida žica. Drugi muzički instrumenti generišu zvuk udaranjem u žicu."
		),
		"gudacki" => array(
			"naziv" => "Gudački instrumenti",
			"opis" => "Gudački instrumenti su dobili ime zbog načina dobijanja tona: prevlačenje gudala preko žice izaziva treperenje žice i stvara ton. Gudački instrumenti imaju četiri žica različite debljine. Najdublje tonove proizvode prezne (nedodirnute) žice, dok viši tonovi nastaju njihovim skraćivanjem, što se postiže pritiskom prstiju leve ruke po žicama. Svi instrumenti ove grupe su slične građe i oblika, ali različite veličine, opsega tonova i boje zvuka. U ove instrumente spadaju: violina, violončelo, viola i kontrabas."
		),
		"dirke" => array(
			"naziv" => "Instrumenti s dirkama",
			"opis" => "Instrumenti sa dirkama su grupa muzičkih instrumenata koji koriste klavijaturu i njene tipke kao glavni izvor zvuka. Najpoznatiji instrumenti ovog tipa su klavir, orgulje, električna klavijatura i drugi"
		),
		"udaraljke" => array(
			"naziv" => "Udarački instrumenti",
			"opis" => "Udaraljke su po građi najprimitivniji rod muzičkih instrumenata. Od pradavnih vremena pa do danas one su se javljale u različitim oblicima i vrstama u narodnoj i umetničkoj muzici. Zvuk se dobija udarom po zvučnom izvoru. Udara se rukom (tamburin), raznim vrstama palica (timpani, gong, zvona, ksilofon i drugi), metalnom šipkom (trijangl) ili jednom površinom o drugu (čineli, kastanjete), ređe pomoću mehanizma (čelesta)"
		),
		"duvacki" => array(
			"naziv" => "Duvački instrumenti",
			"opis" => "Duvački instrumenti, kako i sam naziv kaže, su instrumenti na kojima se ton proizvodi duvanjem, obično iz usta i pluća svirača. Duvački instrumenti su jedna velika i raznovrsna porodica. Razlikuju se po obliku, materijalu, načinu duvanja i ulozi. Oni spadaju u aerofone instrumente."
		)
	);

	if(empty($_GET["klasa"])) {
		header("location: /");
		exit(0);
	}
	$instrument = $instrumenti[$_GET["klasa"]];
	if(empty($instrument)) {
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
	<title><?php echo $instrument["naziv"]; ?></title>
</head>
<body>
	<h1><?php echo $instrument["naziv"]; ?></h1>
	<p><?php echo $instrument["opis"]; ?></p>
</body>
</html>