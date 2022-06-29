<?php

    $host = "localhost";
    $user = "root";
    $pass = "";
    $db = "cursophp";

    $conn = new mysqli($host, $user, $pass, $db);

    //ASSUNTO DA AULA

    //CRIANDO
    //$q = "CREATE TABLE teste (nome VARCHAR(100), sobrenome VARCHAR(100))"; //teste é o nome da tabela, e () as colunas.

    //DELETANDO
    $q = "DROP TABLE teste";

    $conn->query($q);

    $conn->close();

    /*Saída
    O simples fato de recarregar a página é executar o arquivo.
    */
?>