<?php

    $cincodias = strtotime("5 days");

    echo $cincodias . "<br>";

    $dezdias = strtotime("10 days");

    echo $dezdias . "<br>";

    $dataAtualMais5 = date('d/m/y', $cincodias);

    echo $dataAtualMais5 . "<br>";

    $dataAtualMais10 = date('d/m/y', $dezdias);

    //Saída
    /*
    1655657625
    1656089625
    19/06/22
    */

?>