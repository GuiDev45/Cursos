<?php

    $host = "localhost";
    $user = "root";
    $pass = "";
    $db = "cursophp";

    $conn = new mysqli($host, $user, $pass, $db);

    //ASSUNTO DA AULA

    $q = "SELECT * FROM itens";

    $result = $conn->query($q);

    $conn->close();

    //TRAZ UM RESULTADO
    $item = $result->fetch_assoc();

    //TRAZ TODOS OS RESULTADOS
    $itens = $result->fetch_all();

    print_r($itens);

    /*Saída
    Array ( [id] => 1 [nome] => Xícara [descricao] => É uma xícara usada de cor rosa )
    se tivesse mais itens seria impresso.
    */
