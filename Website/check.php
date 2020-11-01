<?php
// ALL SQL REMOVED BECAUSE OF SECURITY REASONS!!!!!!!!
$output = '';
$keyold = 'MTc5NUE2NkZCQjk0RDFGOTkxMUU0ODg3MDBDM0I0QTMyLjkuOS4yY29yZSwgVmVyc2lvbj0yLjkuOS4yLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPW51bGw=';
$key = 'Qzc3MzVGNjBGREREMTUxNjQ0ODY0MEI2NTc0NTMxMUQyLjkuOS4yY29yZSwgVmVyc2lvbj0yLjkuOS4yLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPW51bGw=';
if(isset($_GET["cmd"]) && $_GET["key"] == $key){
	switch ($_GET["cmd"]) {
	case 'version':
		$output = "OK";
        break;
    case 'closealert':
        $output = "Guncelleme calismasi";
        break;
    case 'message':
        $output = "Buglar fixledi. Hile calismiyorsa ac kapa yapin iyi oyunlar...";
        break;
    case 'ismessage':
        $output = "acik";
        break;
	case 'msglink':
		$output = "https://discord.gg/PgWjHej";
        break;
    case 'ismsglink':
		$output = "kapali";
		break;
    case 'status':
        $output = "acik";
        break;
    case 'iscloselink':
        $output = "kapali";
        break;
    case 'closelink':
        $output = "http://lysep.com/coreproject/redir.html";
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
