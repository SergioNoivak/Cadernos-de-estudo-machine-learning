# neighborJoining

Na bioinformática o NeighborJoining é um algoritmo para criação de árvores filogenéticas. É muito útil para árvores baseadas em DNA 
e proteínas. O algoritmo requer conhecimento prévio da matriz de distância, que é uma matriz que representa a distância filogenética 
de cada taxon.

### O algorítmo
Passos:

````

0) Inicialmente se tem uma topologia estrela.
1) Então é feito o cálculo da matriz Q.
2) Seleciona-se o par de nós em Q com menor valor, para então conectar a um novo no u.
3) Calcula-se a distância do nó novo aos nós do par.
4) Calcula-se a distância do nó aos nós fora do par.
5) Retorne ao passo 1 com a matriz de distância dos nós do par substituidos pelo nó novo.

````









