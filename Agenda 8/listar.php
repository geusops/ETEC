<?php require_once ('verificarAcesso.php');?>
<?php require_once('cabecalho.php'); ?>
<a href="index.php" class="w3-display-topleft">
    <i class="fa fa-arrow-circle-left w3-large w3-brown w3-button w3-xxlarge"></i>     
</a> 
        <?php
            require_once 'conexaoBD.php'; 
                echo '
                <div class="w3-paddingw3-content w3-half w3-display-topmiddle w3-margin">
                <h1 class="w3-center w3-brown w3-round-large w3-margin">Listagem dos livros</h1>
                <table class="w3-table-all w3-centered">
                <thead>   
                    <tr class="w3-center w3-brown">
                        <th>Código</th>
                        <th>Nome</th>
                        <th>Autor</th>
                        <th>Editora</th>
                        <th>Páginas</th>
                        <th>Excluir</th>
                        <th>Atualizar</th>
                    </tr>
                <thead>
                ';
                $sql = "SELECT * FROM livraria" ;
                $resultado = $conexao->query($sql);
                if($resultado != null)
                foreach($resultado as $linha) {
                    echo '<tr>';
                    echo '<td>'.$linha['idlivro'].'</td>';
                    echo '<td>'.$linha['nome'].'</td>';
                    echo '<td>'.$linha['autor'].'</td>';
                    echo '<td>'.$linha['editora'].'</td>';
                    echo '<td>'.$linha['qtdepag'].'</td>';
                    echo '<td><a href="excluir.php?id='.$linha['idlivro'].'&nome='.$linha['nome'].'&autor='.$linha['autor'].'&editora='.$linha['editora'].'&qtdepag='.$linha['qtdepag'].'"><i class="fa fa-user-times w3-large w3-text-brown"></i> </a></td></td>';
                    echo '<td><a href="atualizar.php?id='.$linha['idlivro'].'&nome='.$linha['nome'].'&autor='.$linha['autor'].'&editora='.$linha['editora'].'&qtdepag='.$linha['qtdepag'].'"><i class="fa fa-refresh w3-large w3-text-brown""></i></a></td></td>';
                    echo '</tr>';
                }
                echo '
                    </table>
                </div>';
            $conexao->close();
        ?>
    </div>
</body>
</html>