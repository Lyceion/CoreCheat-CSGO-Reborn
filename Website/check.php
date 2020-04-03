<?php
$output = '';
$key = 'QTc1NjQ2RDVCNUY1MERCMzMwNDk5Njg1NjkzNTQ5NEYyLjkuOC4wY29yZSwgVmVyc2lvbj0yLjkuOC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPW51bGw=';
$keyold = 'RUZBQjBCNUE4M0I5RkU3RkM4NTQ0QkQ1Nzk4NjI1MEQyLjkuNy4wY29yZSwgVmVyc2lvbj0yLjkuNy4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPW51bGw=';
if(isset($_GET["cmd"]) && $_GET["key"] == $key){
	switch ($_GET["cmd"]) {
	case 'version':
		$output = "OK";
        break;
    case 'closealert':
        $output = "1. Oyunun cokme sebebini bulmus bulunmaktayim. Bu konuda calismalarim yarin aksama dogru baslayacak.\n2. Trigger'a istediginiz gibi tus destegi eklicem ama vaktim olmadigindan az tus olucak.\n3. Aimbot konusundaki calismalarimiz bitmek uzere. Bu kadar uzun surmesinin nedeni aimbot u belli etmesinden dolayi sevmememiz ve algoritmayi 0 dan tamamen bastan bizim yazmis olmamiz.\n4. Skinchanger in kodlari hazir usengecliyimizden eklemiyoruz bunun da haberini vereyim.\n5. Butun SDK mi bastan yazmayi planiyorum. Bundan dolayi sonraki updatelerde yuksek miktarda hile hatalari vesaire gelebilir cunku durup yazicak vaktim yok. Bunlari sizlerle beraber cozecegiz.\n\nHerkese hayirli aksamlar diliyorum. Hile 1 gun boyunca kapali. (29.08.2019 aksamina dogru acilir...)";
        break;
    case 'message':
        $output = "Hazir kapatiyoruz, sizi son konusmalarimiz icin discordumuza alalim: https://discord.gg/PgWjHej";
        break;
    case 'ismessage':
        $output = "acik";
        break;
	case 'msglink':
		$output = "https://discord.gg/PgWjHej";
        break;
    case 'ismsglink':
		$output = "acik";
		break;
    case 'status':
        $output = "acik";
        break;
    case 'iscloselink':
        $output = "kapali";
        break;
    case 'closelink':
        $output = "http://lysep.com/corecheat/redir.html";
        break;
    case 'cheaterr':
        $output = "Sectiginiz Hilenin Girisleri Su An Kapalidir. En Kisa Zamanda Aktif Olucak!";
        break;
    case 'panorama':
        $output = "acik";
        break;
    case 'legit':
        $output = "acik";
        break;
    case 'wallhack':
        $output = "acik";
        break;
    case 'cheats':
		$output = "Version Panorama\nFully Legit\nOnly Wallhack";
        break;
    case 'csgomd5':
        $output = "asd";
        break;
	default:
		$output = "wrong shit.";
        break;
    }
}
else{
    if($_GET["cmd"] == 'update'){
        $output = "https://memoryhackers.org/konular/corecheat-csgo-lsmake-wallhack-radar-bunnyhop-antiflash.77585/";
    }
    else if($_GET["cmd"] == 'updaterVersion'){
        $output = "MS4wLjAuMA==";
    }
    else{
        echo("old");
    }
	
}
echo $output;
?>
