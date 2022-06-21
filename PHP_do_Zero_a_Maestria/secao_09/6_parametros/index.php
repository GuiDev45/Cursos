<?php

    function velocidadeMaxima($vel) {

        echo "O carro atinge a velocidade máxima de $vel km/h <br>";

    }

    velocidadeMaxima(200); //O carro atinge a velocidade máxima de 200 km/h
    velocidadeMaxima(300); //O carro atinge a velocidade máxima de 300 km/h
    velocidadeMaxima(400); //O carro atinge a velocidade máxima de 400 km/h

    echo "Teste continuando <br>";

    $velocidade = 125;

    velocidadeMaxima($velocidade); //O carro atinge a velocidade máxima de 125 km/h

    //Vai ignorar o outro parametro no caso a string.
    velocidadeMaxima(250, "teste"); //O carro atinge a velocidade máxima de 250 km/h

    //Sem o tratamento ele vai imprimir a string.
    velocidadeMaxima("teste"); //O carro atinge a velocidade máxima de teste km/h

    //Com tratamento
    function velocidadeMaxima2($vel) {
        if (is_int($vel)) {
            echo "O carro atinge a velocidade máxima de $vel km/h <br>";
        }
        else {
            echo "Por favor, passe um número inteiro <br>";
        }
    }

    velocidadeMaxima2("teste"); //Por favor, passe um número inteiro

?>