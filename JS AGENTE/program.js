"use strict";
exports.__esModule = true;
var Grafo_1 = require("./Grafo");
var No_1 = require("./No");
var Agente_1 = require("./Agente");
var grafo = new Grafo_1.Grafo();
for (var i = 0; i < 5; i++) {
    grafo.adicionarVetor(new No_1.No(i));
}
for (var i = 0; i < 5; i++) {
    for (var j = 0; j < 5; j++) {
        grafo.vetor[i].adicionarAresta(grafo.vetor[j], 1);
    }
}
var a = new Agente_1.Agente(grafo, grafo.vetor[0]);
a.DFS_visit();
console.log(JSON.stringify(a.grafoEstados));
