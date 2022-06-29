<?php
//PDO (PHP Data Object) é uma extensão da linguagem PHP para acesso a banco de dados. Totalmente orientado a objetos

    //Essa é a forma de se conectar com o banco usando o PDO.
    $host = "localhost";
    $db = "cursophp";
    $user = "root";
    $pass = "";

    $conn = new PDO("mysql:host=$host;dbname=$db", $user, $pass);

    //ASSUNTO DA AULA
    $id = 1;

    $stmt = $conn->prepare("SELECT * FROM itens WHERE id > :id");

    $stmt->bindParam(":id", $id);

    $stmt->execute();

    $data = $stmt->fetch(PDO::FETCH_ASSOC); //Traz o dado de uma linha, é parecido com o row, e PDO::FETCH_ASSOC, é uma formatação melhor do array associativo

    print_r($data);

    $itens = $stmt->fetchAll(PDO::FETCH_ASSOC); //Traz todos os dados, no caso os dados da tabela itens.

    print_r($itens);

    /*Saída
    Array ( [id] => 2 [nome] => Teclado Microsoft [descricao] => Este teclado é novo e está na caixa. )
    Array ( [0] => Array ( [id] => 2 [nome] => Teclado Microsoft [descricao] => Este teclado é novo e está na caixa. ) [1] => Array ( [id] => 4 [nome] => Suporte monitor [descricao] => O suporte está novo e na caixa ainda. ) )
    */