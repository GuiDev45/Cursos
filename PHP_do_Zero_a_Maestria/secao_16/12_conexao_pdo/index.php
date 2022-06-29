<?php
//PDO (PHP Data Object) é uma extensão da linguagem PHP para acesso a banco de dados. Totalmente orientado a objetos

    //Essa é a forma de se conectar com o banco usando o PDO.
    $host = "localhost";
    $db = "cursophp";
    $user = "root";
    $pass = "";

    $conn = new PDO("mysql:host=$host;dbname=$db", $user, $pass);
