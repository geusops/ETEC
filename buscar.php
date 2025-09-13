<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <title>Listagem de Amigos - MYSQLI</title>
</head>

<body style="background-color:DodgerBlue;">
    <?php
    //Parameters to connect to the DB
    $servername = "localhost";
    $username = "root";
    $password = "";
    $dbname = "pwii";
    $conexao = new mysqli($servername, $username, $password, $dbname);

    //Testing connection
    if ($conexao->connect_error) {
        die("Connection failed: " . $conexao->connect_error);
    }
    echo '
                <div class="w3-paddingw3-content w3-half w3-display-topmiddle w3-margin">
                <h1 class="w3-center w3-cyan w3-margin w3-text-white">Alunos Concluintes</h1>
                <div id="divBusca">
                    <form action="" method="post">
                    <input name="pesquisa" type="text" class="w3-bar-item w3-input" placeholder="Buscar alunos"> 
                    <input type="submit" name="busca" class="w3-button w3-cyan w3-text-white" value="Buscar">
                    <input type="submit" name="limpa" class="w3-button w3-cyan w3-text-white" value="Limpar">
                    <input type="submit" name="ordena" class="w3-button w3-cyan w3-right w3-text-white" value="Ordenar por média">
                    <input type="submit" name="padrao" class="w3-button w3-cyan w3-right w3-text-white" value="Ordenação padrão">
                    </form>
                </div> <br>
                <table class="w3-table-all w3-centered">
                <thead>   
                    <tr class="w3-center w3-cyan w3-text-white">
                        <th>Código</th>
                        <th>Nome</th>
                        <th>Nota 1</th>
                        <th>Nota 2</th>
                        <th>Nota 3</th>
                        <th>Nota 4</th>
                        <th>Média</th>
                    </tr>
                <thead>
                ';
                // Reference to use the button as referent to trigger an action in PHP
                // https://stackoverflow.com/questions/36963288/how-to-print-input-with-php-code
                
    //Reference to create the search box
    //https://www.voxfor.com/how-to-build-a-live-search-box-with-php-mysql-and-ajax/
    //
    //Reference to check the unclicked button
    //https://www.php.net/manual/en/function.isset.php
    if (isset($_POST['busca']) == false) {
        $sql = "SELECT * FROM alunoconcluinte";
        $resultado = $conexao->query($sql);

        //Creating an array with the content of the query results
        //https://stackoverflow.com/questions/1501274/get-array-of-rows-with-mysqli-result
        $alunos = [];
        while ($aluno1 = $resultado->fetch_row()) {
            $alunos[] = $aluno1;
        }

        //Storing the student's notes to calculate the Avg
        foreach ($alunos as &$aluno) {
            $notas_aluno = [$aluno['2'], $aluno['3'], $aluno['4'], $aluno['5']];
            $soma_notas = array_sum($notas_aluno) / count($notas_aluno);
            $aluno['media'] = $soma_notas;
        }

        //Separating the key and value to sort
        if (isset($_POST['ordena'])) {
            foreach ($alunos as $key => $row) {
                $nome[$key] = $row['nome'];
                $bim1[$key] = $row['nota1'];
                $bim2[$key] = $row['nota2'];
                $bim3[$key] = $row['nota3'];
                $bim4[$key] = $row['nota4'];
                $media[$key] = $row['media'];
            }
            //sorting by Avg
            array_multisort($media, SORT_DESC, $alunos);
            
        } else if (isset($_POST['padrao'])) {
            //Separating the key and value to sort
            foreach ($alunos as $key => $row) {
                $codigo[$key] = $row['codigo'];
                $nome[$key] = $row['nome'];
                $bim1[$key] = $row['nota1'];
                $bim2[$key] = $row['nota2'];
                $bim3[$key] = $row['nota3'];
                $bim4[$key] = $row['nota4'];
                $media[$key] = $row['media'];
            }

            //sorting by code
            array_multisort($codigo, SORT_DESC, $alunos);
        }
        //adding the array values as table data
        foreach ($alunos as $linha) {
            echo '<tr>';
            echo '<td>' . $linha['0'] . '</td>';
            echo '<td>' . $linha['1'] . '</td>';
            echo '<td>' . $linha['2'] . '</td>';
            echo '<td>' . $linha['3'] . '</td>';
            echo '<td>' . $linha['4'] . '</td>';
            echo '<td>' . $linha['5'] . '</td>';
            echo '<td>' . $linha['media'] . '</td>';
            echo '</tr>';
        }

        echo '
                    </table>
                </div>';

    //Reference for triggering a PHP action with an HTML button/input
    //https://stackoverflow.com/questions/19323010/execute-php-function-with-onclick
    } else if (isset($_POST['busca'])) {
        //storing the text from the search bar to a variable
        $apresenta = $_POST["pesquisa"];
        //sending the query using the text from the search as condition to the WHERE/LIKE query
        $sql = "SELECT * FROM alunoconcluinte WHERE nome LIKE '%" . $apresenta . "%'";
        $resultado = $conexao->query($sql);
        $alunos = [];
        while ($aluno1 = $resultado->fetch_row()) {
            $alunos[] = $aluno1;
        }

        //calculating AVG
        foreach ($alunos as &$aluno) {
            $notas_aluno = [$aluno['2'], $aluno['3'], $aluno['4'], $aluno['5']];
            $soma_notas = array_sum($notas_aluno) / count($notas_aluno);
            $aluno['media'] = $soma_notas;
        }

        //adding the array values as table data
        foreach ($alunos as $linha) {
            echo '<tr>';
            echo '<td>' . $linha['0'] . '</td>';
            echo '<td>' . $linha['1'] . '</td>';
            echo '<td>' . $linha['2'] . '</td>';
            echo '<td>' . $linha['3'] . '</td>';
            echo '<td>' . $linha['4'] . '</td>';
            echo '<td>' . $linha['5'] . '</td>';
            echo '<td>' . $linha['media'] . '</td>';
            echo '</tr>';
        }

        echo '
                    </table>
                </div>';
    }

    $conexao->close();
    ?>
    </div>
</body>

</html>