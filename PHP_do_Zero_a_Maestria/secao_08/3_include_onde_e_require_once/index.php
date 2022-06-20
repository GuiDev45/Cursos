<?php

    //Arquivos que não existem
    //include_once "teste.php";

    include_once "teste2.php";//Saída: TESTANDO INCLUDE ONCE
    include_once "teste2.php";//Não vai ter saída porque o _once só inclui uma vez, então essa replicação de arquivo é dencessária.

    //Isso acontece com o require_once também, não tem sobreposição.

    include "teste2.php";//Saída: TESTANDO INCLUDE ONCE
    include "teste2.php";//Saída: TESTANDO INCLUDE ONCE

?>

<p>Testando código!</p>