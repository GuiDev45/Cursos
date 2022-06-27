<?php

    print_r($_SERVER);

    echo "<br>";

    echo $_SERVER['MYSQL_HOME'] . "<br>";

    if ($SERVER['MYSQL_HOME'] == 'localhost') {
        echo "Está acessando o localhost <br>";
    }

?>